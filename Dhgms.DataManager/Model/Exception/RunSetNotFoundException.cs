// -----------------------------------------------------------------------
// <copyright file="RunSetNotFoundException.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// Exception for when a requested run set was not found
    /// </summary>
    [Serializable]
    public class RunSetNotFoundException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSetNotFoundException"/> class. 
        /// </summary>
        public RunSetNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSetNotFoundException"/> class. 
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public RunSetNotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSetNotFoundException"/> class. 
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public RunSetNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected RunSetNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}
