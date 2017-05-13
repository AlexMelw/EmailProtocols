namespace EmailCore.DomainModels
{
    public class MessageDomainModel
    {
        public string FromEmail { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string BodyPlainText { get; set; }
        public string BodyHtmlText { get; set; }
        public string SenderInfoFullName { get; set; }
        public string RecipientInfoFullName { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(FromEmail)}: {FromEmail}, {nameof(ToEmail)}: {ToEmail}, " +
                $"{nameof(Subject)}: {Subject}, {nameof(BodyPlainText)}: {BodyPlainText}, " +
                $"{nameof(BodyHtmlText)}: {BodyHtmlText}, {nameof(SenderInfoFullName)}: " +
                $"{SenderInfoFullName}, {nameof(RecipientInfoFullName)}: " +
                $"{RecipientInfoFullName}, {nameof(ImagePath)}: {ImagePath}";
        }
    }
}