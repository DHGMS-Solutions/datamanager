// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="InternetServer.cs">
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
        /// Gets or sets the hostname of the server
        /// </summary>
        [ConfigurationProperty("hostName", IsRequired = true)]
        public string HostName
        {
            get
            {
                return (string)this["hostName"];
            }

            set
            {
                this["hostName"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the password for the connection, if needed
        /// </summary>
        [ConfigurationProperty("password", IsRequired = false)]
        public string Password
        {
            get
            {
                return (string)this["password"];
            }

            set
            {
                this["password"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the port of the server, if not using the protocol default
        /// </summary>
        [ConfigurationProperty("port", IsRequired = false)]
        public int Port
        {
            get
            {
                return (int)this["port"];
            }

            set
            {
                this["port"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the path of the request
        /// </summary>
        [ConfigurationProperty("requestPath", IsRequired = true)]
        public string RequestPath
        {
            get
            {
                return (string)this["requestPath"];
            }

            set
            {
                this["requestPath"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the username for the connection, if needed
        /// </summary>
        [ConfigurationProperty("userName", IsRequired = false)]
        public string UserName
        {
            get
            {
                return (string)this["userName"];
            }

            set
            {
                this["userName"] = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Gets or sets a value indicating whether the config is read only
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