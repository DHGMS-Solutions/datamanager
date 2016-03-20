namespace TestDhgms.DataManager.ExtendedTest.Model.Helper
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Unit tests for the DNS helper class
    /// </summary>
    [TestClass]
    public class Dns
    {
        /// <summary>
        /// Unit tests for the HostnameHasMx method
        /// </summary>
        [TestClass]
        public class HostnameExistsMethod
        {
            /// <summary>
            /// Test to ensure an exception is thrown if the hostname is empty
            /// </summary>
            [TestMethod]
            public void EmptyHostname()
            {
                var ex = Xunit.Assert.Throws<ArgumentNullException>(() => Dhgms.DataManager.Model.Helper.Dns.HostnameExists(string.Empty));

                Xunit.Assert.Equal(ex.ParamName, "hostName");
            }

            /// <summary>
            /// Test to make sure the result is false if there is no MX record or the hostname doesn't exist
            /// </summary>
            [TestMethod]
            public void NoMxRecord()
            {
                Xunit.Assert.False(Dhgms.DataManager.Model.Helper.Dns.HostnameExists("zzzzzzzzzz.dhgms.com"));
            }

            /// <summary>
            /// Test to make the result is true on a hostname with MX records
            /// </summary>
            [TestMethod]
            public void ShouldSuceed()
            {
                Xunit.Assert.True(Dhgms.DataManager.Model.Helper.Dns.HostnameExists("dhgms.com"));
            }
        }

        /// <summary>
        /// Unit tests for the HostnameHasMx method
        /// </summary>
        [TestClass]
        public class HostnameHasMxRecordMethod
        {
            /// <summary>
            /// Test to ensure an exception is thrown if the hostname is empty
            /// </summary>
            [TestMethod]
            public void EmptyHostname()
            {
                var ex = Xunit.Assert.Throws<ArgumentNullException>(() => Dhgms.DataManager.Model.Helper.Dns.HostnameHasMxRecord(string.Empty));

                Xunit.Assert.Equal(ex.ParamName, "hostName");
            }

            /// <summary>
            /// Test to make sure the result is false if there is no MX record or the hostname doesn't exist
            /// </summary>
            [TestMethod]
            public void NoMxRecord()
            {
                Xunit.Assert.False(Dhgms.DataManager.Model.Helper.Dns.HostnameHasMxRecord("zzzzzzzzzz.dhgms.com"));
            }

            /// <summary>
            /// Test to make the result is true on a hostname with MX records
            /// </summary>
            [TestMethod]
            public void ShouldSuceed()
            {
                Xunit.Assert.True(Dhgms.DataManager.Model.Helper.Dns.HostnameHasMxRecord("dhgms.com"));
            }
        }
    }
}
