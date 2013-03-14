// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="EmailRecipientCollection.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
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
    public class EmailRecipientCollection : BaseCollection<EmailRecipient>
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