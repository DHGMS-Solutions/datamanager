// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XmlAppConfigConfigurationLoader.cs" company="DHGMS Solutions">
//   Copyright 2004-2014 DHGMS Solutions.
//      
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//      
//   http://www.apache.org/licenses/LICENSE-2.0
//      
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <summary>
//   The xml app config configuration loader.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationLoader
{
    using System.Configuration;

    /// <summary>
    /// The xml app config configuration loader.
    /// </summary>
    /// <typeparam name="TApplicationConfiguration">
    /// The application configuration type.
    /// </typeparam>
    public class XmlAppConfigConfigurationLoader<TApplicationConfiguration> : BaseConfigurationLoader<TApplicationConfiguration>
        where TApplicationConfiguration : ConfigurationSection, IApplicationConfiguration
    {
        /// <summary>
        /// Gets the settings
        /// </summary>
        /// <returns>
        /// The <see>
        ///     <cref>TApplicationConfiguration</cref>
        /// </see>
        ///     .
        /// </returns>
        public override TApplicationConfiguration GetSettings()
        {
            var section = ConfigurationManager.GetSection("applicationSettings");

            if (section == null)
            {
                throw new ConfigurationErrorsException("Missing application settings section in config file.");
            }

            var settings = (TApplicationConfiguration)section;

            return settings;
        }
    }
}
