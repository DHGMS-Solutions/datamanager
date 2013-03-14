// --------------------------------------------------------------------------------------------------------------------
// <copyright file="File.cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
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
    public static class File
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
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            path = Path.GetDirectoryName(path);

            if (path == null)
            {
                throw new ArgumentNullException("path");
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
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }

            if (fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }

            return location + (!location.EndsWith("\\", StringComparison.OrdinalIgnoreCase) ? "\\" : string.Empty)
                   + fileName;
        }

        #endregion
    }
}