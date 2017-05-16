using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmailCore;
using EmailCore.DomainModels;
using EmailCore.DTOs;
using MailUserAgent.Properties;
using NUglify;

namespace MailUserAgent
{
    public partial class MailAgentForm : Form
    {
        private string _imagePath;
        private List<MessageDTO> _messageDTOs;

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
            #region Controls Properties

            passTextBox.PasswordChar = '*';
            capsLockAlertLabel.Text = string.Empty;

            pop3FromTextBox.ReadOnly = true;
            //authToTextBox.ReadOnly = true;
            pop3SenderFullNameTextBox.ReadOnly = true;
            //authRecipientFullNameTextBox.ReadOnly = true;
            pop3SubjectTextBox.ReadOnly = true;
            pop3BodyRichTextBox.ReadOnly = true;

            pop3FromTextBox.BackColor = Color.PaleGreen;
            //authToTextBox.BackColor = Color.Bisque;
            pop3SenderFullNameTextBox.BackColor = Color.PaleGreen;
            //authRecipientFullNameTextBox.BackColor = Color.Bisque;
            pop3SubjectTextBox.BackColor = Color.PaleGreen;
            pop3BodyRichTextBox.BackColor = Color.PaleGreen;

            #endregion

            #region HardCoded INBOX

            // HARDCODE - INBOX
            pop3LoginTextBox.Text = "slava";
            pop3PassTextBox.Text = "%%Elim24pass%%";
            pop3PassTextBox.PasswordChar = '*';

            #endregion

            #region HardCoded SEND NEW MESSAGE

            // HARDCODE - SEND NEW MESSAGE
            loginTextBox.Text = "dima";
            passTextBox.Text = "qwerty";
            fromTextBox.Text = "dima@slava.local";
            toTextBox.Text = "slava@slava.local";
            senderFullNameTextBox.Text = "Dumitru Guba";
            recipientFullNameTextBox.Text = "Veaceslav Barbarii";
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
Regards,<br>
Dumitru Guba
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

            #endregion
        }

        private void RegisterControlsEvents()
        {
            passTextBox.TextChanged += (sender, args) => capsLockAlertLabel.Text =
                IsKeyLocked(Keys.CapsLock) ? "The Caps Lock Key is ON!" : string.Empty;

            messagesListView.Click += (sender, args) =>
            {
                int selectedIndex = ((ListView) sender).SelectedItems[0].Index;
                MessageDTO dto = _messageDTOs[selectedIndex];

                pop3FromTextBox.Text = dto.FromEmail;
                pop3SenderFullNameTextBox.Text = dto.SenderInfoFullName;
                pop3SubjectTextBox.Text = dto.Subject;
                pop3BodyRichTextBox.Text = dto.BodyPlainText;
            };

            deleteEmailButton.Click += (sender, args) =>
            {
                Task.Run(() =>
                {
                    var mailAgentClient = new EmailClient(pop3LoginTextBox.Text, pop3PassTextBox.Text);

                    string messageUID = default(string);

                    if (messagesListView.InvokeRequired)
                    {
                        messagesListView.Invoke((MethodInvoker)(() =>
                        {
                            if (messagesListView.Items.Count == 0)
                                return;

                            messageUID = messagesListView
                                .Items[messagesListView.SelectedIndices[0]]
                                .SubItems[2]
                                .Text;
                        }) );
                    }
                    else
                    {
                        if (messagesListView.Items.Count == 0)
                            return;

                        messageUID = messagesListView
                            .Items[messagesListView.SelectedIndices[0]]
                            .SubItems[2]
                            .Text;
                    }

                    mailAgentClient.DeleteMessageById(messageUID);

                    if (messagesListView.Items.Count > 0)
                        messagesListView.Items.RemoveAt(messagesListView.SelectedIndices[0]);
                });
            };

            attachImageButton.Click += (sender, args) =>
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = Resources.ImageExtensionsFilter;

                    _imagePath = openFileDialog.ShowDialog() == DialogResult.OK
                        ? openFileDialog.FileName
                        : string.Empty;
                }
            };

            sendButton.Click += (sender, args) =>
            {
                MessageDomainModel messageModel = new MessageDomainModel
                {
                    FromEmail = fromTextBox.Text,
                    ToEmail = toTextBox.Text,
                    Subject = subjectTextBox.Text,

                    BodyHtmlText = containsHtmlCheckBox.Checked
                        ? bodyRichTextBox.Text
                        : string.Empty,

                    BodyPlainText = containsHtmlCheckBox.Checked
                        ? Uglify.HtmlToText(bodyRichTextBox.Text).Code
                        : bodyRichTextBox.Text,

                    SenderInfoFullName = senderFullNameTextBox.Text,
                    RecipientInfoFullName = recipientFullNameTextBox.Text,
                    ImagePath = _imagePath
                };

                _imagePath = default(string);

                var mailAgentClient = new EmailClient(loginTextBox.Text, passTextBox.Text);

                try
                {
                    Task.Run(() => mailAgentClient.Send(messageModel));
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    MessageBox.Show("Some errors occurred while sending your message. Sorry about that.");
                }
            };
            authenticationButton.Click += (sender, args) =>
            {
                Task.Run(() =>
                {
                    var mailAgentClient = new EmailClient(pop3LoginTextBox.Text, pop3PassTextBox.Text);
                    _messageDTOs = mailAgentClient.GetAllMessages();

                    if (messagesListView.InvokeRequired)
                    {
                        messagesListView.Invoke((MethodInvoker) (() =>
                        {
                            messagesListView.BeginUpdate();

                            messagesListView.Items.Clear();
                            for (int i = 0; i < _messageDTOs.Count; i++)
                            {
                                var item = new ListViewItem($"{i + 1}");
                                item.SubItems.Add(_messageDTOs[i].Subject);
                                item.SubItems.Add(_messageDTOs[i].Id);
                                messagesListView.Items.Add(item);
                            }
                            messagesListView.EndUpdate();
                        }));
                    }
                    else
                    {
                        messagesListView.BeginUpdate();

                        messagesListView.Items.Clear();
                        for (int i = 0; i < _messageDTOs.Count; i++)
                        {
                            var item = new ListViewItem($"{i + 1}");
                            item.SubItems.Add(_messageDTOs[i].Subject);
                            item.SubItems.Add(_messageDTOs[i].Id);
                            messagesListView.Items.Add(item);
                        }
                        messagesListView.EndUpdate();
                    }
                });
            };

            viewAttachmentButton.Click += (sender, args) =>
            {
                Task.Run(() =>
                {
                    var mailAgentClient = new EmailClient(pop3LoginTextBox.Text, pop3PassTextBox.Text);
                    int selectedIndex = default(int);
                    string messageUID = default(string);

                    if (messagesListView.InvokeRequired)
                    {
                        messagesListView.Invoke((MethodInvoker) (() =>
                        {
                            selectedIndex = messagesListView.SelectedItems[0].Index;
                            messageUID = messagesListView
                                .Items[selectedIndex]
                                .SubItems[2]
                                .Text;
                        }));
                    }
                    else
                    {
                        selectedIndex = messagesListView.SelectedItems[0].Index;
                        messageUID = messagesListView
                            .Items[selectedIndex]
                            .SubItems[2]
                            .Text;
                    }

                    try
                    {
                        string imagePath = mailAgentClient.GetImageAttachmentByMessageUID(messageUID);
                        Process.Start(imagePath);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There is no attachment");
                    }
                });
            };
        }
    }
}