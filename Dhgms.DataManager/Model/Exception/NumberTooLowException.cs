//////////////////////////////////////////////////////////////////////////
// Licensed under GNU General Public License version 2 (GPLv2)
//
// DHGMS Data Manager by DHGMS Solutions
// http://datamanager.codeplex.com
//////////////////////////////////////////////////////////////////////////

namespace Dhgms.DataManager.Model.Exception
{
	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowClrCharException
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrCharException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowClrCharException(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowClrCharException(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowClrCharException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrCharException(
			string parameterName,
			System.Char expected,
			System.Char actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowClrDateTimeException
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrDateTimeException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowClrDateTimeException(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowClrDateTimeException(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowClrDateTimeException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrDateTimeException(
			string parameterName,
			System.DateTime expected,
			System.DateTime actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowClrDecimalException
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrDecimalException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowClrDecimalException(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowClrDecimalException(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowClrDecimalException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrDecimalException(
			string parameterName,
			System.Decimal expected,
			System.Decimal actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowClrDoubleException
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrDoubleException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowClrDoubleException(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowClrDoubleException(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowClrDoubleException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrDoubleException(
			string parameterName,
			System.Double expected,
			System.Double actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowClrSingleException
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrSingleException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowClrSingleException(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowClrSingleException(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowClrSingleException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowClrSingleException(
			string parameterName,
			System.Single expected,
			System.Single actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowInteger16Exception
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowInteger16Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowInteger16Exception(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowInteger16Exception(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowInteger16Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowInteger16Exception(
			string parameterName,
			System.Int16 expected,
			System.Int16 actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowInteger32Exception
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowInteger32Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowInteger32Exception(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowInteger32Exception(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowInteger32Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowInteger32Exception(
			string parameterName,
			System.Int32 expected,
			System.Int32 actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowInteger64Exception
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowInteger64Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowInteger64Exception(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowInteger64Exception(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowInteger64Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowInteger64Exception(
			string parameterName,
			System.Int64 expected,
			System.Int64 actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

	/// <summary>
	/// The number passed in was higher than the allowed maximum
	/// </summary>
	[System.Serializable]
	public class NumberTooLowUnsignedInteger8Exception
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowUnsignedInteger8Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooLowUnsignedInteger8Exception(
			System.String message
			)
			: base(message)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		/// <param name="innerException">Inner Exception</param>
		public NumberTooLowUnsignedInteger8Exception(
			System.String message,
			System.Exception innerException
			) : base(message, innerException)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">Serialization Info</param>
		/// <param name="context">Context</param>
		protected NumberTooLowUnsignedInteger8Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooLowUnsignedInteger8Exception(
			string parameterName,
			System.Byte expected,
			System.Byte actual
			)
			: base(parameterName + ": The number specified is too low. Minimum: " + expected + ", Actual: " + actual)
		{

		}
	}

}
