using System;
using System.Linq;
using System.Text;
using System.Globalization;

namespace SecurePasswordGenerator
{
    class ViableCharacters
    {
        public const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string Numbers = "1234567890";
        public const string Symbols = " !\"#$%&\'()*+,-./\\:;?@[]^_`{|}~£^!|";
        public readonly static string Unicode = GetViableUnicodeCharacters();

        public ViableCharacters()
        {
        }

        private static string GetViableUnicodeCharacters()
        {
            var max = (int)char.MaxValue;
            var sb = new StringBuilder(max);
            for (var i = 0; i < max; i++)
            {
                var c = (char)i;
                if (ViableCharacters.IsPrintableCharacter(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        private static bool IsPrintableCharacter(char c)
        {
            // See https://stackoverflow.com/questions/3253247/how-do-i-detect-non-printable-characters-in-net

            if (c == 0x2028 || c == 0x2029)
            {
                return false;
            }

            // To ensure that we don't get new lines and whatnot.
            if (char.IsWhiteSpace(c))
            {
                return false;
            }

            // See https://docs.microsoft.com/en-us/dotnet/api/system.globalization.unicodecategory?view=netframework-4.8
            var nonRenderingCategories = new UnicodeCategory[] {
                UnicodeCategory.Control,
                UnicodeCategory.OtherNotAssigned,
                UnicodeCategory.Surrogate,
                UnicodeCategory.LineSeparator,
                UnicodeCategory.ParagraphSeparator
            };

            return !nonRenderingCategories.Contains(Char.GetUnicodeCategory(c));
        }
    }
}
