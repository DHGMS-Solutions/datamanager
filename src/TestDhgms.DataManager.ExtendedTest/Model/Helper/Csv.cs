namespace TestDhgms.DataManager.ExtendedTest.Model.Helper
{
    using System;

    using Dhgms.DataManager.Model.Info;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Unit tests for CSV helpers
    /// </summary>
    [TestClass]
    public class Csv
    {
        /// <summary>
        /// Unit tests for the AddYesNoColumn Method
        /// </summary>
        [TestClass]
        public class AddYesNoColumnMethod
        {
            /// <summary>
            /// Test to ensure an exception is thrown when the record item is null
            /// </summary>
            [TestMethod]
            public void DataRecordNull()
            {
                var ex = Xunit.Assert.Throws<ArgumentNullException>(
                    () => Dhgms.DataManager.Model.Helper.Csv.AddYesNoColumn(null, true));

                Xunit.Assert.Equal(ex.ParamName, "newItem");
            }

            /// <summary>
            /// Test to make sure the method succeeds with a true value
            /// </summary>
            [TestMethod]
            public void ShouldSucceedTrueColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddYesNoColumn(record, true);
            }

            /// <summary>
            /// Test to make sure the method succeeds with a false value
            /// </summary>
            [TestMethod]
            public void ShouldSucceedFalseColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddYesNoColumn(record, false);
            }
        }

        /// <summary>
        /// Unit tests for the AddTriStateColumn Method
        /// </summary>
        [TestClass]
        public class AddTriStateColumnMethod
        {
            /// <summary>
            /// Test to ensure an exception is thrown when the record item is null
            /// </summary>
            [TestMethod]
            public void DataRecordNull()
            {
                var ex = Xunit.Assert.Throws<ArgumentNullException>(
                    () => Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(null, TriState.Yes));

                Xunit.Assert.Equal(ex.ParamName, "newItem");
            }

            /// <summary>
            /// Test to make sure the method succeeds with a no value
            /// </summary>
            [TestMethod]
            public void ShouldSucceedNoColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(record, TriState.No);
            }

            /// <summary>
            /// Test to make sure the method succeeds with a unknown value
            /// </summary>
            [TestMethod]
            public void ShouldSucceedUnknownColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(record, TriState.Unknown);
            }

            /// <summary>
            /// Test to make sure the method succeeds with a yes value
            /// </summary>
            [TestMethod]
            public void ShouldSucceedYesColumn()
            {
                var record = new Kent.Boogaart.KBCsv.DataRecord(null);
                Dhgms.DataManager.Model.Helper.Csv.AddTriStateColumn(record, TriState.Yes);
            }
        }
    }
}
