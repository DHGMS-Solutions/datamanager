// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Reflection.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Methods that aid in reflection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Dhgms.DataManager.Model.Exception;

    /// <summary>
    /// Methods that aid in reflection
    /// </summary>
    public static class ReflectionExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get classes in namespace.
        /// </summary>
        /// <param name="fullyQualifiedNamespace">
        /// </param>
        /// <returns>
        /// </returns>
        public static IList<Type> GetClassesInNamespace(string fullyQualifiedNamespace)
        {
            return GetClassesInNamespace(fullyQualifiedNamespace, Assembly.GetCallingAssembly());
        }

        /// <summary>
        /// The get classes in namespace.
        /// </summary>
        /// <param name="fullyQualifiedNamespace">
        /// </param>
        /// <param name="assembly">
        /// </param>
        /// <returns>
        /// </returns>
        public static IList<Type> GetClassesInNamespace(string fullyQualifiedNamespace, Assembly assembly)
        {
            if (fullyQualifiedNamespace == null)
            {
                throw new ArgumentNullException("fullyQualifiedNamespace");
            }

            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            return
                assembly.GetTypes().Where(
                    type =>
                    type.Namespace != null
                    && type.Namespace.Equals(fullyQualifiedNamespace, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Loads a string from an embedded resource file
        /// </summary>
        /// <param name="assembly">
        /// The assembly containing the resource
        /// </param>
        /// <param name="resourceNamespace">
        /// Namespace where the resource file resides. Usually the application name
        /// </param>
        /// <param name="resourceFileName">
        /// The filename of the embedded resource
        /// </param>
        /// <returns>
        /// string from embedded resource file
        /// </returns>
        /// <remarks>
        /// This code is based on an answer on stack overflow
        /// http://stackoverflow.com/questions/576571/where-do-you-put-sql-statements-in-your-c-sharp-projects
        /// answer by: http://stackoverflow.com/users/13302/marc-s
        /// </remarks>
        public static string LoadStringFromResource(
            Assembly assembly, string resourceNamespace, string resourceFileName)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            if (resourceNamespace == null || resourceNamespace.Trim().Length == 0)
            {
                throw new ArgumentNullException("resourceNamespace");
            }

            if (resourceFileName == null || resourceFileName.Trim().Length == 0)
            {
                throw new ArgumentNullException("resourceFileName");
            }

            string result;
            string resourceName = resourceNamespace + "." + resourceFileName;
            using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
            {
                if (resourceStream == null)
                {
                    throw new FailedToGetResourceStreamException(resourceName);
                }

                result = new StreamReader(resourceStream).ReadToEnd();

                result = result.Trim();
                if (result.Length < 1)
                {
                    throw new StringTooShortException();
                }
            }

            return result;
        }

        #endregion
    }
}