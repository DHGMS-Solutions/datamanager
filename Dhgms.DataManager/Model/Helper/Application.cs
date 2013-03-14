// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Application.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Helper task for generic application tasks
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System.Configuration;

    /// <summary>
    /// Helper task for generic application tasks
    /// </summary>
    public static class Application
    {
        #region Public Methods and Operators

        /// <summary>
        /// Loads the application settings
        /// </summary>
        /// <typeparam name="TApplicationSettings">
        /// </typeparam>
        /// <returns>
        /// </returns>
        public static TApplicationSettings LoadConfigFile<TApplicationSettings>()
            where TApplicationSettings : ConfigurationSection
        {
            object section = ConfigurationManager.GetSection("applicationSettings");
            var settings = (TApplicationSettings)section;

            // validate the settings
            return settings;
        }

        #endregion
    }
}