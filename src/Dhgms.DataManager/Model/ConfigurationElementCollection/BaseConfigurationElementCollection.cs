// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Base.cs">
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
//   Base class for a Collection of Elements in a Config file
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElementCollection
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Base class for a Collection of Elements in a Config file
    /// </summary>
    /// <typeparam name="TConfigElement">
    /// </typeparam>
    [SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
    public abstract class BaseConfigurationElementCollection<TConfigElement> : ConfigurationElementCollection
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
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

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
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

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