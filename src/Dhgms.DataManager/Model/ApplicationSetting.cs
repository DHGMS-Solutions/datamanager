// -----------------------------------------------------------------------
// <copyright file="ApplicationSetting.cs" company="">
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

namespace Dhgms.DataManager.Model
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ApplicationSetting<TApplicationSettings, TType>
        where TApplicationSettings : Info.CommandLineSettings.CommandLineSettingsBase, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="target"></param>
        /// <param name="enforcementLevel"></param>
        public ApplicationSetting(
            string name,
            string description,
            Action<TType> target,
            int enforcementLevel)
        {
            this.Name = name;
            this.Description = description;
            this.Target = target;
            this.EnforcementLevel = enforcementLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Action<TType> Target { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int EnforcementLevel { get; private set; }
    }

}
