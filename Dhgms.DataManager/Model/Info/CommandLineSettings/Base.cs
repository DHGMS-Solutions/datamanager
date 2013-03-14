// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Base.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   
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
        public class Base
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.Base<Base>
// ReSharper restore RedundantNameQualifier
        {
        #region fields
        #endregion

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="Base"/> class.
        /// </summary>
        public Base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public Base(Base other)
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
        /// Initializes a new instance of the <see cref="Base"/> class.
        /// </summary>
        /// <param name="wantsHelp">a value indicating whether the user wants the help info displayed</param>
        public Base(
            bool wantsHelp)
            {
            this.WantsHelp = wantsHelp;
        }

            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
            }
        #region properties
        /// <summary>
        /// Gets or sets a value indicating whether the user wants the help info displayed
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 1)]
        [Required]

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
        public override int CompareTo(Base other)
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
            public override bool Equals(Base other)
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
                    this.WantsHelp.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLower()
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
                this.DoChildXmlCDataElement(writer, "WantsHelp", this.WantsHelp.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLower());

                writer.WriteEndElement();
            }

        /// <summary>
        /// Checks this instance against another to see where there are differences
        /// </summary>
        /// <param name="other">other instance to compare</param>
        /// <returns>summary of where there are differences</returns>
// ReSharper disable RedundantNameQualifier
        public Dhgms.DataManager.Model.Difference.CommandLineSettings.BaseDifference GetDifferences(Base other)
// ReSharper restore RedundantNameQualifier
        {
            if (other == null)
            {
                throw new System.ArgumentNullException("other");
            }

            // WantsHelp
            var checkResult = this.WantsHelp.CompareTo(other.WantsHelp);

            var wantsHelp = checkResult != 0;

// ReSharper disable RedundantNameQualifier
            return new Dhgms.DataManager.Model.Difference.CommandLineSettings.BaseDifference(
// ReSharper restore RedundantNameQualifier
                wantsHelp
                );
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
                    new XAttribute("Target", "Dhgms.DataManager.CommandLineSettings.Base/WantsHelp"))));

        Debug.Assert(schema.Document != null, "schema.Document != null");
        return schema.Document.CreateReader();
        }
        #endregion
    }
}

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
        public class BaseDifference
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.Difference<BaseDifference>
// ReSharper restore RedundantNameQualifier
        {
        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDifference"/> class.
        /// </summary>
        public BaseDifference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDifference"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public BaseDifference(BaseDifference other)
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
        /// Initializes a new instance of the <see cref="BaseDifference"/> class.
        /// </summary>
        /// <param name="wantsHelp">a value indicating whether the user wants the help info displayed</param>
        public BaseDifference(
            bool wantsHelp)
            {
            this.WantsHelp = wantsHelp;
        }

            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
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
        public override int CompareTo(BaseDifference other)
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
            public override bool Equals(BaseDifference other)
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
                    new XAttribute("Target", "Dhgms.DataManager.CommandLineSettings.Base/WantsHelp"))));

        Debug.Assert(schema.Document != null, "schema.Document != null");
        return schema.Document.CreateReader();
        }
        #endregion
    }
}

