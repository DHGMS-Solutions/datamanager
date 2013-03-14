// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmptyResultSetException.cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   The argument passed as a directory is in a bad format
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception.Database
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The argument passed as a directory is in a bad format
    /// </summary>
    [Serializable]
    public class EmptyResultSetException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyResultSetException"/> class. 
        /// Constructor
        /// </summary>
        public EmptyResultSetException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyResultSetException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public EmptyResultSetException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyResultSetException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public EmptyResultSetException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyResultSetException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected EmptyResultSetException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}