using System.Globalization;
using System.Text;

namespace SecurePasswordGenerator
{
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Get the number of code points that comprise a string.
        /// </summary>
        /// <param name="str">The string to be processed.</param>
        /// <returns>An integer giving the number of code points that comprise the string.</returns>
        public static int GetNumberOfCodePoints(this string str)
        {
            return str.GetCodePoints().Length;
        }

        /// <summary>
        /// Remove duplicate code points from a string.
        /// </summary>
        /// <param name="str">The string to be processed.</param>
        /// <returns>An array containing the deduplicated code points that comprise the string.</returns>
        public static string[] DeduplicateCodePoints(this string str)
        {
            return str.GetCodePoints().Distinct().ToArray();
        }

        // This is a modified version of the default hash code
        // generator from below. It has been modified to be stable.
        // https://referencesource.microsoft.com/#mscorlib/system/string.cs,827
        /// <summary>
        /// Get a stable (non-changing) hashcode for a string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>A string containing the hash for the input string.</returns>
        public static int GetStableHashCode(this string str)
        {
            unchecked
            {
                var hash1 = 5381;
                var hash2 = hash1;

                for (var i = 0; i < str.Length && str[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ str[i];
                    if (i == str.Length - 1 || str[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ str[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }

        /// <summary>
        /// Get an array containing all of the unicode code points that comprise a string.
        /// </summary>
        /// <param name="str">The string to be processed.</param>
        /// <returns>An array listing all of the code points that comprise the string.</returns>
        public static string[] GetCodePoints(this string str)
        {
            var codePoints = new List<string>();

            var codePointEnumerator = StringInfo.GetTextElementEnumerator(str);
            while (codePointEnumerator.MoveNext())
            {
                codePoints.Add(codePointEnumerator.GetTextElement());
            }

            return codePoints.ToArray();
        }

        /// <summary>
        /// Convert a string into a byte array.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>An byte array containing the UTF-8 encoded bytes of the string.</returns>
        public static byte[] ToByteArray(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        /// <summary>
        /// Convert a UTF-8 byte array into a string.
        /// </summary>
        /// <param name="bytes">An byte array containing the UTF-8 encoded bytes of the string.</param>
        /// <returns>A string representing the UTF-8 encoded bytes.</returns>
        public static string FromByteArray(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
