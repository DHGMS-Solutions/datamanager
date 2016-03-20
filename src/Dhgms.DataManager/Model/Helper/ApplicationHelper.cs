// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="ApplicationHelper.cs">
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
//   Helper task for generic application tasks
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    /// <summary>
    /// Helper task for generic application tasks
    /// </summary>
    public static class ApplicationHelper//<TApplicationSettings, TCommandLineParser, TApplicationSettingsLoaderConfiguration>
        //where TApplicationSettings : Info.CommandLineSettings.Base, new()
        //where TCommandLineParser : Base<TApplicationSettings>, new()
        //where TApplicationSettingsLoaderConfiguration : Info.IApplicationSettingsLoaderConfiguration, new()
    {
        /*
        private readonly Lazy<Application<TApplicationSettings, TCommandLineParser, TApplicationSettingsLoaderConfiguration>> lazyLoadingInstance = new Lazy<Application<TApplicationSettings, TCommandLineParser, TApplicationSettingsLoaderConfiguration>>(() => new Application<TApplicationSettings, TCommandLineParser, TApplicationSettingsLoaderConfiguration>());

        private readonly Lazy<TApplicationSettings> lazyLoadingSettings;

        private Application()
        {
            this.lazyLoadingSettings = new Lazy<TApplicationSettings>(this.GetSettings);
        }

        /// <summary>
        /// 
        /// </summary>
        public Application<TApplicationSettings, TCommandLineParser, TApplicationSettingsLoaderConfiguration> Instance
        {
            get
            {
                return lazyLoadingInstance.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TApplicationSettings Settings
        {
            get
            {
                return this.lazyLoadingSettings.Value;
            }
        }
         * */

        #region Public Methods and Operators

        /*
        private void LoadCommandLine(TApplicationSettings currentSettings)
        {
            //var commandLineParser = new TCommandLineParser();
        }

        private TApplicationSettings GetSettings()
        {
            var loaderSettings = new TApplicationSettingsLoaderConfiguration();
            if (!loaderSettings.UseApplicationConfigFile && !loaderSettings.UseCommandLineArguments && !loaderSettings.UseCurrentUserRegistry && !loaderSettings.UseLocalMachineRegistry && !loaderSettings.UseGroupPolicy)
            {
                throw new NoApplicationSettingSourcesException();
            }

            var settings = loaderSettings.UseApplicationConfigFile ? LoadConfigFile() : new TApplicationSettings();

            if (loaderSettings.UseCommandLineArguments) LoadCommandLine(settings);
            if (loaderSettings.UseCurrentUserRegistry) LoadCurrentUserRegistry(settings);
            if (loaderSettings.UseLocalMachineRegistry) LoadLocalMachineRegistry(settings);
            if (loaderSettings.UseGroupPolicy) LoadGroupPolicy(settings);

            return settings;
        }

        private void LoadCurrentUserRegistry(TApplicationSettings settings)
        {
        }

        private void LoadGroupPolicy(TApplicationSettings settings)
        {
        }

        private void LoadLocalMachineRegistry(TApplicationSettings settings)
        {
        }*/

        #endregion
    }
}