// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="ViewFilter.cs">
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
//   Base class for the View Filter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Base class for the View Filter.
    /// </summary>
    /// <typeparam name="TInheritingType">
    /// Class that is inheriting this base class
    /// </typeparam>
    public abstract class ViewFilterBase<TInheritingType> : InfoBase<TInheritingType>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewFilterBase{TInheritingType}"/> class. 
        /// </summary>
        /// <param name="pageNumber">
        /// Number of the page to show
        /// </param>
        /// <param name="pageSize">
        /// Size of the pages
        /// </param>
        protected ViewFilterBase(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The page number to be viewed
        /// </summary>
        protected int PageNumber { get; set; }

        /// <summary>
        /// Size of the pages
        /// </summary>
        protected int PageSize { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Gets a comma separated list of column names
        /// </summary>
        /// <returns>
        /// a comma separated list of column names
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public abstract string GetSelectedColumnNames();

        #endregion
    }
}