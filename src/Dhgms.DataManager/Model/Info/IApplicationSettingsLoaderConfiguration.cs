// -----------------------------------------------------------------------
// <copyright file="IApplicationSettingsLoaderConfiguration.cs" company="">
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
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IApplicationSettingsLoaderConfiguration
    {
        /// <summary>
        /// Gets a value indicating whether to use application config file.
        /// </summary>
        bool UseApplicationConfigFile { get; }

        /// <summary>
        /// Gets a value indicating whether to use command line arguments.
        /// </summary>
        bool UseCommandLineArguments { get; }

        /// <summary>
        /// Gets a value indicating whether to use current user registry.
        /// </summary>
        bool UseCurrentUserRegistry { get; }

        /// <summary>
        /// Gets a value indicating whether to use local machine registry.
        /// </summary>
        bool UseLocalMachineRegistry { get; }

        /// <summary>
        /// Gets a value indicating whether to use group policy.
        /// </summary>
        bool UseGroupPolicy { get; }
    }
}
