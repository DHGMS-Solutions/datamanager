// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="BooleanExtensions.cs">
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
//   Helpers for the Boolean Data Type
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Linq;

    /// <summary>
    /// Helpers for the Boolean Data Type
    /// </summary>
    public static class BooleanExtensions
    {
        private static readonly string[] NoValues = { "N", "No", "False" };
        private static readonly string[] YesValues = { "Y", "Yes", "True" };

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
        public static bool ParseYesNo(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (YesValues.Any(x => x.Equals(value, StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }

            if (NoValues.Any(x => x.Equals(value, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            throw new ArgumentOutOfRangeException("value");
        }

        #endregion
    }
}