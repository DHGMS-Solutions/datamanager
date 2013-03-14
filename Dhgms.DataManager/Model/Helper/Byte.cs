// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Byte.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Extension Methods for Bytes
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// Extension Methods for Bytes
    /// </summary>
    public static class ByteExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Converts a byte string to hexadecimal
        /// </summary>
        /// <param name="value">
        /// Byte String to convert
        /// </param>
        /// <returns>
        /// The bytes to hex string.
        /// </returns>
        public static string BytesToHexString(this byte[] value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var hexString = new StringBuilder(64);

            foreach (byte t in value)
            {
                hexString.Append(string.Format(CultureInfo.InvariantCulture, "{0:X2}", t));
            }

            return hexString.ToString();
        }

        #endregion
    }
}