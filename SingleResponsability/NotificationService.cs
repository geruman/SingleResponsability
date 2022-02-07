using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    public class NotificationService
    {
        private readonly SmtpClient smtpClient;
        public NotificationService(SmtpClient smtpClient)
        {
            this.smtpClient = smtpClient;
        }
        public async Task SendEmail(MailMessage message)
        {
            await smtpClient.SendMailAsync(message);
        }
    }
}
