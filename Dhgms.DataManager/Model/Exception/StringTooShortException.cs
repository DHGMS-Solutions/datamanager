// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="StringTooShortException.cs">
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
    public class StringTooShortException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooShortException"/> class. 
        /// Constructor
        /// </summary>
        public StringTooShortException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooShortException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public StringTooShortException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooShortException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public StringTooShortException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooShortException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="expected">
        /// The expected.
        /// </param>
        /// <param name="actual">
        /// The actual.
        /// </param>
        public StringTooShortException(int expected, int actual)
            : base("The string specified is too short. Minimum Length: " + expected + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTooShortException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected StringTooShortException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}