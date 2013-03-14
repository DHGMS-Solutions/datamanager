// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="ViewFilter.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
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
    public abstract class ViewFilter<TInheritingType> : Base<TInheritingType>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewFilter{TInheritingType}"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="pageNumber">
        /// Number of the page to show
        /// </param>
        /// <param name="pageSize">
        /// Size of the pages
        /// </param>
        protected ViewFilter(int pageNumber, int pageSize)
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