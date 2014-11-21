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

namespace Dhgms.DataManager.Model.Difference.CommandLineSettings
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
        public class CommandLineSettingsBaseDifference
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.DifferenceBase<CommandLineSettingsBaseDifference>
// ReSharper restore RedundantNameQualifier
        {
        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLineSettingsBaseDifference"/> class.
        /// </summary>
        public CommandLineSettingsBaseDifference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLineSettingsBaseDifference"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public CommandLineSettingsBaseDifference(CommandLineSettingsBaseDifference other)
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
        /// Initializes a new instance of the <see cref="CommandLineSettingsBaseDifference"/> class.
        /// </summary>
        /// <param name="wantsHelp">a value indicating whether the user wants the help info displayed</param>
        public CommandLineSettingsBaseDifference(
            bool wantsHelp)
            {
            this.WantsHelp = wantsHelp;
        }

        #region properties
        /// <summary>
        /// a value indicating whether the user wants the help info displayed
        /// </summary>
        public bool WantsHelp
        {
            get;
            set;
        }

            /// <summary>
            /// Gets a header record for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the header record</returns>
            public override System.Collections.Generic.IList<string> HeaderRecord
            {
                get
                {
                    var result = new System.Collections.Generic.List<string>
                    {
                        "WantsHelp"
                    };

                    return result;
                }
            }

            /// <summary>
            /// Gets the number of properties that are different
            /// </summary>
            /// <return>
            /// the number of properties that are different
            /// </return>
            public override int Count
            {
                get
                {
                    return
                    ((WantsHelp) ? 1 : 0)
                    ;
                }
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
        public override int CompareTo(CommandLineSettingsBaseDifference other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            int             checkResult = WantsHelp.CompareTo(other.WantsHelp);
            if(checkResult != 0)
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
            public override bool Equals(CommandLineSettingsBaseDifference other)
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
        /// Checks a table to ensure it meets the required schema
        /// </summary>
        public override void DoTableValidation()
        {
        }

            /// <summary>
            /// Gets a collection of string data for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the data record</returns>
            public override System.Collections.Generic.IList<string> ToStringArray()
            {
                var result = new System.Collections.Generic.List<string>
                {
                    this.WantsHelp ? "1" : "0"
                };

                return result;
            }

            /// <summary>
            /// Adds an XML Element to an XML Writer
            /// </summary>
            /// <param name="writer">
            /// The XML writer to add the element to.
            /// </param>
            /// <param name="parentElementName">
            /// The name for the parenet element being produced.
            /// </param>
            public override void DoXmlElement(
                    System.Xml.XmlWriter writer,
                    string parentElementName)
            {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (string.IsNullOrEmpty(parentElementName) || parentElementName.Trim().Length == 0)
            {
            throw new ArgumentNullException("parentElementName");
            }

                writer.WriteStartElement(parentElementName);

                // WantsHelp
                this.DoChildXmlCDataElement(writer, "WantsHelp", this.WantsHelp ? "1" : "0");

                writer.WriteEndElement();
            }


        /// <summary>
        /// Gets the names of the columns that are different
        /// </summary>
        /// <returns>
        /// list of names of the columns that are different
        /// </returns>
        public override System.Collections.Generic.IList<string> GetColumnNames()
        {
            var columns = new System.Collections.Generic.List<string>();
            if (this.WantsHelp)
            {
                columns.Add("WantsHelp");
            }

            return columns;
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
