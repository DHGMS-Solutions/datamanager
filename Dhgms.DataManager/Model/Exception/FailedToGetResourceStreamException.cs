// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="FailedToGetResourceStreamException.cs">
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