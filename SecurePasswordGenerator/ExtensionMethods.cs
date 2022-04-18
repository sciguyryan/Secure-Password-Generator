using System.Globalization;
using System.Text;

namespace SecurePasswordGenerator
{
    static class ExtensionMethods
    {
        public static List<string> GetCodePoints(this string str)
        {
            var codePoints = new List<string>();

            var codePointEnumerator = StringInfo.GetTextElementEnumerator(str);
            while (codePointEnumerator.MoveNext())
            {
                codePoints.Add(codePointEnumerator.GetTextElement());
            }

            return codePoints;
        }

        public static int CountCodePoints(this string str)
        {
            return str.GetCodePoints().Count;
        }

        public static string DeduplicateCodePoints(this string str)
        {
            var codePoints = str.GetCodePoints();

            var deduplicated = new List<string>();
            foreach (var codePoint in codePoints)
            {
                if (!deduplicated.Contains(codePoint))
                {
                    deduplicated.Add(codePoint);
                }
            }

            return string.Join("", deduplicated);
        }

        // This is a modified version of the default hash code
        // generator from below. It has been modified to be stable.
        // https://referencesource.microsoft.com/#mscorlib/system/string.cs,827
        public static int GetStableHashCode(this string str)
        {
            unchecked
            {
                int hash1 = 5381;
                int hash2 = hash1;

                for (int i = 0; i < str.Length && str[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ str[i];
                    if (i == str.Length - 1 || str[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ str[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }

        public static byte[] ToByteArray(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public static string FromByteArray(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
