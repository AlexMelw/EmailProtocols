using EmailCore.DomainModels;
using MailKit.Net.Smtp;
using MimeKit;

namespace EmailCore
{
    public class MailAgentClient
    {
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
            BodyBuilder builder = new BodyBuilder();

            builder.TextBody = model.BodyPlainText;
            builder.HtmlBody = model.BodyHtmlText;

            if (!string.IsNullOrEmpty(model.ImagePath))
                builder.Attachments.Add(model.ImagePath);

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress(
                model.SenderInfoFullName,
                model.FromEmail));

            message.To.Add(new MailboxAddress(
                model.RecipientInfoFullName,
                model.ToEmail));

            message.Subject = model.Subject;

            message.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                //client.ServerCertificateValidationCallback = (object s, X509Certificate c, X509Chain h, SslPolicyErrors e) => true;

                client.Connect("127.0.0.1", 25, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(_login, _password);

                client.Send(message);
                client.Disconnect(true);
            }
            return true;
        }

        public void GetImageAttachmentForMessage(int messageIndex) { }

        public void GetAllMessages() { }

        public void GetNewMessages() { }
    }
}