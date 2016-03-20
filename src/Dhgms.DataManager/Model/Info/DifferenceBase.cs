// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="DifferenceBase.cs">
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
    public abstract class DifferenceBase<TInheritingType> : InfoBase<TInheritingType>
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