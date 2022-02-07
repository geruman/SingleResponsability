namespace SingleResponsability
{
    public class MailMessage
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public MailMessage(string head,string body)
        {
            Head = head;
            Body = body;
        }
    }
}