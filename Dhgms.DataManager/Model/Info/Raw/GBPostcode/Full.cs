// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Full.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Represents a UK PostCode
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Info.Raw.GBPostcode
{
    using System;
    using System.Globalization;

    using Dhgms.DataManager.Model.Helper;

    /// <summary>
    /// Represents a UK PostCode
    /// </summary>
    public class Full
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Full"/> class. 
        /// Null Constructor
        /// </summary>
        public Full()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Full"/> class. 
        /// Copy constructor
        /// </summary>
        /// <param name="full">
        /// </param>
        public Full(Full full)
        {
            if (full == null)
            {
                throw new ArgumentNullException("full");
            }

            this.Outward = full.Outward;
            this.Inward = full.Inward;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Full"/> class. 
        /// The full.
        /// </summary>
        /// <param name="outward">
        /// </param>
        /// <param name="inward">
        /// </param>
        public Full(Outward outward, Inward inward)
        {
            this.Outward = outward;
            this.Inward = inward;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Full"/> class. 
        /// The full.
        /// </summary>
        /// <param name="postcode">
        /// </param>
        public Full(string postcode)
        {
            if (postcode == null)
            {
                throw new ArgumentNullException("postcode");
            }

            if (!postcode.Length.Between(5, 8))
            {
                throw new ArgumentException("Incorrect Length", "postcode");
            }

            string[] parts = postcode.Split();
            if (parts.Length != 2)
            {
                throw new ArgumentException("Incorrect Format", "postcode");
            }

            this.Outward = new Outward(parts[0]);
            this.Inward = new Inward(parts[1]);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The inward section of the UK Postcode
        /// </summary>
        public Inward Inward { get; set; }

        /// <summary>
        /// Whether the Postcode is valid
        /// </summary>
        public bool IsValid
        {
            get
            {
                return this.Outward.IsValid && this.Inward.IsValid // Check if it is a BFPO postcode
                       &&
                       (this.Outward.ToString().Equals("BFPO", StringComparison.OrdinalIgnoreCase)
                        && this.Inward.ToString().IsNumeric()
                        && int.Parse(this.Inward.ToString(), CultureInfo.InvariantCulture).Between(0, 9999));
            }
        }

        /// <summary>
        /// The outward section of the UK PostCode
        /// </summary>
        public Outward Outward { get; set; }

        /// <summary>
        /// returns the sector code
        /// e.g. CT20 1
        /// </summary>
        public string SectorCode
        {
            get
            {
                return this.Outward + " " + this.Inward.Sector;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Returns the formatted postcode
        /// </summary>
        /// <returns>
        /// The to string.
        /// </returns>
        public override string ToString()
        {
            return this.Outward + " " + this.Inward;
        }

        #endregion
    }
}