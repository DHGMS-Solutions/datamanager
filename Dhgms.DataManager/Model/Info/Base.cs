﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Base.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Base class for all information classes
//   Required in order for them to work with the DataManager
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Base class for all information classes
    /// Required in order for them to work with the DataManager
    /// </summary>
    /// <typeparam name="TInheritingType">
    /// The type that is inheriting from this base class
    /// </typeparam>
    [DataContract]
    public abstract class Base<TInheritingType> : IComparable<TInheritingType>, IEquatable<TInheritingType>, IComparable, IDisposable
    {
        #region Public Properties

        /// <summary>
        /// Gets a header record for use for something like a CSV file
        /// </summary>
        /// <returns>a collection of strings representing the header record</returns>
        public abstract IList<string> HeaderRecord { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Check if 2 object are equal
        /// </summary>
        /// <param name="first">first object to compare</param>
        /// <param name="other">the other object to compare</param>
        /// <returns>true if equal, otherwise false</returns>
        public static bool operator ==(Base<TInheritingType> first, Base<TInheritingType> other)
        {
            if ((object)first == null)
            {
                return (object)other == null;
            }

            return (object)other != null && first.Equals(other);
        }

        /// <summary>
        /// Checks if an object is greater than another
        /// </summary>
        /// <param name="first">first object to compare</param>
        /// <param name="other">the other object to compare</param>
        /// <returns></returns>
        public static bool operator >(Base<TInheritingType> first, Base<TInheritingType> other)
        {
            if ((object)first == null)
            {
                return (object)other == null;
            }

            if ((object)other == null)
            {
                return true;
            }

            return first.CompareTo(other) > 0;
        }

        /// <summary>
        /// Checks if 2 objects are NOT equal
        /// </summary>
        /// <param name="first">first object to compare</param>
        /// <param name="other">the other object to compare</param>
        /// <returns></returns>
        public static bool operator !=(Base<TInheritingType> first, Base<TInheritingType> other)
        {
            if ((object)first == null)
            {
                return (object)other != null;
            }

            if ((object)other == null)
            {
                return true;
            }

            return !first.Equals(other);
        }

        /// <summary>
        /// Checks if an object is less than another
        /// </summary>
        /// <param name="first">first object to compare</param>
        /// <param name="other">the other object to compare</param>
        /// <returns></returns>
        public static bool operator <(Base<TInheritingType> first, Base<TInheritingType> other)
        {
            if ((object)first == null)
            {
                return (object)other != null;
            }

            if ((object)other == null)
            {
                return false;
            }

            return first.CompareTo(other) < 0;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <return>
        /// 0 if equal, otherwise non zero
        /// </return>
        /// <returns>
        /// The compare to.
        /// </returns>
        public abstract int CompareTo(TInheritingType other);

        /// <summary>
        /// Compares the current instance with another object
        /// </summary>
        /// <param name="other">
        /// other object to compare
        /// </param>
        /// <returns>
        /// 0 if equal, otherwise non-0, depending on the rules of the CompareTo logic in the inheriting class
        /// </returns>
        public int CompareTo(object other)
        {
            if (!(other is TInheritingType))
            {
                throw new ArgumentException("Type mismatch");
            }

            return this.CompareTo((TInheritingType)other);
        }

        /// <summary>
        /// Checks a table to make sure it meets the required schema
        /// </summary>
        public abstract void DoTableValidation();

        /// <summary>
        /// Adds an XML Element to an XML Writer
        /// </summary>
        public abstract void DoXmlElement(System.Xml.XmlWriter writer, string parentElementName);

        /// <summary>
        /// Wrapper for adding a child XML element
        /// </summary>
        /// <param name="writer">
        /// The XML writer to add the element to
        /// </param>
        /// <param name="name">
        /// The name of the element.
        /// </param>
        /// <param name="value">
        /// The value of the element.
        /// </param>
        protected void DoChildXmlElement(
            System.Xml.XmlWriter writer,
            string name,
            string value)
        {
            writer.WriteStartElement(name);
            writer.WriteValue(value);
            writer.WriteEndElement();
        }

        /// <summary>
        /// Wrapper for adding a CData element
        /// </summary>
        /// <param name="writer">
        /// The XML writer to add the element to
        /// </param>
        /// <param name="name">
        /// The name of the element.
        /// </param>
        /// <param name="value">
        /// The value of the element.
        /// </param>
        protected void DoChildXmlCDataElement(
            System.Xml.XmlWriter writer,
            string name,
            string value)
        {
            writer.WriteStartElement(name);
            writer.WriteCData(value);
            writer.WriteEndElement();
        }

        /// <summary>
        /// Checks if an object matches this one
        /// </summary>
        /// <param name="obj">
        /// An object
        /// </param>
        /// <returns>
        /// The equals.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is TInheritingType))
            {
                return false;
            }

            return this.CompareTo((TInheritingType)obj) == 0;
        }

        /// <summary>
        /// Checks if the values of two objects are the same
        /// </summary>
        /// <param name="other">
        /// The other object to compare
        /// </param>
        /// <returns>
        /// True if they match, otherwise false
        /// </returns>
        public abstract bool Equals(TInheritingType other);

        /// <summary>
        /// Gets the hash code for the object
        /// </summary>
        /// <returns>
        /// hash code
        /// </returns>
        public abstract override int GetHashCode();

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The dispose method
        /// </summary>
        /// <param name="disposing">
        /// Whether we are being disposed
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.OnDisposing();
            }
        }

        /// <summary>
        /// The on disposing event
        /// </summary>
        protected abstract void OnDisposing();

        /// <summary>
        /// Gets a collection of string data for use for something like a CSV file
        /// </summary>
        /// <returns>
        /// a collection of strings representing the data record
        /// </returns>
        public abstract IList<string> ToStringArray();

        #endregion

        #region Methods

        /// <summary>
        /// Compares lists to make sure they are the same
        /// </summary>
        /// <typeparam name="TListDataType">
        /// Data Type for the list collections
        /// </typeparam>
        /// <param name="first">
        /// First List
        /// </param>
        /// <param name="other">
        /// Second List
        /// </param>
        /// <returns>
        /// 0 for match, otherwise non zero
        /// </returns>
        protected static int CompareCollection<TListDataType>(
            ICollection<TListDataType> first, ICollection<TListDataType> other) where TListDataType : IComparable
        {
            if (first == null)
            {
                return other == null ? 0 : 1;
            }

            if (other == null)
            {
                return -1;
            }

            if (first == other)
            {
                return 0;
            }

            if (first.Count > other.Count)
            {
                return -1;
            }

            if (first.Count < other.Count)
            {
                return 1;
            }

            var otherEnum = other.GetEnumerator();
            return (from firstItem in first let otherItem = otherEnum.MoveNext() select firstItem.CompareTo(otherItem)).FirstOrDefault(callResult => callResult != 0);
        }

        #endregion
    }
}