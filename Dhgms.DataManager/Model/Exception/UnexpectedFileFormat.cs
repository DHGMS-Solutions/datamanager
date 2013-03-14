// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnexpectedFileFormat.cs" company="DHGMS Solutions">
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
    public class UnexpectedFileFormatException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedFileFormatException"/> class. 
        /// Constructor
        /// </summary>
        public UnexpectedFileFormatException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedFileFormatException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public UnexpectedFileFormatException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedFileFormatException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public UnexpectedFileFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedFileFormatException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected UnexpectedFileFormatException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}