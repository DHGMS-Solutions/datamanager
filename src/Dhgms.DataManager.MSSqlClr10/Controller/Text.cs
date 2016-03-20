using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.DataManager.MSSqlClr10.Controller
{
    using Dhgms.DataManager.Model.Helper;

    public static class Text
    {
        /// <summary>
        /// Gets the count of a specifed character
        /// </summary>
        /// <param name="input"></param>
        /// <param name="charToCount"></param>
        /// <returns></returns>
        [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        public static System.Data.SqlTypes.SqlInt64 GetCharCount(System.Data.SqlTypes.SqlString input, System.Data.SqlTypes.SqlString charToCount)
        {
            if (input.IsNull)
            {
                return System.Data.SqlTypes.SqlInt64.Null;
            }

            //check charToCount var
            if (charToCount == null
                || charToCount.Value == null)
            {
                return System.Data.SqlTypes.SqlInt64.Null;
            }

            if (input.Value.Length == 0)
            {
                return 0;
            }

            if (charToCount.Value.Length != 1)
            {
                throw new ArgumentException(
                    "charToCount should be 1 character long",
                    "input"
                    );
            }

            String adjustedInput = input.Value;
            String[] split = adjustedInput.Split(charToCount.Value[0]);

            return split.Length - 1;

        }

        /// <summary>
        /// States whether a string contains a numeric token
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        public static System.Data.SqlTypes.SqlBoolean GetContainsNumericToken(System.Data.SqlTypes.SqlString input)
        {
            if (input.IsNull || string.IsNullOrWhiteSpace(input.Value))
            {
                return System.Data.SqlTypes.SqlBoolean.Null;
            }

            string[] split = input.Value.Split();

            foreach (string item in split)
            {
                if (item.Length > 0
                    && item.IsInteger())
                {
                    return System.Data.SqlTypes.SqlBoolean.True;
                }
            }

            return System.Data.SqlTypes.SqlBoolean.False;
        }

        /*
        [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        public static Dhgms.DataManager.Model.Info.Metaphone.DoubleMetaphone GetDoubleMetaphone(
            System.Data.SqlTypes.SqlString input
            )
        {
            Dhgms.DataManager.Model.DoubleMetaphone metaphone = new Dhgms.DataManager.Model.DoubleMetaphone(
                input.Value
                );

            return metaphone;
        }
         */

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //[Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        //public static System.Data.SqlTypes.SqlString GetDoubleMetaphonePrimary(
        //    System.Data.SqlTypes.SqlString input
        //    )
        //{
        //    return GetDoubleMetaphone(input).Primary;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //[Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        //public static System.Data.SqlTypes.SqlString GetDoubleMetaphoneSecondary(
        //    System.Data.SqlTypes.SqlString input
        //    )
        //{
        //    return GetDoubleMetaphone(input).Secondary;
        //}

        /// <summary>
        /// Gets the specified token of a whitespace split string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="zeroBasedIndex"></param>
        /// <returns></returns>
        [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        public static System.Data.SqlTypes.SqlString GetToken(
            System.Data.SqlTypes.SqlString input,
            System.Data.SqlTypes.SqlInt64 zeroBasedIndex
            )
        {
            //check input var
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (
                input.IsNull
                || input.Value == null
                || input.Value.Length == 0
                )
            {
                throw new ArgumentException("input");
            }

            if (zeroBasedIndex.IsNull == true)
            {
                throw new ArgumentNullException("zeroBasedIndex");
            }

            if (zeroBasedIndex.Value < 0)
            {
                throw new ArgumentOutOfRangeException("zeroBasedIndex");
            }

            string[] split = input.Value.Split();

            if (split.Length <= zeroBasedIndex)
            {
                throw new IndexOutOfRangeException("zeroBasedIndex");
            }

            return split[zeroBasedIndex.Value];
        }

        /// <summary>
        /// Gets the count of a specifed character
        /// </summary>
        /// <param name="input"></param>
        /// <param name="charToCount"></param>
        /// <returns></returns>
        [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        public static System.Data.SqlTypes.SqlInt64 GetTokenCount(
            System.Data.SqlTypes.SqlString input
            )
        {
            //check input var
            if (input == null
                || input.Value == null)
            {
                return System.Data.SqlTypes.SqlInt64.Null;
            }

            if (input.Value.Length == 0)
            {
                return 0;
            }

            String adjustedInput = input.Value;
            String[] split = adjustedInput.Split(' ');

            return split.Length;
        }

        /// <summary>
        /// Checks to see if there is a space missing between the house number and first word of street name
        /// i.e. 1MAIN STREET
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        public static System.Data.SqlTypes.SqlString GetHouseNumberAndStreetMissingSpace(System.Data.SqlTypes.SqlString input)
        {
            if (input.IsNull || string.IsNullOrWhiteSpace(input.Value))
            {
                return null;
            }

            return input.Value.GetHouseNumberAndStreetMissingSpace();
        }

        /// <summary>
        /// Removes multiple spaces from a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true)]
        public static System.Data.SqlTypes.SqlString RemoveMultipleSpaces(System.Data.SqlTypes.SqlString input)
        {
            if (input.IsNull || string.IsNullOrWhiteSpace(input.Value))
            {
                return null;
            }

            string[] temp = input.Value.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            return System.String.Join(" ", temp);
        }

        /// <summary>
        /// http://sqlblog.com/blogs/adam_machanic/archive/2009/04/26/faster-more-scalable-sqlclr-string-splitting.aspx
        /// </summary>
        /// <param name="instr"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        //[Microsoft.SqlServer.Server.SqlFunction(
        //    FillRowMethodName = "FillIt",
        //    TableDefinition = "output nvarchar(4000)"
        //    )]
        //public static System.Collections.IEnumerator GetTokens(
        //    System.Data.SqlTypes.SqlChars instr
        //    )
        //{
        //    System.Data.SqlTypes.SqlString delimiter = " ";
        //    return (
        //        (instr.IsNull || delimiter.IsNull)
        //        ? new Dhgms.DataManager.Model.Helper.TextSplitter("", ',')
        //        : new Dhgms.DataManager.Model.Helper.TextSplitter(instr.ToSqlString().Value, ' ')
        //        );
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="obj"></param>
        ///// <param name="output"></param>
        //private static void FillIt(
        //    object obj,
        //    out System.Data.SqlTypes.SqlString output
        //    )
        //{
        //    output = (
        //        new System.Data.SqlTypes.SqlString(
        //            (string)obj)
        //            );
        //}
    }
}
