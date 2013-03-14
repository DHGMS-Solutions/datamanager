// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="EmailRecipient.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
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
        /// The name of the run set
        /// </summary>
        // public System.String name;
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (String)this["name"];
            }

            set
            {
                this["name"] = value;
            }
        }

        /// <summary>
        /// The name of the run set
        /// </summary>
        // public System.String name;
        [ConfigurationProperty("value", IsRequired = true)]
        public string Value
        {
            get
            {
                return (String)this["value"];
            }

            set
            {
                this["value"] = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Dictates whether the config is read only
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