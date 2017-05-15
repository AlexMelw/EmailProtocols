using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EmailCore.DomainModels;
using EmailCore.DTOs;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace EmailCore
{
    public class MailAgentClient
    {
        private const string Localhost = "127.0.0.1";
        private const int SmtpDefaultPort = 25;
        private const int Pop3DefaultPort = 110;
        private readonly string _login;
        private readonly string _password;

        #region CONSTRUCTORS

        public MailAgentClient(string login, string password)
        {
            _login = login;
            _password = password;
        }

        #endregion

        public bool Send(MessageDomainModel model)
        {
            var builder = new BodyBuilder
            {
                TextBody = model.BodyPlainText,
                HtmlBody = model.BodyHtmlText
            };

            if (!string.IsNullOrEmpty(model.ImagePath))
                builder.Attachments.Add(model.ImagePath);

            var message = new MimeMessage();

            message.From.Add(
                new MailboxAddress(
                    model.SenderInfoFullName,
                    model.FromEmail));

            message.To.Add(
                new MailboxAddress(
                    model.RecipientInfoFullName,
                    model.ToEmail));

            message.Subject = model.Subject;
            message.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                //client.ServerCertificateValidationCallback = (object s, X509Certificate c, X509Chain h, SslPolicyErrors e) => true;

                client.Connect(Localhost, SmtpDefaultPort, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(_login, _password);

                try
                {
                    client.Send(message);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    return false;
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
            return true;
        }

        public List<MessageDTO> GetAllMessages()
        {
            using (var client = new Pop3Client())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                //client.ServerCertificateValidationCallback = (object s, X509Certificate c, X509Chain h, SslPolicyErrors e) => true;

                client.Connect(Localhost, Pop3DefaultPort, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                try
                {
                    // Mandatory authentication
                    client.Authenticate(_login, _password);

                    IList<MimeMessage> mineMessages = null;

                    if (client.Count >= 1)
                        mineMessages = client.GetMessages(0, client.Count);


                    List<MessageDTO> messageDTOs = mineMessages?
                                                       .Select(m => new MessageDTO
                                                       {
                                                           Id = m.MessageId,
                                                           FromEmail = m.From[0].ToString(),
                                                           ToEmails = m.To.ToString(),
                                                           Subject = m.Subject,
                                                           SenderInfoFullName = m.From[0].Name,
                                                           BodyHtmlText = m.HtmlBody,
                                                           BodyPlainText = m.GetTextBody(TextFormat.Plain)
                                                       })
                                                       .ToList()
                                                   ?? Enumerable.Empty<MessageDTO>().ToList();

                    return messageDTOs;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }

        public string GetImageAttachmentByMessageUID(string messageUID)
        {
            using (var client = new Pop3Client())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                //client.ServerCertificateValidationCallback = (object s, X509Certificate c, X509Chain h, SslPolicyErrors e) => true;

                client.Connect(Localhost, Pop3DefaultPort, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                try
                {
                    // Mandatory authentication
                    client.Authenticate(_login, _password);

                    MimeMessage message = client
                        .GetMessages(0, client.Count)
                        .First(msg => msg.MessageId == messageUID);

                    MimePart imageMimePart = message?.Attachments
                        .Where(p => p.ContentType.MediaType == "image" || p.IsAttachment)
                        .OfType<MimePart>()
                        .First();

                    if (!File.Exists(imageMimePart?.FileName))
                        using (FileStream output = File.Create(imageMimePart?.FileName))
                            imageMimePart?.ContentObject.DecodeTo(output);

                    return imageMimePart?.FileName ?? string.Empty;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }

        public void DeleteMessageById(string messageUID)
        {
            using (var client = new Pop3Client())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                //client.ServerCertificateValidationCallback = (object s, X509Certificate c, X509Chain h, SslPolicyErrors e) => true;

                client.Connect(Localhost, Pop3DefaultPort, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                try
                {
                    // Mandatory authentication
                    client.Authenticate(_login, _password);

                    for (int i = 0; i < client.Count; i++)
                    {
                        if (client.GetMessage(i).MessageId == messageUID)
                        {
                            client.DeleteMessage(i);
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}