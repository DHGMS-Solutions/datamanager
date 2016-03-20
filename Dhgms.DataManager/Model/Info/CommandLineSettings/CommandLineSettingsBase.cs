// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandLineSettingsBase.cs" company="DHGMS Solutions">
//   Copyright 2004-2014 DHGMS Solutions
//   
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   
//       http://www.apache.org/licenses/LICENSE-2.0
//   
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <summary>
//   Represents the base command line settings
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info.CommandLineSettings
{
        using System;
        using System.ComponentModel.DataAnnotations;
        using System.Diagnostics;
        using System.Diagnostics.CodeAnalysis;
        using System.Runtime.Serialization;
        using System.Xml;
        using System.Xml.Linq;

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Represents the base command line settings
        /// </summary>
        [DataContract]
        public class CommandLineSettingsBase
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.InfoBase<CommandLineSettingsBase>
// ReSharper restore RedundantNameQualifier
        {
        #region fields
        #endregion

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLineSettingsBase"/> class.
        /// </summary>
        public CommandLineSettingsBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLineSettingsBase"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public CommandLineSettingsBase(CommandLineSettingsBase other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            this.WantsHelp = other.WantsHelp;
        }

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLineSettingsBase"/> class.
        /// </summary>
        /// <param name="wantsHelp">a value indicating whether the user wants the help info displayed</param>
        public CommandLineSettingsBase(
            bool wantsHelp)
            {
            this.WantsHelp = wantsHelp;
        }

        #region properties
        /// <summary>
        /// Gets or sets a value indicating whether the user wants the help info displayed
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true, Order = 1)]
        [Required]
        public bool WantsHelp
        {
            get;
            set;
        }

        #endregion

        #region IComparable methods

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">
        /// The instance to compare to
        /// </param>
        /// <returns>
        /// 0 if equal, otherwise non zero
        /// </returns>
        public override int CompareTo(CommandLineSettingsBase other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            // WantsHelp
            var checkResult = this.WantsHelp.CompareTo(other.WantsHelp);

            if (checkResult != 0)
            {
                return (checkResult > 0) ? 1 : -1;
            }

            return 0;
        }

        #endregion
#region IEquatable methods
            /// <summary>
            /// Checks if the current instance matches another of the same type
            /// </summary>
            /// <param name="other">object to compare</param>
            /// <returns>true if equal, otherwise false</returns>
            public override bool Equals(CommandLineSettingsBase other)
            {
                return this.CompareTo(other) == 0;
            }

#endregion

    #region our methods

        /// <summary>
        /// Gets the hash code for the object
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return
                this.WantsHelp.GetHashCode()
                ^ this.WantsHelp.GetHashCode();
        }

        /// <summary>
        /// Checks this instance against another to see where there are differences
        /// </summary>
        /// <param name="other">other instance to compare</param>
        /// <returns>summary of where there are differences</returns>
// ReSharper disable RedundantNameQualifier
        public Dhgms.DataManager.Model.Difference.CommandLineSettings.CommandLineSettingsBaseDifference GetDifferences(CommandLineSettingsBase other)
// ReSharper restore RedundantNameQualifier
        {
            if (other == null)
            {
                throw new System.ArgumentNullException("other");
            }

            // WantsHelp
            var checkResult = this.WantsHelp.CompareTo(other.WantsHelp);

            var wantsHelpDifferent = checkResult != 0;

// ReSharper disable RedundantNameQualifier
            return new Dhgms.DataManager.Model.Difference.CommandLineSettings.CommandLineSettingsBaseDifference(
// ReSharper restore RedundantNameQualifier
                wantsHelpDifferent);
        }

        /// <summary>
        /// Gets the CDSL that defines the OData Vocabularies for this class
        /// </summary>
        public static XmlReader GetOdataVocabularies()
        {
            // WantsHelp

        var schema = new XElement(
            "Schema",
            new XAttribute("Namespace", "Dhgms.DataManager.CommandLineSettings"),
            new XAttribute("xmlns", "http://schemas.microsoft.com/ado/2009/11/edm"),
            // using directive
            new XElement(
                "Using",
                new XAttribute("Namespace", "Org.OData.Validation.V1"),
                new XAttribute("Alias", "Validation"),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "Dhgms.DataManager.CommandLineSettings.CommandLineSettingsBase/WantsHelp"))));

        Debug.Assert(schema.Document != null, "schema.Document != null");
        return schema.Document.CreateReader();
        }
        #endregion
            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
            }
    }
}
