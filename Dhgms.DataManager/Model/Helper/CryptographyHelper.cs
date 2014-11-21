// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="CryptographyHelper.cs">
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
//   Helper for cryptography
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Security.Cryptography;

    /// <summary>
    /// Helper for cryptography
    /// </summary>
    public static class CryptographyHelper
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
            if (numberOfBytes < 1)
            {
                throw new ArgumentOutOfRangeException("numberOfBytes");
            }

            RNGCryptoServiceProvider rng = null;

            try
            {
                rng = new RNGCryptoServiceProvider();
                var buff = new byte[numberOfBytes];

                rng.GetBytes(buff);
                return buff.BytesToHexString();
            }
            finally
            {
                if (rng != null)
                {
                    rng.Dispose();
                }
            }
        }

        #endregion
    }
}