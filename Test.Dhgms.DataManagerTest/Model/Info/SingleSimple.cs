using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Dhgms.DataManagerTest.Model.Info
{
    [TestClass]
    public class SingleSimple
    {
        [TestMethod]
        public void TestCopyConstructorNull()
        {
            var ex = Xunit.Assert.Throws<ArgumentNullException>(() => new TestDhgms.DataManagerMocking.Model.Info.SingleSimple(null));

            Xunit.Assert.Equal(ex.ParamName, "other");
        }

        [TestMethod]
        public void TestCopyConstructor()
        {
            new TestDhgms.DataManagerMocking.Model.Info.SingleSimple(new TestDhgms.DataManagerMocking.Model.Info.SingleSimple());
        }

        [TestMethod]
        public void TestGetHeaderRecord()
        {
            var item = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            var headerRecord = item.HeaderRecord;

            Assert.IsNotNull(headerRecord);
            Assert.AreEqual(2, headerRecord.Count);
            Assert.AreEqual("Id", headerRecord[0]);
            Assert.AreEqual("Name", headerRecord[1]);
        }

        /// <summary>
        /// This is a test to ensure the equals operator doesn't produce
        /// a stack overflow exception
        /// </summary>
        [TestMethod]
        public void TestEqualsOperatorBothSidesNull()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = null;
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple other = null;
            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            if (one == other)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
            {
                return;
            }

            Assert.Fail("Should have returned true");
        }

        /// <summary>
        /// This is a test to ensure the equals operator doesn't produce
        /// a stack overflow exception
        /// </summary>
        [TestMethod]
        public void TestEqualsOperatorOneNull()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple other = null;
            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            if (one == other)
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
            {
                Assert.Fail("Should have returned true");
            }
        }

        /// <summary>
        /// This is a test to ensure the equals operator doesn't produce
        /// a stack overflow exception
        /// </summary>
        [TestMethod]
        public void TestEqualsOperatorOtherNull()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = null;
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple other = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            if (one == other)
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
            {
                Assert.Fail("Should have returned false");
            }
        }

        /// <summary>
        /// This is a test to ensure the equals operator doesn't produce
        /// a stack overflow exception
        /// </summary>
        [TestMethod]
        public void TestEqualsOperatorSameVariableBothSides()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple two = one;
            // ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable EqualExpressionComparison
            if (one == two)
// ReSharper restore EqualExpressionComparison
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
            {
                return;
            }

            Assert.Fail("Should have returned true");
        }

        /// <summary>
        /// This is a test to ensure the equals operator doesn't produce
        /// a stack overflow exception
        /// </summary>
        [TestMethod]
        public void TestEqualsOperatorDifferentVariableEqualValues()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple other = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();

            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            // ReSharper disable EqualExpressionComparison
            if (one == other)
            // ReSharper restore EqualExpressionComparison
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
            {
                return;
            }

            Assert.Fail("Should have returned true");
        }

        /// <summary>
        /// This is a test to ensure the equals operator doesn't produce
        /// a stack overflow exception
        /// </summary>
        [TestMethod]
        public void TestEqualsOperatorDifferentVariableDifferentValues()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple other = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            other.Id = 1;

            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            // ReSharper disable EqualExpressionComparison
            if (one == other)
            // ReSharper restore EqualExpressionComparison
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
            {
                Assert.Fail("Should have returned false");
            }
        }

        [TestMethod]
        public void TestGetHashCode()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            Console.WriteLine(one.GetHashCode());
        }

        [TestMethod]
        public void TestGetDifferencesNone()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            var differences = one.GetDifferences(one);
            Assert.AreEqual(0, differences.Count);
        }

        [TestMethod]
        public void TestStringArrayDefaults()
        {
            TestDhgms.DataManagerMocking.Model.Info.SingleSimple one = new TestDhgms.DataManagerMocking.Model.Info.SingleSimple();
            var stringArray = one.ToStringArray();
            Assert.AreEqual(2, stringArray.Count);
            Assert.AreEqual("0", stringArray[0]);
            Assert.IsNull(stringArray[1]);
        }
    }
}
