namespace MailUserAgent
{
    partial class MailAgentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.attachImageButton = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.containsHtmlCheckBox = new System.Windows.Forms.CheckBox();
            this.bodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.recipientFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.senderFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.capsLockAlertLabel = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.userMailAgentTabControl = new System.Windows.Forms.TabControl();
            this.SendNewEmailTabPage = new System.Windows.Forms.TabPage();
            this.InboxTabPage = new System.Windows.Forms.TabPage();
            this.viewAttachmentButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteEmailButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pop3SenderFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pop3FromTextBox = new System.Windows.Forms.TextBox();
            this.pop3BodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pop3SubjectTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.authenticationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pop3PassTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pop3LoginTextBox = new System.Windows.Forms.TextBox();
            this.messagesListView = new System.Windows.Forms.ListView();
            this.ColumnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.userMailAgentTabControl.SuspendLayout();
            this.SendNewEmailTabPage.SuspendLayout();
            this.InboxTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.ForeColor = System.Drawing.Color.Olive;
            this.sendButton.Location = new System.Drawing.Point(11, 424);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(200, 48);
            this.sendButton.TabIndex = 19;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.attachImageButton);
            this.groupBox9.Location = new System.Drawing.Point(6, 331);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(211, 87);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Files Attachment";
            // 
            // attachImageButton
            // 
            this.attachImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attachImageButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.attachImageButton.Location = new System.Drawing.Point(5, 21);
            this.attachImageButton.Name = "attachImageButton";
            this.attachImageButton.Size = new System.Drawing.Size(200, 60);
            this.attachImageButton.TabIndex = 13;
            this.attachImageButton.Text = "Attach Image";
            this.attachImageButton.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.containsHtmlCheckBox);
            this.groupBox10.Controls.Add(this.bodyRichTextBox);
            this.groupBox10.Controls.Add(this.checkBox3);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.richTextBox3);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.subjectTextBox);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.textBox3);
            this.groupBox10.Location = new System.Drawing.Point(223, 140);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(670, 345);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Write Your Message Here";
            // 
            // containsHtmlCheckBox
            // 
            this.containsHtmlCheckBox.AutoSize = true;
            this.containsHtmlCheckBox.Location = new System.Drawing.Point(492, 72);
            this.containsHtmlCheckBox.Name = "containsHtmlCheckBox";
            this.containsHtmlCheckBox.Size = new System.Drawing.Size(172, 17);
            this.containsHtmlCheckBox.TabIndex = 8;
            this.containsHtmlCheckBox.Text = "Message Body contains HTML";
            this.containsHtmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // bodyRichTextBox
            // 
            this.bodyRichTextBox.Location = new System.Drawing.Point(9, 92);
            this.bodyRichTextBox.Name = "bodyRichTextBox";
            this.bodyRichTextBox.Size = new System.Drawing.Size(655, 240);
            this.bodyRichTextBox.TabIndex = 7;
            this.bodyRichTextBox.Text = "";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(492, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(172, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Message Body contains HTML";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Body";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(9, 92);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(655, 240);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Subject";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Body";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(6, 39);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(658, 20);
            this.subjectTextBox.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Subject";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(658, 20);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label14);
            this.groupBox14.Controls.Add(this.recipientFullNameTextBox);
            this.groupBox14.Controls.Add(this.label15);
            this.groupBox14.Controls.Add(this.senderFullNameTextBox);
            this.groupBox14.Controls.Add(this.label16);
            this.groupBox14.Controls.Add(this.toTextBox);
            this.groupBox14.Controls.Add(this.label17);
            this.groupBox14.Controls.Add(this.fromTextBox);
            this.groupBox14.Location = new System.Drawing.Point(223, 8);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(670, 126);
            this.groupBox14.TabIndex = 17;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Message Header";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Recipient Full Name";
            // 
            // recipientFullNameTextBox
            // 
            this.recipientFullNameTextBox.Location = new System.Drawing.Point(422, 95);
            this.recipientFullNameTextBox.Name = "recipientFullNameTextBox";
            this.recipientFullNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.recipientFullNameTextBox.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(422, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Sender Full Name";
            // 
            // senderFullNameTextBox
            // 
            this.senderFullNameTextBox.Location = new System.Drawing.Point(422, 39);
            this.senderFullNameTextBox.Name = "senderFullNameTextBox";
            this.senderFullNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.senderFullNameTextBox.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "ToEmails";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(9, 95);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(346, 20);
            this.toTextBox.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "FromEmail";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(6, 39);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(349, 20);
            this.fromTextBox.TabIndex = 5;
            // 
            // capsLockAlertLabel
            // 
            this.capsLockAlertLabel.AutoSize = true;
            this.capsLockAlertLabel.Location = new System.Drawing.Point(12, 137);
            this.capsLockAlertLabel.Name = "capsLockAlertLabel";
            this.capsLockAlertLabel.Size = new System.Drawing.Size(104, 13);
            this.capsLockAlertLabel.TabIndex = 16;
            this.capsLockAlertLabel.Text = "CAPS LOCK ALERT";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label19);
            this.groupBox15.Controls.Add(this.passTextBox);
            this.groupBox15.Controls.Add(this.label20);
            this.groupBox15.Controls.Add(this.loginTextBox);
            this.groupBox15.Location = new System.Drawing.Point(6, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(200, 128);
            this.groupBox15.TabIndex = 14;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Authetication";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Password";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(6, 97);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(188, 20);
            this.passTextBox.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(6, 41);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(188, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // userMailAgentTabControl
            // 
            this.userMailAgentTabControl.Controls.Add(this.SendNewEmailTabPage);
            this.userMailAgentTabControl.Controls.Add(this.InboxTabPage);
            this.userMailAgentTabControl.Location = new System.Drawing.Point(12, 14);
            this.userMailAgentTabControl.Name = "userMailAgentTabControl";
            this.userMailAgentTabControl.SelectedIndex = 0;
            this.userMailAgentTabControl.Size = new System.Drawing.Size(899, 516);
            this.userMailAgentTabControl.TabIndex = 15;
            // 
            // SendNewEmailTabPage
            // 
            this.SendNewEmailTabPage.Controls.Add(this.sendButton);
            this.SendNewEmailTabPage.Controls.Add(this.groupBox15);
            this.SendNewEmailTabPage.Controls.Add(this.groupBox9);
            this.SendNewEmailTabPage.Controls.Add(this.capsLockAlertLabel);
            this.SendNewEmailTabPage.Controls.Add(this.groupBox10);
            this.SendNewEmailTabPage.Controls.Add(this.groupBox14);
            this.SendNewEmailTabPage.Location = new System.Drawing.Point(4, 22);
            this.SendNewEmailTabPage.Name = "SendNewEmailTabPage";
            this.SendNewEmailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SendNewEmailTabPage.Size = new System.Drawing.Size(891, 490);
            this.SendNewEmailTabPage.TabIndex = 0;
            this.SendNewEmailTabPage.Text = "Send New Email";
            this.SendNewEmailTabPage.UseVisualStyleBackColor = true;
            // 
            // InboxTabPage
            // 
            this.InboxTabPage.Controls.Add(this.messagesListView);
            this.InboxTabPage.Controls.Add(this.viewAttachmentButton);
            this.InboxTabPage.Controls.Add(this.label10);
            this.InboxTabPage.Controls.Add(this.deleteEmailButton);
            this.InboxTabPage.Controls.Add(this.label4);
            this.InboxTabPage.Controls.Add(this.pop3SenderFullNameTextBox);
            this.InboxTabPage.Controls.Add(this.label6);
            this.InboxTabPage.Controls.Add(this.pop3FromTextBox);
            this.InboxTabPage.Controls.Add(this.pop3BodyRichTextBox);
            this.InboxTabPage.Controls.Add(this.label7);
            this.InboxTabPage.Controls.Add(this.label9);
            this.InboxTabPage.Controls.Add(this.pop3SubjectTextBox);
            this.InboxTabPage.Controls.Add(this.groupBox1);
            this.InboxTabPage.Location = new System.Drawing.Point(4, 22);
            this.InboxTabPage.Name = "InboxTabPage";
            this.InboxTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InboxTabPage.Size = new System.Drawing.Size(891, 490);
            this.InboxTabPage.TabIndex = 1;
            this.InboxTabPage.Text = "Inbox";
            this.InboxTabPage.UseVisualStyleBackColor = true;
            // 
            // viewAttachmentButton
            // 
            this.viewAttachmentButton.Location = new System.Drawing.Point(749, 113);
            this.viewAttachmentButton.Name = "viewAttachmentButton";
            this.viewAttachmentButton.Size = new System.Drawing.Size(123, 23);
            this.viewAttachmentButton.TabIndex = 31;
            this.viewAttachmentButton.Text = "View Attached Image";
            this.viewAttachmentButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Message List";
            // 
            // deleteEmailButton
            // 
            this.deleteEmailButton.Location = new System.Drawing.Point(48, 147);
            this.deleteEmailButton.Name = "deleteEmailButton";
            this.deleteEmailButton.Size = new System.Drawing.Size(115, 23);
            this.deleteEmailButton.TabIndex = 29;
            this.deleteEmailButton.Text = "Delete Message";
            this.deleteEmailButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sender Full Name";
            // 
            // pop3SenderFullNameTextBox
            // 
            this.pop3SenderFullNameTextBox.Location = new System.Drawing.Point(630, 22);
            this.pop3SenderFullNameTextBox.Name = "pop3SenderFullNameTextBox";
            this.pop3SenderFullNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.pop3SenderFullNameTextBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "FromEmail";
            // 
            // pop3FromTextBox
            // 
            this.pop3FromTextBox.Location = new System.Drawing.Point(215, 22);
            this.pop3FromTextBox.Name = "pop3FromTextBox";
            this.pop3FromTextBox.Size = new System.Drawing.Size(349, 20);
            this.pop3FromTextBox.TabIndex = 18;
            // 
            // pop3BodyRichTextBox
            // 
            this.pop3BodyRichTextBox.Location = new System.Drawing.Point(217, 142);
            this.pop3BodyRichTextBox.Name = "pop3BodyRichTextBox";
            this.pop3BodyRichTextBox.Size = new System.Drawing.Size(655, 342);
            this.pop3BodyRichTextBox.TabIndex = 23;
            this.pop3BodyRichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Body";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Subject";
            // 
            // pop3SubjectTextBox
            // 
            this.pop3SubjectTextBox.Location = new System.Drawing.Point(215, 70);
            this.pop3SubjectTextBox.Name = "pop3SubjectTextBox";
            this.pop3SubjectTextBox.Size = new System.Drawing.Size(658, 20);
            this.pop3SubjectTextBox.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.authenticationButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pop3PassTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pop3LoginTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authorization";
            // 
            // authenticationButton
            // 
            this.authenticationButton.Location = new System.Drawing.Point(42, 107);
            this.authenticationButton.Name = "authenticationButton";
            this.authenticationButton.Size = new System.Drawing.Size(115, 23);
            this.authenticationButton.TabIndex = 4;
            this.authenticationButton.Text = "Load INBOX";
            this.authenticationButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // pop3PassTextBox
            // 
            this.pop3PassTextBox.Location = new System.Drawing.Point(6, 83);
            this.pop3PassTextBox.Name = "pop3PassTextBox";
            this.pop3PassTextBox.Size = new System.Drawing.Size(188, 20);
            this.pop3PassTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // pop3LoginTextBox
            // 
            this.pop3LoginTextBox.Location = new System.Drawing.Point(6, 35);
            this.pop3LoginTextBox.Name = "pop3LoginTextBox";
            this.pop3LoginTextBox.Size = new System.Drawing.Size(188, 20);
            this.pop3LoginTextBox.TabIndex = 1;
            // 
            // messagesListView
            // 
            this.messagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderId,
            this.ColumnHeaderSubject});
            this.messagesListView.FullRowSelect = true;
            this.messagesListView.GridLines = true;
            this.messagesListView.Location = new System.Drawing.Point(6, 194);
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.Size = new System.Drawing.Size(205, 290);
            this.messagesListView.TabIndex = 32;
            this.messagesListView.UseCompatibleStateImageBehavior = false;
            this.messagesListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaderId
            // 
            this.ColumnHeaderId.Text = "ID";
            this.ColumnHeaderId.Width = 40;
            // 
            // ColumnHeaderSubject
            // 
            this.ColumnHeaderSubject.Text = "Subject";
            this.ColumnHeaderSubject.Width = 160;
            // 
            // MailAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 534);
            this.Controls.Add(this.userMailAgentTabControl);
            this.Name = "MailAgentForm";
            this.Text = "MailAgentForm";
            this.Load += new System.EventHandler(this.MailAgentForm_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.userMailAgentTabControl.ResumeLayout(false);
            this.SendNewEmailTabPage.ResumeLayout(false);
            this.SendNewEmailTabPage.PerformLayout();
            this.InboxTabPage.ResumeLayout(false);
            this.InboxTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button attachImageButton;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox containsHtmlCheckBox;
        private System.Windows.Forms.RichTextBox bodyRichTextBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox recipientFullNameTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox senderFullNameTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label capsLockAlertLabel;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TabControl userMailAgentTabControl;
        private System.Windows.Forms.TabPage SendNewEmailTabPage;
        private System.Windows.Forms.TabPage InboxTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pop3PassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pop3LoginTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pop3SenderFullNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pop3FromTextBox;
        private System.Windows.Forms.RichTextBox pop3BodyRichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pop3SubjectTextBox;
        private System.Windows.Forms.Button deleteEmailButton;
        private System.Windows.Forms.Button authenticationButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button viewAttachmentButton;
        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.ColumnHeader ColumnHeaderId;
        private System.Windows.Forms.ColumnHeader ColumnHeaderSubject;
    }
}

