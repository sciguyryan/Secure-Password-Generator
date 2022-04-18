using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            if (ver is null)
            {
                return "";
            }

            return ver.ToString();
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
