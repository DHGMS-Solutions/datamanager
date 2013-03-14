// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="StringTooLongException.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   The string passed in was longer than the allowed maximum
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The string passed in was longer than the allowed maximum
    /// </summary>
    [Serializable]
    public class StringTooLongException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooLongException"/> class. 
        /// Constructor
        /// </summary>
        public StringTooLongException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooLongException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public StringTooLongException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooLongException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public StringTooLongException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooLongException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="expected">
        /// The expected.
        /// </param>
        /// <param name="actual">
        /// The actual.
        /// </param>
        public StringTooLongException(int expected, int actual)
            : base("The string specified is too long. Maximum Length: " + expected + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooLongException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected StringTooLongException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}