// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="InternetServer.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Configuration Element Representing the connection to a server
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElement
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Configuration Element Representing the connection to a server
    /// </summary>
    public class InternetServer : ConfigurationElement
    {
        #region Public Properties

        /// <summary>
        /// Hostname of the server
        /// </summary>
        [ConfigurationProperty("hostName", IsRequired = true)]
        public string HostName
        {
            get
            {
                return (String)this["hostName"];
            }

            set
            {
                this["hostName"] = value;
            }
        }

        /// <summary>
        /// Password for the connection, if needed
        /// </summary>
        [ConfigurationProperty("password", IsRequired = false)]
        public string Password
        {
            get
            {
                return (String)this["password"];
            }

            set
            {
                this["password"] = value;
            }
        }

        /// <summary>
        /// port of the server, if not using the protocol default
        /// </summary>
        [ConfigurationProperty("port", IsRequired = false)]
        public int Port
        {
            get
            {
                return (Int32)this["port"];
            }

            set
            {
                this["port"] = value;
            }
        }

        /// <summary>
        /// The path of the request
        /// </summary>
        [ConfigurationProperty("requestPath", IsRequired = true)]
        public string RequestPath
        {
            get
            {
                return (String)this["requestPath"];
            }

            set
            {
                this["requestPath"] = value;
            }
        }

        /// <summary>
        /// Username for the connection, if needed
        /// </summary>
        [ConfigurationProperty("userName", IsRequired = false)]
        public string UserName
        {
            get
            {
                return (String)this["userName"];
            }

            set
            {
                this["userName"] = value;
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