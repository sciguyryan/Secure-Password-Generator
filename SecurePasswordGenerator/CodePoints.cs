using System.Globalization;
using System.Text;

namespace SecurePasswordGenerator
{
    internal class ViableCodePoints
    {
        /// <summary>
        /// The current version of the unicode standard being used.
        /// </summary>
        private const string UnicodeVersion = "15.0.0";

        /// <summary>
        /// The delimiter used in the cache data file.
        /// It must not be the same character as any character found in any of the lists.
        /// </summary>
        private const char Delimiter = '\0';

        /// <summary>
        /// A list of all basic (Latin) letters. a-z and A-Z.
        /// </summary>
        public string Letters = "";
        private const string _Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// A list of all basic numbers. 0-9.
        /// </summary>
        public string Numbers = "";
        private const string _Numbers = "1234567890";

        /// <summary>
        /// A list of common symbols.
        /// </summary>
        public string Symbols = "";
        private const string _Symbols = " !\"#$%&\'()*+,-./\\:;?@[]^_`{|}~£^!|";

        /// <summary>
        /// A list of all applicable unicode code points.
        /// </summary>
        public string Unicode { get; private set; } = "";

        /// <summary>
        /// A list of all applicable Emoji code points.
        /// </summary>
        public string Emoji { get; private set; } = "";

        public ViableCodePoints()
        {
            ReadCacheFile();
        }

        #region Emoji Processing
        /// <summary>
        /// Update the Emoji codepoint list.
        /// </summary>
        public void UpdateEmojiCodePoints()
        {
            Emoji = GetViableEmojiCodePoints();
        }

        /// <summary>
        /// Get the path to the Emoji codepoint cache file.
        /// </summary>
        /// <returns>A string containing the path to the Emoji codepoint cache file.</returns>
        private static string GetViableEmojiCodePoints()
        {
            // The unicode Emoji files never contain the build value.
            var emojiVersion = UnicodeVersion[..UnicodeVersion.LastIndexOf(".")];

            using var client = new HttpClient();
            var file1 = client.GetStringAsync($"https://unicode.org/Public/emoji/{emojiVersion}/emoji-sequences.txt").Result;
            var basic = ParseEmojiSequencesFile(ref file1);

            var file2 = client.GetStringAsync($"https://unicode.org/Public/emoji/{emojiVersion}/emoji-zwj-sequences.txt").Result;
            var zwj = ParseEmojiSequencesFile(ref file2);

            return basic + zwj;
        }

        /// <summary>
        /// Parse the unicode Emoji combination files.
        /// </summary>
        /// <returns>A string containing all of the valid unicode Emoji codepoints.</returns>
        private static string ParseEmojiSequencesFile(ref string contents)
        {
            var sb = new StringBuilder();

            var lines = contents.Split(new [] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                // These are comments.
                if (line.StartsWith('#'))
                {
                    continue;
                }

                // Each line looks any of the following:
                // 1F468; [blah]
                // 1F468..1F469; [blah]
                // 1F468 200D 2764 FE0F 200D 1F468; [blah]
                // Where each hex number is a character, and the semi-colon marks the end of the data segment.
                var trimmed = line[..line.IndexOf(';')].TrimEnd();
                if (trimmed.Contains(".."))
                {
                    // We are dealing with a range.
                    var substring = trimmed.Split("..");
                    if (substring.Length != 2)
                    {
                        // This should never happen.
                        continue;
                    }

                    var start = int.Parse(substring[0], NumberStyles.HexNumber);
                    var end = int.Parse(substring[1], NumberStyles.HexNumber);

                    for (var i = start; i < end; i++)
                    {
                        sb.Append(char.ConvertFromUtf32(i));
                    }
                }
                else
                {
                    var hexIDs = trimmed.Split(' ', StringSplitOptions.None);
                    foreach (var hexID in hexIDs)
                    {
                        // In this case we can trust that these are valid numbers.
                        var id = int.Parse(hexID, NumberStyles.HexNumber);

                        // We can't simply append a character where the index is above
                        // 0xffff, so we must use the unicode code point converter instead.
                        sb.Append(char.ConvertFromUtf32(id));
                    }
                }
            }

            return sb.ToString();
        }
        #endregion // Emoji Processing

        #region Unicode Processing
        /// <summary>
        /// Update the unicode codepoint list.
        /// </summary>
        public void UpdateUnicodeCodePoints()
        {
            Unicode = GetViableUnicodeCodePoints();
        }

        /// <summary>
        /// Parse the unicode character files.
        /// </summary>
        /// <returns>A string containing all of the applicable unicode codepoints.</returns>
        private static string GetViableUnicodeCodePoints()
        {
            using var client = new HttpClient();
            var file = client.GetStringAsync($"https://unicode.org/Public/{UnicodeVersion}/ucd/UnicodeData.txt").Result;
            return ParseUnicodeDataFile(ref file);
        }

        /// <summary>
        /// Parse the unicode data file.
        /// </summary>
        /// <returns>A string containing all of the applicable unicode codepoints.</returns>
        private static string ParseUnicodeDataFile(ref string contents)
        {
            var sb = new StringBuilder();

            // A list of all of the unicode categories we are not interested in.
            // See https://unicodeplus.com/category
            var bannedCategories = new[]
            {
                // Control.
                "Cc",
                // Unassigned
                "Cn",
                // Private Use
                "Co",
                // Surrogate
                "Cs",
                // Line Separator
                "Zl",
                // Paragraph Separator
                "Zp",
                // Space Separator
                "Zs"
            };

            var lines = contents.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var segments = line.Split(";");

                // In this case we can trust that these are valid numbers.
                var id = int.Parse(segments[0], NumberStyles.HexNumber);

                // We want to skip emoji, they are handled seperately.
                if (id is >= 0x1f600 and <= 0x1f64f)
                {
                    continue;
                }

                // We also want to skip the unicode replacement character.
                if (id == 0xfffd)
                {
                    continue;
                }

                // We will elimininate any character that belong
                // to any of the categories we do not want.
                // Spaces will be excluded from elimination.
                if (id != 0x0020 && bannedCategories.Contains(segments[2]) )
                {
                    continue;
                }

                // We can't simply append a character where the index is above
                // 0xffff, so we must use the unicode code point converter instead.
                sb.Append(char.ConvertFromUtf32(id));
            }

            return sb.ToString();
        }
        #endregion // Unicode Processing

        /// <summary>
        /// Load the default values and write the cache file.
        /// </summary>
        private void LoadAndSaveDefaults()
        {
            Letters = _Letters;
            Numbers = _Numbers;
            Symbols = _Symbols;

            UpdateUnicodeCodePoints();
            UpdateEmojiCodePoints();

            WriteCacheFile();
        }

        /// <summary>
        /// Get the expected path to the current cache file.
        /// </summary>
        /// <returns>A string containing the path to the current cache file.</returns>
        private static string GetExpectedCacheFilePath()
        {
            // The current cache hashcode will be created by combining the
            // version of the program and the version of unicode being used.
            var hashCode = (Utils.GetAssemblyVersion() + UnicodeVersion)
                .GetStableHashCode()
                .ToString("X4");

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                $"cache-{hashCode}.bin");
        }

        /// <summary>
        /// Attempts to read the cache file. If the file cannot be found then
        /// the defaults will be loaded and a cache file created.
        /// </summary>
        public void ReadCacheFile()
        {
            var cachePath = GetExpectedCacheFilePath();
            if (!File.Exists(cachePath))
            {
                LoadAndSaveDefaults();
                return;
            }

            // This will hold all of the string segments.
            var strings = new List<string>();

            // Read the entire contents of the cache file, in byte form.
            var bytes = File.ReadAllBytes(cachePath);
            var len = bytes.Length;

            // Split the cache file into segments, split by the specified
            // deliminator.
            var segmentBytes = new List<byte>();
            for (var i = 0; i < len; i++)
            {
                var b = bytes[i];

                // We have hit the end of segment marker.
                if (b == Delimiter || i == len - 1)
                {
                    strings.Add(segmentBytes.ToArray().FromByteArray());
                    segmentBytes.Clear();

                    continue;
                }

                segmentBytes.Add(b);
            }

            if (strings.Count != 5)
            {
                MessageBox.Show("The cache file was corrupted and will be recreated.");
                LoadAndSaveDefaults();
                return;
            }

            // Apply the loaded strings.
            Letters = strings[0];
            Numbers = strings[1];
            Symbols = strings[2];
            Emoji = strings[3];
            Unicode = strings[4];
        }

        /// <summary>
        /// Attempts to write a cache file.
        /// </summary>
        public void WriteCacheFile()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Delete all of the old cache files.
            var files = Directory.GetFiles(basePath, "*.bin");
            foreach (var f in files)
            {
                if (!f.StartsWith("cache-"))
                {
                    continue;
                }

                File.Delete(f);
            }

            // Create the new cache file.
            var path = GetExpectedCacheFilePath();
            try
            {
                var bytes =
                    (Letters + Delimiter + Numbers + Delimiter +
                    Symbols + Delimiter + Emoji + Delimiter +
                    Unicode).ToByteArray();
                using var f = new FileStream(path, FileMode.Create, FileAccess.Write);
                f.Write(bytes, 0, bytes.Length);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception caught while attempting to create cache file: {ex}");
                return;
            }
        }
    }
}
