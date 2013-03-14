// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Date.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Helper methods for the Date datatype
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Helper methods for the Date datatype
    /// </summary>
    public static class DateExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Gets all dates including and between 2 dates
        /// </summary>
        /// <param name="startDate">
        /// The start date
        /// </param>
        /// <param name="endDate">
        /// The end date
        /// </param>
        /// <returns>
        /// </returns>
        public static IList<DateTime> GetDaysUpTo(this DateTime startDate, DateTime endDate)
        {
            // wipe the time components
            DateTime currentDate = startDate.Date;
            endDate = endDate.Date;

            if (currentDate > endDate)
            {
                throw new ArgumentOutOfRangeException("startDate", "startDate is after endDate");
            }

            var result = new List<DateTime>();

            while (currentDate <= endDate)
            {
                result.Add(currentDate);

                currentDate = currentDate.AddDays(1);
            }

            return result;
        }

        #endregion
    }
}