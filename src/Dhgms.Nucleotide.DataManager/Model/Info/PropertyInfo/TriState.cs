// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="TriState.cs">
//   Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.Nucleotide.Model.Info.PropertyInfo
{
    /// <summary>
    /// Property Information for TriState
    /// </summary>
    public class TriState : Base
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TriState"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="collection">
        /// Wether the field is a collection
        /// </param>
        /// <param name="name">
        /// Name of the field
        /// </param>
        /// <param name="description">
        /// Description for the field, used for commenting
        /// </param>
        /// <param name="optional">
        /// Whether the field is optionable \ nullable
        /// </param>
        /// <param name="isKey">
        /// Whether the property is the primary key
        /// </param>
        public TriState(CollectionType collection, string name, string description, bool optional, bool isKey)
            : base(
                collection,
                name,
                description,
                optional,
                "Dhgms.DataManager.Model.Info.TriState",
                "Dhgms.DataManager.Model.SearchFilter.TriState",
                "Byte",
                true,
                "Dhgms.DataManager.Model.Info.TriState.Unknown",
                false,
                isKey,
                true)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Whether to generate an auto property, or a property that uses a field
        /// </summary>
        public override bool GenerateAutoProperty
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the code used for outputting a value as part of a string array
        /// </summary>
        public override string ToStringArrayCode
        {
            get
            {
                return "ToString(System.Globalization.CultureInfo.InvariantCulture)";
            }
        }
        #endregion
    }
}