// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Outward.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Represents the outward section of a UK Postcode
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info.Raw.GBPostcode
{
    using System;

    using Dhgms.DataManager.Model.Exception;
    using Dhgms.DataManager.Model.Helper;

    /// <summary>
    /// Represents the outward section of a UK Postcode
    /// </summary>
    public class Outward
    {
        #region Constants and Fields

        /// <summary>
        /// The _area.
        /// </summary>
        private string _area;

        /// <summary>
        /// The _district.
        /// </summary>
        private string _district;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Outward"/> class. 
        /// The outward.
        /// </summary>
        /// <param name="value">
        /// </param>
        public Outward(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            switch (value.Length)
            {
                case 1:
                    this.Area = value;
                    break;
                case 2:
                    this.Area = value.Left(1);
                    this.District = value.Right(1);
                    break;
                case 3:
                    if (char.IsDigit(value[2]))
                    {
                        // 2nd part is a number
                        this.Area = value.Left(1);
                        this.District = value.Right(2);
                    }
                    else if (char.IsLetter(value[2]))
                    {
                        this.Area = value.Left(2);
                        this.District = value.Right(1);
                    }
                    else
                    {
                        throw new PostcodeBadFormatException();
                    }

                    break;
                case 4:
                    this.Area = value.Left(2);
                    this.District = value.Right(2);
                    break;
                default:
                    throw new ArgumentNullException("value");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Outward"/> class. 
        /// The outward.
        /// </summary>
        /// <param name="area">
        /// </param>
        /// <param name="district">
        /// </param>
        public Outward(string area, string district)
        {
            this.Area = area;
            this.District = district;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Represents the area of a postcode
        /// </summary>
        public string Area
        {
            get
            {
                return this._area;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (!value.Length.Between(1, 2))
                {
                    throw new ArgumentException("area not correct length", "value");
                }

                char letter = value[0];
                if (!char.IsLetter(letter) || letter.In(new[] { 'Q', 'V', 'X' }))
                {
                    throw new ArgumentException("first letter of area code is invalid character", "value");
                }

                if (value.Length == 2)
                {
                    letter = value[1];
                    if (!char.IsLetterOrDigit(letter) || letter.In(new[] { 'I', 'J', 'Z' }))
                    {
                        throw new ArgumentException("second letter of area code is invalid character", "value");
                    }
                }

                this._area = value;
            }
        }

        /// <summary>
        /// Represents the district of a postcode
        /// </summary>
        public string District
        {
            get
            {
                return this._district;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (!value.Length.Between(1, 2))
                {
                    throw new ArgumentException("area not correct length", "value");
                }

                char[] chars = value.ToCharArray();
                if (!char.IsDigit(chars[0]) || !char.IsLetterOrDigit(chars[0]))
                {
                    throw new ArgumentException("area not correct format", "value");
                }

                this._district = value;
            }
        }

        /// <summary>
        /// Whether the section of the postcode is valid
        /// </summary>
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(this.Area) && !string.IsNullOrEmpty(this.District);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// formats the postcode section as a string
        /// </summary>
        /// <returns>
        /// formatted outward postcode section
        /// </returns>
        public override string ToString()
        {
            return this.Area + this.District;
        }

        #endregion
    }
}