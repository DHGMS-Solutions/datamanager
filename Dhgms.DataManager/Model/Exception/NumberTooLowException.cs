// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="NumberTooLowException.cs">
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
//   Exceptions for when a number is too low
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowClrCharException
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrCharException" /> class.
        /// </summary>
        public NumberTooLowClrCharException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrCharException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowClrCharException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrCharException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowClrCharException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrCharException"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowClrCharException(
            string parameterName,
            char minimumValid,
            char actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrCharException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowClrCharException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public char Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public char MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowClrDateTimeException
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDateTimeException" /> class.
        /// </summary>
        public NumberTooLowClrDateTimeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDateTimeException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowClrDateTimeException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDateTimeException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowClrDateTimeException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDateTimeException"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowClrDateTimeException(
            string parameterName,
            System.DateTime minimumValid,
            System.DateTime actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDateTimeException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowClrDateTimeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public System.DateTime Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public System.DateTime MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowClrDecimalException
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDecimalException" /> class.
        /// </summary>
        public NumberTooLowClrDecimalException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDecimalException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowClrDecimalException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDecimalException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowClrDecimalException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDecimalException"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowClrDecimalException(
            string parameterName,
            decimal minimumValid,
            decimal actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDecimalException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowClrDecimalException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public decimal Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public decimal MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowClrDoubleException
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDoubleException" /> class.
        /// </summary>
        public NumberTooLowClrDoubleException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDoubleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowClrDoubleException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDoubleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowClrDoubleException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDoubleException"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowClrDoubleException(
            string parameterName,
            double minimumValid,
            double actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrDoubleException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowClrDoubleException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public double Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public double MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowClrSingleException
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrSingleException" /> class.
        /// </summary>
        public NumberTooLowClrSingleException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrSingleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowClrSingleException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrSingleException" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowClrSingleException(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrSingleException"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowClrSingleException(
            string parameterName,
            float minimumValid,
            float actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowClrSingleException" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowClrSingleException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public float Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public float MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowInteger16Exception
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger16Exception" /> class.
        /// </summary>
        public NumberTooLowInteger16Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger16Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowInteger16Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger16Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowInteger16Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger16Exception"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowInteger16Exception(
            string parameterName,
            short minimumValid,
            short actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger16Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowInteger16Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public short Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public short MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowInteger32Exception
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger32Exception" /> class.
        /// </summary>
        public NumberTooLowInteger32Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger32Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowInteger32Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger32Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowInteger32Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger32Exception"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowInteger32Exception(
            string parameterName,
            int minimumValid,
            int actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger32Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowInteger32Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public int Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public int MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowInteger64Exception
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger64Exception" /> class.
        /// </summary>
        public NumberTooLowInteger64Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger64Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowInteger64Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger64Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowInteger64Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger64Exception"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowInteger64Exception(
            string parameterName,
            long minimumValid,
            long actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowInteger64Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowInteger64Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public long Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public long MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

    /// <summary>
    /// The number passed in was higher than the allowed maximum
    /// </summary>
    [System.Serializable]
    public class NumberTooLowUnsignedInteger8Exception
        : System.ArgumentOutOfRangeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowUnsignedInteger8Exception" /> class.
        /// </summary>
        public NumberTooLowUnsignedInteger8Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowUnsignedInteger8Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        public NumberTooLowUnsignedInteger8Exception(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowUnsignedInteger8Exception" /> class.
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="innerException">Inner Exception</param>
        public NumberTooLowUnsignedInteger8Exception(
            string message,
            System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowUnsignedInteger8Exception"/> class. 
        /// </summary>
        /// <param name="parameterName">The name of the parameter causing the exception.</param>
        /// <param name="minimumValid">The minimum valid value.</param>
        /// <param name="actual">The actual value received.</param>
        public NumberTooLowUnsignedInteger8Exception(
            string parameterName,
            byte minimumValid,
            byte actual)
            : base(parameterName, "The number specified is too low. Minimum: " + minimumValid + ", Actual: " + actual)
        {
            this.Actual = actual;
            this.MinimumValid = minimumValid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTooLowUnsignedInteger8Exception" /> class.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        protected NumberTooLowUnsignedInteger8Exception(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets the actual value that cause the exception.
        /// </summary>
        public byte Actual { get; private set; }

        /// <summary>
        /// Gets the minimum valid value.
        /// </summary>
        public byte MinimumValid { get; private set; }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the invalid argument value and additional exception information.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info"/> object is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/></PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Actual", this.Actual);
            info.AddValue("MinimumValid", this.MinimumValid);
        }
    }

}