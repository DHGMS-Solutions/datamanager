// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Difference.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Class for listing differences between 2 objects of the same information class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Class for listing differences between 2 objects of the same information class
    /// </summary>
    /// <typeparam name="TInheritingType">
    /// </typeparam>
    public abstract class Difference<TInheritingType> : Base<TInheritingType>
    {
        #region Public Properties

        /// <summary>
        /// Returns the number of properties in an information class that differ
        /// </summary>
        public abstract int Count { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Gets a list of column names where the values are different
        /// </summary>
        /// <returns>
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public abstract IList<string> GetColumnNames();

        #endregion
    }
}