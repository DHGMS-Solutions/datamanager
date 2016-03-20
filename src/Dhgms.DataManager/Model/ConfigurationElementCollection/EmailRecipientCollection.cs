// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="EmailRecipientCollection.cs">
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
//   Represents a collection of Email Recipients in a Config File
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElementCollection
{
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;

    using Dhgms.DataManager.Model.ConfigurationElement;

    /// <summary>
    /// Represents a collection of Email Recipients in a Config File
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public class EmailRecipientCollection : BaseConfigurationElementCollection<EmailRecipient>
    {
        #region Methods

        /// <summary>
        /// Gets the element key
        /// </summary>
        /// <param name="element">
        /// element
        /// </param>
        /// <returns>
        /// key
        /// </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return element;
        }

        #endregion
    }
}