// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileHelper.cs" company="DHGMS Solutions">
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
//   Helper methods for dealing with File related operations
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.IO;

    /// <summary>
    /// Helper methods for dealing with File related operations
    /// </summary>
    public static class FileHelper
    {
        #region Public Methods and Operators

        /// <summary>
        /// ensures a path is formatted with the \ at the end
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <returns>
        /// The get formatted path.
        /// </returns>
        public static string GetFormattedPath(string path)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("path");
            }

            path = Path.GetDirectoryName(path);

            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("path is not a valid directory name", "path");
            }

            if (!path.EndsWith("\\", StringComparison.OrdinalIgnoreCase))
            {
                path += "\\";
            }

            return path;
        }

        /// <summary>
        /// The get fully qualified path.
        /// </summary>
        /// <param name="location">
        /// </param>
        /// <param name="fileName">
        /// </param>
        /// <returns>
        /// The get fully qualified path.
        /// </returns>
        public static string GetFullyQualifiedPath(string location, string fileName)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentNullException("location");
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("fileName");
            }

            return location + (!location.EndsWith("\\", StringComparison.OrdinalIgnoreCase) ? "\\" : string.Empty)
                   + fileName;
        }

        #endregion
    }
}