using System;
using System.Drawing;
using System.Windows.Forms;
using EmailCore;
using EmailCore.DomainModels;
using MailUserAgent.Properties;
using NUglify;

namespace MailUserAgent
{
    public partial class MailAgentForm : Form
    {
        private string _imagePath;

        #region CONSTRUCTORS

        public MailAgentForm()
        {
            InitializeComponent();
        }

        #endregion

        private void MailAgentForm_Load(object sender, EventArgs e)
        {
            RegisterControlsProperties();
            RegisterControlsEvents();
        }

        private void RegisterControlsProperties()
        {
            passTextBox.PasswordChar = '*';
            capsLockAlertLabel.Text = string.Empty;

            authFromTextBox.ReadOnly = true;
            authToTextBox.ReadOnly = true;
            authSenderFullNameTextBox.ReadOnly = true;
            authRecipientFullNameTextBox.ReadOnly = true;
            authSubjectTextBox.ReadOnly = true;
            authBodyRichTextBox.ReadOnly = true;

            authFromTextBox.BackColor = Color .Bisque;
            authToTextBox.BackColor = Color.Bisque;
            authSenderFullNameTextBox.BackColor = Color.Bisque;
            authRecipientFullNameTextBox.BackColor = Color.Bisque;
            authSubjectTextBox.BackColor = Color.Bisque;
            authBodyRichTextBox.BackColor = Color.Bisque;

            // HARDCODE - INBOX
            authLoginTextBox.Text = "slava";
            authPassTextBox.Text = "%%Elim24pass%%";
            authPassTextBox.PasswordChar = '*';

            // HARDCODE - SEND NEW MESSAGE
            loginTextBox.Text = "postmaster";
            passTextBox.Text = "%%Elim24pass%%";
            fromTextBox.Text = "postmaster@slava.local";
            toTextBox.Text = "slava@slava.local";
            senderFullNameTextBox.Text = "Veaceslav Barbarii ADMIN";
            recipientFullNameTextBox.Text = "Slavik Barbarii USER";
            subjectTextBox.Text = "A test subject";
            bodyRichTextBox.Text = @"<!DOCTYPE html>
<html>
<head>
  <meta content=""text/html; charset=UTF-8"" http-equiv=""Content-Type"">
</head>
<body>

<p style=""font: 400 10pt 'Source Sans Pro', sans-serif; margin:15px 0px 0px 0px;"">
Hello Veaceslav Barbarii,
</p>

<p style=""font: 400 10pt 'Source Sans Pro', sans-serif; margin:15px 0px 0px 0px;"">This is a welcome message announcing y
ou that account slava in domain slava.local has been created for your use.</p>

<p style=""font: 400 10pt 'Source Sans Pro', sans-serif; margin:15px 0px 0px 0px;"">
Thank you,<br>
The Postmaster
</p>

<p style=""font: 400 10pt 'Source Sans Pro', sans-serif; margin:15px 0px 0px 0px;"">
TIP:<br>
You can enable Axigen's Identity Confirmation &copy; service from your WebMail interface, by going to the Settings -&gt;
 AntiSpam section. Axigen's Identity Confirmation &copy; service is basically a Challenge / Response anti-spam system de
signed to protect your Inbox from automated, unsolicited emails.
</p>

<p style=""font: 400 10pt 'Source Sans Pro', sans-serif; margin:15px 0px 0px 0px;"">For more information please visit
<a href=""http://www.axigen.com/identity-confirmation/"">http://www.axigen.com/identity-confirmation/</a>
</p>

</body>
</html>";
        }

        private void RegisterControlsEvents()
        {
            attachImageButton.Click += (sender, args) =>
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = Resources.ImageExtensionsFilter;

                    if (openFileDialog.ShowDialog() == DialogResult.OK) // Test result.
                        _imagePath = openFileDialog.FileName;
                }
            };

            sendButton.Click += (sender, args) =>
            {
                MessageDomainModel messageModel = new MessageDomainModel
                {
                    FromEmail = fromTextBox.Text,
                    ToEmail = toTextBox.Text,
                    Subject = subjectTextBox.Text,

                    BodyHtmlText = !containsHtmlCheckBox.Checked
                        ? string.Empty
                        : bodyRichTextBox.Text,

                    BodyPlainText = containsHtmlCheckBox.Checked
                        ? Uglify.HtmlToText(bodyRichTextBox.Text).Code
                        : bodyRichTextBox.Text,

                    SenderInfoFullName = senderFullNameTextBox.Text,
                    RecipientInfoFullName = recipientFullNameTextBox.Text,
                    ImagePath = _imagePath
                };

                MailAgentClient mailAgentClient = new MailAgentClient(loginTextBox.Text, passTextBox.Text);

                mailAgentClient.Send(messageModel);
            };

            passTextBox.TextChanged += (sender, args) =>
            {
                capsLockAlertLabel.Text = IsKeyLocked(Keys.CapsLock) ? "The Caps Lock Key is ON!" : string.Empty;
            };
        }
    }
}