//////////////////////////////////////////////////////////////////////////
// Licensed under GNU General Public License version 2 (GPLv2)
//
// DHGMS Data Manager by DHGMS Solutions
// http://datamanager.codeplex.com
//////////////////////////////////////////////////////////////////////////

namespace Dhgms.DataManager.Model.Helper
{
    /// <summary>
    /// Helpers for use with KbCSV
    /// </summary>
    public static class Csv
    {
        /// <summary>
        /// Adds a yes \ no column to a record
        /// </summary>
        /// <param name="newItem">the record to add the column to</param>
        /// <param name="value">boolean flag</param>
        public static void AddYesNoColumn(
            Kent.Boogaart.KBCsv.RecordBase newItem,
            bool value)
        {
            if (newItem == null)
            {
                throw new System.ArgumentNullException("newItem");
            }

            newItem.Values.Add(value ? "y" : "n");
        }

        /// <summary>
        /// Adds a tristate column to a record
        /// </summary>
        /// <param name="newItem">The record to add the column to</param>
        /// <param name="value">The tri-state value</param>
        public static void AddTriStateColumn(
            Kent.Boogaart.KBCsv.RecordBase newItem,
            bool? value)
        {
            if (newItem == null)
            {
                throw new System.ArgumentNullException("newItem");
            }

            string equiv;

            if (!value.HasValue)
            {
                equiv = "U";
            }
            else
            {
                equiv = value.Value ? "Y" : "N";
            }

            newItem.Values.Add(equiv);
        }
    }
}
