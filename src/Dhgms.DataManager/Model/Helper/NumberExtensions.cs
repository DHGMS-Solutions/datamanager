// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="NumberExtensions.cs">
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
//   Helper methods for numbers
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Helper methods for numbers
    /// </summary>
    public static class NumberExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Wether a number is between or equal to the minimum or maximum number
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="min">
        /// </param>
        /// <param name="max">
        /// </param>
        /// <returns>
        /// The between.
        /// </returns>
        public static bool Between(this int input, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException("min", "Min is greater than Max.");
            }

            return input >= min && input <= max;
        }

        /// <summary>
        /// gets the ordinal suffix for a number
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns>
        /// The get ordinal suffix.
        /// </returns>
        public static string GetOrdinalSuffix(this int input)
        {
            int ordinal = input % 10;

            switch (ordinal)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            }
        }

        /// <summary>
        /// Checks if a number is in a list of numbers
        /// </summary>
        /// <param name="input">
        /// number to check for
        /// </param>
        /// <param name="collection">
        /// list of numbers to check
        /// </param>
        /// <returns>
        /// true if found, otherwise false
        /// </returns>
        public static bool In(this int input, IEnumerable<int> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection");
            }

            return collection.Any(item => input == item);
        }

        /// <summary>
        /// Wether the number is between the min and max, but not equal to one of them
        /// </summary>
        /// <param name="input">
        /// Number to check
        /// </param>
        /// <param name="min">
        /// Minimum Number
        /// </param>
        /// <param name="max">
        /// Maximum Number
        /// </param>
        /// <returns>
        /// The inside.
        /// </returns>
        public static bool Inside(this int input, int min, int max)
        {
            if (min > max - 1)
            {
                throw new ArgumentOutOfRangeException("min", "Min Greater than Max.");
            }

            return input > min && input < max;
        }

        #endregion
    }
}