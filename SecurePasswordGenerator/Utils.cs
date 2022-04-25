using System.Reflection;

namespace SecurePasswordGenerator
{
    internal class Utils
    {
        /// <summary>
        /// Get the version of the application.
        /// </summary>
        /// <returns>A string containing the version of the application, in the standard format.</returns>
        public static string GetAssemblyVersion()
        {
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            return ver is null ? "" : ver.ToString();
        }

        /// <summary>
        /// Gets the icon for the application.
        /// </summary>
        /// <returns>An icon for the current application, may be null in certain circumstances.</returns>
        public static Icon? GetApplicationIcon()
        {
            return Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }
    }
}
