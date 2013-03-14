// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="NoRecipientsException.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Thrown when you try to send an email without passing in any recipients
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception.Email
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Thrown when you try to send an email without passing in any recipients
    /// </summary>
    [Serializable]
    public class NoRecipientsException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NoRecipientsException"/> class. 
        /// Constructor
        /// </summary>
        public NoRecipientsException()
            : base("There are no recipients for the email")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoRecipientsException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public NoRecipientsException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoRecipientsException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public NoRecipientsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoRecipientsException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected NoRecipientsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}