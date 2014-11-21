// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="EmailExtensions.cs">
//   Copyright 2004-2014 DHGMS Solutions.
//      
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//      
//   http://www.apache.org/licenses/LICENSE-2.0
//      
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <summary>
//   Helper methods for email addresses
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Net.Mail;

    using Dhgms.DataManager.Model.ConfigurationElement;
    using Dhgms.DataManager.Model.ConfigurationElementCollection;
    using Dhgms.DataManager.Model.Exception.Email;

    /// <summary>
    /// Helper methods for email addresses
    /// </summary>
    public static class EmailExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Gets a collection of email addresses from an email recipient collection from a config file
        /// </summary>
        /// <param name="recipients">
        /// </param>
        /// <returns>
        /// </returns>
        public static MailAddressCollection GetMailAddressCollection(EmailRecipientCollection recipients)
        {
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients");
            }

            var result = new MailAddressCollection();

            foreach (EmailRecipient item in recipients)
            {
                result.Add(item.Value);
            }

            return result;
        }

        /// <summary>
        /// Wrapper for sending an email with a file attachment
        /// </summary>
        /// <param name="hostName">
        /// </param>
        /// <param name="from">
        /// </param>
        /// <param name="to">
        /// </param>
        /// <param name="cc">
        /// </param>
        /// <param name="bcc">
        /// </param>
        /// <param name="subject">
        /// </param>
        /// <param name="body">
        /// </param>
        /// <param name="attachment">
        /// </param>
        /// <param name="isHtml">
        /// Whether the email body is HTML
        /// </param>
        public static void SendEmail(
            string hostName, 
            MailAddress from, 
            MailAddressCollection to, 
            MailAddressCollection cc, 
            MailAddressCollection bcc, 
            string subject, 
            string body, 
            Attachment attachment, 
            bool isHtml)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if ((to == null || to.Count == 0) && (cc == null || cc.Count == 0) && (bcc == null || bcc.Count == 0))
            {
                throw new NoRecipientsException();
            }

            MailMessage mail = null;
            try
            {
                mail = new MailMessage();

                mail.From = from;

                AddRecipients(mail.To, to);
                AddRecipients(mail.CC, cc);
                AddRecipients(mail.Bcc, bcc);

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = isHtml;

                if (attachment != null)
                {
                    mail.Attachments.Add(attachment);
                }

                SendEmail(hostName, mail);
            }
            finally
            {
                if (mail != null)
                {
                    mail.Dispose();
                }
            }
        }

        private static void AddRecipients(MailAddressCollection targetCollection, MailAddressCollection sourceCollection)
        {
            if (sourceCollection != null)
            {
                foreach (var item in sourceCollection)
                {
                    targetCollection.Add(item);
                }
            }
        }

        private static void SendEmail(string hostname, MailMessage mail)
        {
            SmtpClient smtpClient = null;

            try
            {
                smtpClient = new SmtpClient(hostname);
                
                // don't use an intialisation list on a disposable type
                // fxcop doesn't like it
                smtpClient.UseDefaultCredentials = true;

                // use windows auth
                smtpClient.Send(mail);
            }
            finally
            {
                if (smtpClient != null)
                {
                    smtpClient.Dispose();
                }
            }
        }

        #endregion
    }
}