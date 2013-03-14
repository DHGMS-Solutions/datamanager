// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Cryptography.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Helper for cryptography
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System.Security.Cryptography;

    /// <summary>
    /// Helper for cryptography
    /// </summary>
    public static class CryptographyExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Generates a random key
        /// </summary>
        /// <param name="numberOfBytes">
        /// length of the key in bytes
        /// </param>
        /// <returns>
        /// The create key.
        /// </returns>
        public static string CreateKey(int numberOfBytes)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[numberOfBytes];

            rng.GetBytes(buff);
            return buff.BytesToHexString();
        }

        #endregion
    }
}