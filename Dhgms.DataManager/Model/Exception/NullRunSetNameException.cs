namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The runset hasn't been specified in the command line arguments
    /// </summary>
    [Serializable]
    public class NullRunSetNameException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// </summary>
        public NullRunSetNameException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public NullRunSetNameException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public NullRunSetNameException(string message, Exception innerException)
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
        protected NullRunSetNameException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}
