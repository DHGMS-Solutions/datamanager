// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OnceTrueLatch.cs" company="DHGMS Solutions">
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
//   The group policy settings.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model
{
    /// <summary>
    /// A single set latch, used for where you need to flag something like an update flag where updates
    /// can be caused by multiple sources.
    /// This is designed to reduce the maintenance overhead of using a boolean flag and manually applying the logic.
    /// </summary>
    public sealed class OnceTrueLatch
    {
        /// <summary>
        /// A flag indicating whether the latch has been set to true.
        /// </summary>
        private bool internalValue;

        /// <summary>
        /// Gets or Sets the value indicating whether the flag has been set, or whether it should be set if hasn't already been.
        /// </summary>
        // ReSharper disable ConvertToAutoProperty
        public bool Value
        // ReSharper restore ConvertToAutoProperty
        {
            get
            {
                return this.internalValue;
            }
            set
            {
                // this.internalValue |= value;
                if (value && !this.internalValue)
                {
                    this.internalValue = true;
                }
            }
        }
    }
}