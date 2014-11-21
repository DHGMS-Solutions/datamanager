// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="StringTooLongException.cs">
//   Copyright 2004-2014 DHGMS Solutions.
//      
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//      
//   http://www.apache.org/licenses/LICENSE-2.0
//      
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
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