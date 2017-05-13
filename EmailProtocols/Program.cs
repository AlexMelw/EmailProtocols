using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using MailKit.Net.Smtp;
using MimeKit;

namespace EmailCore
{
    class Program
    {
        static void Main(string[] args)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Postmaster", "admin@slava.local"));
            message.To.Add(new MailboxAddress("Veaceslav Barbarii RU", "veaceslav.barbarii@mail.ru"));
            message.To.Add(new MailboxAddress("Veaceslav Barbarii Local", "slava@slava.local"));
            message.Subject = "How you doin'???";

            message.Body = new TextPart("plain")
            {
                Text = @"Hey Chandler,

I just wanted to let you know that Monica and I were going to go play some paintball, you in?

-- Joey"
            };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (object s, X509Certificate c, X509Chain h, SslPolicyErrors e) => true;

                client.Connect("127.0.0.1", 25, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("postmaster", "%%Elim24pass%%");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}