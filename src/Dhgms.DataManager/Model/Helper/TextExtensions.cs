// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="TextExtensions.cs">
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
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Text Extension Methods
    /// </summary>
    public static class TextExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Compares an array of strings against another
        /// </summary>
        /// <param name="instance">
        /// first collection of strings
        /// </param>
        /// <param name="other">
        /// collection of strings to compare against
        /// </param>
        /// <param name="stringComparison">
        /// Type of string comparison being done
        /// </param>
        /// <returns>
        /// 0 if matches, otherswise non-0
        /// </returns>
        public static int CompareCollection(this string[] instance, string[] other, StringComparison stringComparison)
        {
            if (instance == null)
            {
                return other != null ? 1 : 0;
            }

            if (other == null)
            {
                return -1;
            }

            if (instance == other)
            {
                return 0;
            }

            if (instance.LongLength != other.LongLength)
            {
                return (instance.LongLength > 1) ? 2 : -2;
            }

            long endPosition = instance.LongLength;
            for (int i = 0; i < endPosition; i++)
            {
                int checkResult = string.Compare(instance[i], other[i], stringComparison);
                if (checkResult != 0)
                {
                    return (checkResult > 0) ? i + 3 : 0 - (i + 3);
                }
            }

            return 0;
        }

        /// <summary>
        /// Indicates if a character is contained in a string
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="check">
        /// </param>
        /// <returns>
        /// The contains.
        /// </returns>
        public static bool Contains(this string input, char check)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            return input.IndexOf(check) > 0;
        }

        /// <summary>
        /// Indicates if any of a series of characters is contained in a string
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="checks">
        /// </param>
        /// <returns>
        /// The contains any.
        /// </returns>
        public static bool ContainsAny(this string input, char[] checks)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (checks == null)
            {
                throw new ArgumentNullException("checks");
            }

            return checks.Any(check => Contains(input, check));
        }

        /// <summary>
        /// The contains symbol.
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns>
        /// The contains symbol.
        /// </returns>
        public static bool ContainsSymbol(this string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            return input.Any(char.IsSymbol);
        }

        /// <summary>
        /// Checks to find the number of times a character occurs in a string
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="check">
        /// </param>
        /// <returns>
        /// The count.
        /// </returns>
        public static int Count(this string input, char check)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            int counter = 0;
            int lastFind = input.IndexOf(check);
            while (lastFind > 0)
            {
                counter++;
                lastFind = input.IndexOf(check, lastFind);
            }

            return counter;
        }

        /// <summary>
        /// The count equals.
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="check">
        /// </param>
        /// <param name="numberExpected">
        /// </param>
        /// <returns>
        /// The count equals.
        /// </returns>
        public static bool CountEquals(this string input, char check, int numberExpected)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (numberExpected < 1)
            {
                throw new ArgumentOutOfRangeException("numberExpected");
            }

            int counter = 0;
            int lastFind = input.IndexOf(check);
            while (lastFind > 0 // once we get 1 too many we can drop out
                   && counter <= numberExpected)
            {
                counter++;
                lastFind = input.IndexOf(check, lastFind + 1);
            }

            return counter == numberExpected;
        }

        /// <summary>
        /// Checks to see if there is a space missing between the house number and first word of street name
        /// i.e. 1MAIN STREET
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns>
        /// The get house number and street missing space.
        /// </returns>
        public static string GetHouseNumberAndStreetMissingSpace(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("input");
            }

            // want to only deal with first token
            string[] split = input.Split();

            if (split.Length > 1)
            {
                throw new ArgumentException("expecting a single word, got a string", "input");
            }

            if (input.ToCharArray().Length < 1)
            {
                throw new ArgumentException("input too short", "input");
            }

            char[] chars = input.ToCharArray();

            return GetHouseNumberAndStreetMissingSpace(chars, input);
        }

        /// <summary>
        /// The get number from start.
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns>
        /// The get number from start.
        /// </returns>
        public static string GetNumberFromStart(this string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            string result = string.Empty;

            char[] charArray = input.ToCharArray();

            // LINQ as suggested by resharper
            // loops through while we have a numeric or a space
            // but only adds a char to the result if is a number
            // this is so 1 0 1 will return 101
            result =
                charArray.TakeWhile(item => char.IsNumber(item) || item == ' ').Where(item => item != ' ').Aggregate(
                    result, (current, item) => current + item);

            return result.Trim();
        }

        /// <summary>
        /// The in.
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="checks">
        /// </param>
        /// <returns>
        /// The in.
        /// </returns>
        public static bool In(this char input, char[] checks)
        {
            if (checks == null)
            {
                throw new ArgumentNullException("checks");
            }

            return checks.Any(check => input == check);
        }

        /// <summary>
        /// The in.
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="checks">
        /// </param>
        /// <param name="stringComparison">
        /// </param>
        /// <returns>
        /// The in.
        /// </returns>
        public static bool In(this string input, string[] checks, StringComparison stringComparison)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (checks == null)
            {
                throw new ArgumentNullException("checks");
            }

            return checks.Any(check => input.Equals(check, stringComparison));
        }

        /// <summary>
        /// The is integer.
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns>
        /// The is integer.
        /// </returns>
        public static bool IsInteger(this string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length < 1)
            {
                return false;
            }

            char[] charArray = input.ToCharArray();
            int endPoint = input.Length;

            for (int i = 0; i < endPoint; i++)
            {
                if (!char.IsDigit(charArray[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// checks if a token matches the ordinal suffix for a number
        /// </summary>
        /// <param name="number">
        /// </param>
        /// <param name="suffix">
        /// </param>
        /// <returns>
        /// The is numeral suffix.
        /// </returns>
        public static bool IsNumeralSuffix(this int number, string suffix)
        {
            if (suffix == null)
            {
                throw new ArgumentNullException("suffix");
            }

            string expectedSuffix = number.GetOrdinalSuffix();

            return expectedSuffix.Equals(suffix, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Returns if a string represents a number
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns>
        /// The is numeric.
        /// </returns>
        public static bool IsNumeric(this string input)
        {
            long resultInteger;
            float resultSingle;
            double resultDouble;
            return long.TryParse(input, out resultInteger) || float.TryParse(input, out resultSingle)
                   || double.TryParse(input, out resultDouble);
        }

        /// <summary>
        /// checks if a character is a roman vowel
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <returns>
        /// true for vowel, otherwise false
        /// </returns>
        public static bool IsVowel(this char input)
        {
            return input.In(new[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' });
        }

        /// <summary>
        /// Gets the first x characters of a string
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="count">
        /// </param>
        /// <returns>
        /// The left.
        /// </returns>
        public static string Left(this string input, int count)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (count < 1)
            {
                throw new ArgumentOutOfRangeException("count");
            }

            if (count > input.Length)
            {
                count = input.Length;
            }

            return input.Substring(0, count);
        }

        /// <summary>
        /// The remove chars from start.
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="toRemove">
        /// </param>
        /// <param name="ignoreWhiteSpace">
        /// whether to ignore whitespace
        /// </param>
        /// <returns>
        /// The remove chars from start.
        /// </returns>
        public static string RemoveCharsFromStart(string input, string toRemove, bool ignoreWhiteSpace)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (string.IsNullOrWhiteSpace(toRemove))
            {
                throw new ArgumentNullException("toRemove");
            }

            int toRemovePosition = 0;
            int toRemoveLength = toRemove.Length;
            char[] numberArray = toRemove.ToCharArray();

            int inputPosition = 0;
            int inputLength = input.Length;
            char[] inputArray = input.ToCharArray();

            while (toRemovePosition < toRemoveLength && inputPosition < inputLength)
            {
                if (inputArray[inputPosition] == numberArray[toRemovePosition])
                {
                    // matched a char
                    // move up the number string
                    toRemovePosition++;
                }
                else if (!ignoreWhiteSpace && !char.IsWhiteSpace(inputArray[toRemovePosition]))
                {
                    throw new ArgumentException("doesn't start with the expected sequence of chars", "input");
                }

                // we would want to move along the string
                inputPosition++;
            }

            if (toRemovePosition < toRemoveLength)
            {
                throw new ArgumentException("failed to find all the characters that are supposed to be removed.");
            }

            return input.Substring(toRemovePosition);
        }

        /// <summary>
        /// Gets the last x characters of a string
        /// </summary>
        /// <param name="input">
        /// </param>
        /// <param name="count">
        /// </param>
        /// <returns>
        /// The right.
        /// </returns>
        public static string Right(this string input, int count)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("input");
            }

            if (count < 1)
            {
                throw new ArgumentOutOfRangeException("count");
            }

            if (count > input.Length)
            {
                count = input.Length;
            }

            return input.Substring(input.Length - count, count);
        }

        private static string GetHouseNumberAndStreetMissingSpace(char[] chars, string input)
        {
            if (!char.IsDigit(chars[0]))
            {
                return input;
            }

            int firstLetter = 1;
            for (int i = 2; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    continue;
                }

                firstLetter = i;
                break;
            }

            // check there is more than 1 letter
            // so it's not 1A MAIN STREET
            // allow 1/100 MAIN STREET
            if (firstLetter + 1 >= chars.Length || !char.IsLetter(chars[firstLetter + 1]) || chars[firstLetter] == '/')
            {
                return input;
            }

            var number = int.Parse(input.Left(firstLetter), CultureInfo.InvariantCulture);
            var suffix = input.Right(input.Length - firstLetter);
            // allow tokens like 1st
            if (IsNumeralSuffix(number, suffix))
            {
                return input;
            }

            // fix 2-B
            // should be 2B
            if (chars[firstLetter] == '-' && chars.Length == firstLetter + 2)
            {
                return input.Left(firstLetter) + input.Right(input.Length - (firstLetter + 1));
            }

            return input.Left(firstLetter) + " " + input.Right(input.Length - firstLetter);
        }
        #endregion
    }
}