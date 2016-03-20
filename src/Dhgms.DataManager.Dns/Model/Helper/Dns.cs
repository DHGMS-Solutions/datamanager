// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dns.cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Helpers for working with DNS
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;

    using ARSoft.Tools.Net.Dns;

    using Dhgms.DataManager.Model.Exception;

    /// <summary>
    /// Helpers for working with DNS
    /// </summary>
    public static class Dns
    {
        /// <summary>
        /// Check to see if a hostname exists
        /// </summary>
        /// <param name="hostName">
        /// The host name.
        /// </param>
        /// <returns>
        /// whether the hostname exists
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// hostname is blank
        /// </exception>
        /// <exception cref="DnsLookupException">
        /// DNS lookup failed
        /// </exception>
        public static bool HostnameExists(string hostName)
        {
            if (string.IsNullOrWhiteSpace(hostName))
            {
                throw new ArgumentNullException("hostName");
            }

            var dnsMessage = DnsClient.Default.Resolve(hostName, RecordType.Any);
            if ((dnsMessage == null) || ((dnsMessage.ReturnCode != ReturnCode.NoError) && (dnsMessage.ReturnCode != ReturnCode.NxDomain)))
            {
                throw new DnsLookupException();
            }

            return dnsMessage.ReturnCode != ReturnCode.NxDomain;
        }

        /// <summary>
        /// Checks to see if a hostname has MX records associated with it
        /// </summary>
        /// <param name="hostName">
        /// The host name.
        /// </param>
        /// <returns>
        /// whether the MX records
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The hostname is null
        /// </exception>
        /// <exception cref="DnsLookupException">
        /// The DNS lookup failed
        /// </exception>
        public static bool HostnameHasMxRecord(string hostName)
        {
            if (string.IsNullOrWhiteSpace(hostName))
            {
                throw new ArgumentNullException("hostName");
            }

            var dnsMessage = DnsClient.Default.Resolve(hostName, RecordType.Mx);
            if ((dnsMessage == null) || ((dnsMessage.ReturnCode != ReturnCode.NoError) && (dnsMessage.ReturnCode != ReturnCode.NxDomain)))
            {
                throw new DnsLookupException();
            }

            return dnsMessage.AnswerRecords.Count > 0;
        }
    }
}
