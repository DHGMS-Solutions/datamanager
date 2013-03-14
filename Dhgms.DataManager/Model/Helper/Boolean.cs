// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Boolean.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Helpers for the Boolean Data Type
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;

    /// <summary>
    /// Helpers for the Boolean Data Type
    /// </summary>
    public static class BooleanExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Parses a Yes\No field into a boolean
        /// </summary>
        /// <param name="value">
        /// the value to parse
        /// </param>
        /// <returns>
        /// true \ false
        /// </returns>
        public static bool ParseYesNo(
            // this System.Boolean input,
            string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (value.In(new[] { "Y", "Yes", "True" }, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (value.In(new[] { "N", "No", "False" }, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            throw new ArgumentOutOfRangeException("value");
        }

        #endregion
    }
}