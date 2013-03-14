// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Inward.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Represents the Inward section of a UK Postcode
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info.Raw.GBPostcode
{
    using System;
    using System.Globalization;
    using System.Linq;

    using Dhgms.DataManager.Model.Exception;
    using Dhgms.DataManager.Model.Helper;

    /// <summary>
    /// Represents the Inward section of a UK Postcode
    /// </summary>
    public class Inward
    {
        #region Constants and Fields

        /// <summary>
        /// The _sector.
        /// </summary>
        private int _sector;

        /// <summary>
        /// The _unit.
        /// </summary>
        private string _unit;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Inward"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="inward">
        /// inward code to parse
        /// </param>
        public Inward(string inward)
        {
            if (inward == null)
            {
                throw new ArgumentNullException("inward");
            }

            // check the inward begins with a number
            if (!char.IsDigit(inward[0]))
            {
                throw new PostcodeBadFormatException("Inward should begin with a number");
            }

            if (inward.IsNumeric())
            {
                // all numeric
                // technically valid as a BFPO postcode can use it
                this.Sector = int.Parse(inward, CultureInfo.InvariantCulture);
            }
            else
            {
                // normal format
                if (inward.Length > 3)
                {
                    throw new StringTooLongException(3, inward.Length);
                }

                if (inward.Length < 3)
                {
                    throw new StringTooShortException(3, inward.Length);
                }

                this.Sector = (int)char.GetNumericValue(inward[0]);
                this.Unit = inward.Right(2);
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Whether the section of the postcode is valid
        /// </summary>
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(this.Unit);
            }
        }

        /// <summary>
        /// Represents a postcode sector
        /// </summary>
        public int Sector
        {
            get
            {
                return this._sector;
            }

            set
            {
                if (!value.Between(0, 9))
                {
                    throw new ArgumentOutOfRangeException("value");
                }

                this._sector = value;
            }
        }

        /// <summary>
        /// represents a postcode unit
        /// </summary>
        public string Unit
        {
            get
            {
                return this._unit;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value.Length != 3)
                {
                }

                char[] unitChars = value.ToCharArray();

                char[] badChars = { 'C', 'I', 'K', 'M', 'O', 'V' };

                if (unitChars.Any(item => !char.IsLetter(item) || item.In(badChars)))
                {
                    throw new ArgumentNullException("value");
                }

                this._unit = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The to string.
        /// </returns>
        public override string ToString()
        {
            return this.Sector + this.Unit;
        }

        #endregion
    }
}