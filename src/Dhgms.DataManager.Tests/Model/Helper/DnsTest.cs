//namespace Dhgms.DataManager.Tests.Model.Helper
//{
//    using System;

//    using Xunit;

//    /// <summary>
//    /// Unit tests for the DNS helper class
//    /// </summary>
//    public class DnsTest
//    {
//        /// <summary>
//        /// Unit tests for the HostnameHasMx method
//        /// </summary>
//        public class HostnameExistsMethod
//        {
//            /// <summary>
//            /// Test to ensure an exception is thrown if the hostname is empty
//            /// </summary>
//            [Fact]
//            public void EmptyHostname()
//            {
//                var ex = Xunit.Assert.Throws<ArgumentNullException>(() => Dhgms.DataManager.Model.Helper.Dns.HostnameExists(string.Empty));

//                Xunit.Assert.Equal(ex.ParamName, "hostName");
//            }

//            /// <summary>
//            /// Test to make sure the result is false if there is no MX record or the hostname doesn't exist
//            /// </summary>
//            [Fact]
//            public void NoMxRecord()
//            {
//                Xunit.Assert.False(Dhgms.DataManager.Model.Helper.Dns.HostnameExists("zzzzzzzzzz.dhgms.com"));
//            }

//            /// <summary>
//            /// Test to make the result is true on a hostname with MX records
//            /// </summary>
//            [Fact]
//            public void ShouldSuceed()
//            {
//                Xunit.Assert.True(Dhgms.DataManager.Model.Helper.Dns.HostnameExists("dhgms.com"));
//            }
//        }

//        /// <summary>
//        /// Unit tests for the HostnameHasMx method
//        /// </summary>
//        public class HostnameHasMxRecordMethod
//        {
//            /// <summary>
//            /// Test to ensure an exception is thrown if the hostname is empty
//            /// </summary>
//            [Fact]
//            public void EmptyHostname()
//            {
//                var ex = Xunit.Assert.Throws<ArgumentNullException>(() => Dhgms.DataManager.Model.Helper.Dns.HostnameHasMxRecord(string.Empty));

//                Xunit.Assert.Equal(ex.ParamName, "hostName");
//            }

//            /// <summary>
//            /// Test to make sure the result is false if there is no MX record or the hostname doesn't exist
//            /// </summary>
//            [Fact]
//            public void NoMxRecord()
//            {
//                Xunit.Assert.False(Dhgms.DataManager.Model.Helper.Dns.HostnameHasMxRecord("zzzzzzzzzz.dhgms.com"));
//            }

//            /// <summary>
//            /// Test to make the result is true on a hostname with MX records
//            /// </summary>
//            [Fact]
//            public void ShouldSuceed()
//            {
//                Xunit.Assert.True(Dhgms.DataManager.Model.Helper.Dns.HostnameHasMxRecord("dhgms.com"));
//            }
//        }
//    }
//}
