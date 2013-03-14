// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="PossibleSqlInjectionException.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   A quick and dirty check has detected that there is possibly an SQL injection attempt
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A quick and dirty check has detected that there is possibly an SQL injection attempt
    /// </summary>
    [Serializable]
    public class PossibleSqlInjectionException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleSqlInjectionException"/> class. 
        /// Constructor
        /// </summary>
        public PossibleSqlInjectionException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleSqlInjectionException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public PossibleSqlInjectionException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleSqlInjectionException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public PossibleSqlInjectionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleSqlInjectionException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="detectedCharacter">
        /// The detected Character.
        /// </param>
        public PossibleSqlInjectionException(char detectedCharacter)
            : base("A possible SQL injection was detected. Detected char: " + detectedCharacter)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleSqlInjectionException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected PossibleSqlInjectionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}