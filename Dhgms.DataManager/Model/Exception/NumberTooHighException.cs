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
	public class NumberTooHighClrCharException
		: System.Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighClrCharException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighClrCharException(
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
		public NumberTooHighClrCharException(
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
		protected NumberTooHighClrCharException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighClrCharException(
			string parameterName,
			System.Char expected,
			System.Char actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighClrDateTimeException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighClrDateTimeException(
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
		public NumberTooHighClrDateTimeException(
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
		protected NumberTooHighClrDateTimeException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighClrDateTimeException(
			string parameterName,
			System.DateTime expected,
			System.DateTime actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighClrDecimalException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighClrDecimalException(
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
		public NumberTooHighClrDecimalException(
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
		protected NumberTooHighClrDecimalException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighClrDecimalException(
			string parameterName,
			System.Decimal expected,
			System.Decimal actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighClrDoubleException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighClrDoubleException(
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
		public NumberTooHighClrDoubleException(
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
		protected NumberTooHighClrDoubleException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighClrDoubleException(
			string parameterName,
			System.Double expected,
			System.Double actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighClrSingleException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighClrSingleException(
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
		public NumberTooHighClrSingleException(
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
		protected NumberTooHighClrSingleException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighClrSingleException(
			string parameterName,
			System.Single expected,
			System.Single actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighInteger16Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighInteger16Exception(
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
		public NumberTooHighInteger16Exception(
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
		protected NumberTooHighInteger16Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighInteger16Exception(
			string parameterName,
			System.Int16 expected,
			System.Int16 actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighInteger32Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighInteger32Exception(
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
		public NumberTooHighInteger32Exception(
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
		protected NumberTooHighInteger32Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighInteger32Exception(
			string parameterName,
			System.Int32 expected,
			System.Int32 actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighInteger64Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighInteger64Exception(
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
		public NumberTooHighInteger64Exception(
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
		protected NumberTooHighInteger64Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighInteger64Exception(
			string parameterName,
			System.Int64 expected,
			System.Int64 actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
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
		/// Constructor
		/// </summary>
		public NumberTooHighUnsignedInteger8Exception()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">Exception Message</param>
		public NumberTooHighUnsignedInteger8Exception(
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
		public NumberTooHighUnsignedInteger8Exception(
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
		protected NumberTooHighUnsignedInteger8Exception(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
			)
			: base(info, context)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public NumberTooHighUnsignedInteger8Exception(
			string parameterName,
			System.Byte expected,
			System.Byte actual
			)
			: base(parameterName + ": The number specified is too high. Maximum: " + expected + ", Actual: " + actual)
		{

		}
	}

}
