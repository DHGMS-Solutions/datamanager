namespace Dhgms.DataManager.Tests.Model.Helper
{
    using System;

    using Xunit;

    /// <summary>
    /// Unit tests for CSV helpers
    /// </summary>
    public class CsvTest
    {
        /// <summary>
        /// Unit tests for the AddYesNoColumn Method
        /// </summary>
        public class AddYesNoColumnMethod
        {
            /// <summary>
            /// Test to ensure an exception is thrown when the record item is null
            /// </summary>
            [Fact]
            public void DataRecordNull()
            {
                var ex = Assert.Throws<ArgumentNullException>(
                    () => Dhgms.DataManager.Model.Helper.Csv.AddYesNoColumn(null, true));

                Xunit.Assert.Equal(ex.ParamName, "newItem");
            }

            /// <summary>
            /// Test to make sure the method succeeds with a true value
            /// </summary>
            [Fact]
            public void ShouldSucceedTrueColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddYesNoColumn(record, true);
            }

            /// <summary>
            /// Test to make sure the method succeeds with a false value
            /// </summary>
            [Fact]
            public void ShouldSucceedFalseColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddYesNoColumn(record, false);
            }
        }

        /// <summary>
        /// Unit tests for the AddTriStateColumn Method
        /// </summary>
        public class AddTriStateColumnMethod
        {
            /// <summary>
            /// Test to ensure an exception is thrown when the record item is null
            /// </summary>
            [Fact]
            public void DataRecordNull()
            {
                var ex = Xunit.Assert.Throws<ArgumentNullException>(
                    () => Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(null, true));

                Xunit.Assert.Equal(ex.ParamName, "newItem");
            }

            /// <summary>
            /// Test to make sure the method succeeds with a no value
            /// </summary>
            [Fact]
            public void ShouldSucceedNoColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(record, false);
            }

            /// <summary>
            /// Test to make sure the method succeeds with a unknown value
            /// </summary>
            [Fact]
            public void ShouldSucceedUnknownColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(record, null);
            }

            /// <summary>
            /// Test to make sure the method succeeds with a yes value
            /// </summary>
            [Fact]
            public void ShouldSucceedYesColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(record, true);
            }
        }
    }
}
