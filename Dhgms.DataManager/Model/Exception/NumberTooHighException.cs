// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="NumberTooHighException.cs">
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
//   Exceptions for when a number is too high
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception
{
    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighClrCharException
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrCharException" /> class.
        /// </summary>
        public NumberTooHighClrCharException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrCharException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighClrCharException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrCharException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighClrCharException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrCharException" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighClrCharException(
            string parameterName,
            char maximumValid,
            char actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrCharException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighClrCharException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighClrDateTimeException
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDateTimeException" /> class.
        /// </summary>
        public NumberTooHighClrDateTimeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDateTimeException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighClrDateTimeException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDateTimeException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighClrDateTimeException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDateTimeException" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighClrDateTimeException(
            string parameterName,
            System.DateTime maximumValid,
            System.DateTime actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDateTimeException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighClrDateTimeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighClrDecimalException
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDecimalException" /> class.
        /// </summary>
        public NumberTooHighClrDecimalException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDecimalException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighClrDecimalException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDecimalException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighClrDecimalException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDecimalException" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighClrDecimalException(
            string parameterName,
            decimal maximumValid,
            decimal actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDecimalException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighClrDecimalException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighClrDoubleException
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDoubleException" /> class.
        /// </summary>
        public NumberTooHighClrDoubleException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDoubleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighClrDoubleException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDoubleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighClrDoubleException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDoubleException" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighClrDoubleException(
            string parameterName,
            double maximumValid,
            double actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrDoubleException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighClrDoubleException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighClrSingleException
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrSingleException" /> class.
        /// </summary>
        public NumberTooHighClrSingleException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrSingleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighClrSingleException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrSingleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighClrSingleException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrSingleException" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighClrSingleException(
            string parameterName,
            float maximumValid,
            float actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighClrSingleException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighClrSingleException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighInteger16Exception
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger16Exception" /> class.
        /// </summary>
        public NumberTooHighInteger16Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger16Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighInteger16Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger16Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighInteger16Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger16Exception" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighInteger16Exception(
            string parameterName,
            short maximumValid,
            short actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger16Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighInteger16Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighInteger32Exception
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger32Exception" /> class.
        /// </summary>
        public NumberTooHighInteger32Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger32Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighInteger32Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger32Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighInteger32Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger32Exception" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighInteger32Exception(
            string parameterName,
            int maximumValid,
            int actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger32Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighInteger32Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighInteger64Exception
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger64Exception" /> class.
        /// </summary>
        public NumberTooHighInteger64Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger64Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighInteger64Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger64Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighInteger64Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger64Exception" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighInteger64Exception(
            string parameterName,
            long maximumValid,
            long actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighInteger64Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighInteger64Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooHighUnsignedInteger8Exception
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighUnsignedInteger8Exception" /> class.
        /// </summary>
        public NumberTooHighUnsignedInteger8Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighUnsignedInteger8Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooHighUnsignedInteger8Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighUnsignedInteger8Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooHighUnsignedInteger8Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighUnsignedInteger8Exception" /> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="maximumValid">The maximum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooHighUnsignedInteger8Exception(
            string parameterName,
            byte maximumValid,
            byte actual)
            : base(parameterName + ": The number specified is too high. Maximum: " + maximumValid + ", Actual: " + actual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooHighUnsignedInteger8Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooHighUnsignedInteger8Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

}
