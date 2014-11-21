// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="EmailRecipient.cs">
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
//   Represents an Email Recipient in a config file
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElement
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Represents an Email Recipient in a config file
    /// </summary>
    public class EmailRecipient : ConfigurationElement
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the email recipient.
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }

            set
            {
                this["name"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the email address of the recipient.
        /// </summary>
        [ConfigurationProperty("value", IsRequired = true)]
        public string Value
        {
            get
            {
                return (string)this["value"];
            }

            set
            {
                this["value"] = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Gets a flag indicating whether the config is read only.
        /// </summary>
        /// <returns>
        /// true or false
        /// </returns>
        public override bool IsReadOnly()
        {
            return false;
        }

        #endregion
    }
}