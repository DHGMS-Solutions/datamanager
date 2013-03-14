// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Number.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
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
    public static class Number
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
                throw new ArithmeticException("Min greater than Max");
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
            if (min > max)
            {
                throw new ArithmeticException("Min greater than Max");
            }

            return input > min && input < max;
        }

        #endregion
    }
}