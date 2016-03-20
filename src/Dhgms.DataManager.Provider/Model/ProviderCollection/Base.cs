// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Base.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Base class for Provider Collections
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ProviderCollection
{
    using System.Configuration.Provider;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Base class for Provider Collections
    /// </summary>
    /// <typeparam name="TProviderClass">
    /// The Provider Class
    /// </typeparam>
    [SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public class BaseCollection<TProviderClass> : ProviderCollection
        where TProviderClass : ProviderBase
    {
        #region Public Indexers

        /// <summary>
        /// Gets a provider by its name.
        /// </summary>
        public new TProviderClass this[string name]
        {
            get
            {
                return (TProviderClass)base[name];
            }
        }

        #endregion
    }
}