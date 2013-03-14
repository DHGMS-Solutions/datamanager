// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Email.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
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

            using (var mail = new MailMessage())
            {
                mail.From = from;

                if (to != null)
                {
                    foreach (MailAddress item in to)
                    {
                        mail.To.Add(item);
                    }
                }

                if (cc != null)
                {
                    foreach (MailAddress item in cc)
                    {
                        mail.CC.Add(item);
                    }
                }

                if (bcc != null)
                {
                    foreach (MailAddress item in bcc)
                    {
                        mail.Bcc.Add(item);
                    }
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = isHtml;

                if (attachment != null)
                {
                    mail.Attachments.Add(attachment);
                }

                var smtpClient = new SmtpClient(hostName) { UseDefaultCredentials = true };

                // use windows auth
                smtpClient.Send(mail);
            }
        }

        #endregion
    }
}