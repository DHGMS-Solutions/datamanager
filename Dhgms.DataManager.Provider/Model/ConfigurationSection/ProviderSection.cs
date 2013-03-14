// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="ProviderSection.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   XML Configuration Section for Providers
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationSection
{
    using System;
    using System.Configuration;

    /// <summary>
    /// XML Configuration Section for Providers
    /// </summary>
    public class ProviderSection : ConfigurationSection
    {
        #region Public Properties

        /// <summary>
        /// The name of the default provider
        /// </summary>
        [StringValidator(MinLength = 1)]
        [ConfigurationProperty("defaultProvider", DefaultValue = "Default Provider")]
        public string DefaultProvider
        {
            get
            {
                return (String)base["defaultProvider"];
            }

            set
            {
                base["defaultProvider"] = value;
            }
        }

        /// <summary>
        /// A collection of registered providers.
        /// </summary>
        [ConfigurationProperty("providers")]
        public ProviderSettingsCollection Providers
        {
            get
            {
                return (ProviderSettingsCollection)base["providers"];
            }
        }

        #endregion
    }
}