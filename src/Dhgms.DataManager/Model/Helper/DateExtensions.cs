// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="DateExtensions.cs">
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
//   Helper methods for the Date data type
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Helper methods for the Date data type
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
            if (startDate > endDate)
            {
                throw new ArgumentOutOfRangeException("startDate", "startDate is after endDate");
            }

            // wipe the time components
            DateTime currentDate = startDate.Date;
            endDate = endDate.Date;

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