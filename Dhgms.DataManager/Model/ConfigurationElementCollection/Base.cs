// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Base.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Base class for a Collection of Elements in a Config file
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElementCollection
{
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Base class for a Collection of Elements in a Config file
    /// </summary>
    /// <typeparam name="TConfigElement">
    /// </typeparam>
    [SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public abstract class BaseCollection<TConfigElement> : ConfigurationElementCollection
        where TConfigElement : ConfigurationElement, new()
    {
        #region Public Indexers

        /// <summary>
        /// Returns a element from the collection
        /// </summary>
        /// <param name="index">0 based position in list</param>
        /// <returns></returns>
        public TConfigElement this[int index]
        {
            get
            {
                return (TConfigElement)this.BaseGet(index);
            }

            set
            {
                if (this.BaseGet(index) != null)
                {
                    this.BaseRemoveAt(index);
                }

                BaseAdd(index, value);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Adds an element to a collection
        /// </summary>
        /// <param name="element">
        /// element to add
        /// </param>
        public void Add(ConfigurationElement element)
        {
            this.BaseAdd(element);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates a new Element
        /// </summary>
        /// <returns>
        /// ConfigElement
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new TConfigElement();
        }

        /// <summary>
        /// Gets the element key
        /// </summary>
        /// <param name="element">
        /// element
        /// </param>
        /// <returns>
        /// key
        /// </returns>
        protected abstract override object GetElementKey(ConfigurationElement element);

        #endregion
    }
}