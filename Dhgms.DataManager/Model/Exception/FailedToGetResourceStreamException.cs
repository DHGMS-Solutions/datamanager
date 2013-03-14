// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="FailedToGetResourceStreamException.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   We failed to get the resource stream. Used when loading a resource file.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// We failed to get the resource stream. Used when loading a resource file.
    /// </summary>
    [Serializable]
    public class FailedToGetResourceStreamException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToGetResourceStreamException"/> class. 
        /// Constructor
        /// </summary>
        public FailedToGetResourceStreamException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToGetResourceStreamException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public FailedToGetResourceStreamException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToGetResourceStreamException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public FailedToGetResourceStreamException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedToGetResourceStreamException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected FailedToGetResourceStreamException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}