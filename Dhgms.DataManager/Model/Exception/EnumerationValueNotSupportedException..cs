// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumerationValueNotSupportedException..cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Exception for when the enumeration value isn't supported, usually in a switch statement
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception for when the enumeration value isn't supported, usually in a switch statement
    /// </summary>
    [Serializable]
    public class EnumerationValueNotSupportedException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationValueNotSupportedException"/> class. 
        /// Constructor
        /// </summary>
        public EnumerationValueNotSupportedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationValueNotSupportedException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public EnumerationValueNotSupportedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationValueNotSupportedException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public EnumerationValueNotSupportedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationValueNotSupportedException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected EnumerationValueNotSupportedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}