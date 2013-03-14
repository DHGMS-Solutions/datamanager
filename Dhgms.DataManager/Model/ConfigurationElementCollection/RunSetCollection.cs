// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RunSetCollection.cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Represents a collection of runsets in the app config
//   based upon http://blog.newslacker.net/2008/02/net-20-custom-configuration-sections.html
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElementCollection
{
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;

    using Dhgms.DataManager.Model.ConfigurationElement;

    /// <summary>
    /// Represents a collection of runsets in the app config
    /// based upon http://blog.newslacker.net/2008/02/net-20-custom-configuration-sections.html
    /// </summary>
    /// <typeparam name="TRunSetElementClass">
    /// </typeparam>
    [SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public class RunSetCollection<TRunSetElementClass> : BaseCollection<TRunSetElementClass>
        where TRunSetElementClass : RunSet<TRunSetElementClass>, new()
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
            return ((TRunSetElementClass)element).Name;
        }

        #endregion
    }
}