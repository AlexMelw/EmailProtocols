namespace EmailCore.DTOs {
    public class MessageDTO
    {
        public string Id { get; set; }
        public string FromEmail { get; set; }
        public string BodyPlainText { get; set; }
        public string BodyHtmlText { get; set; }
        public string ToEmails { get; set; }
        public string Subject { get; set; }
        public string SenderInfoFullName { get; set; }
    }
}