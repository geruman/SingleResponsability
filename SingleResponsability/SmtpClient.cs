using System;
using System.Threading.Tasks;

namespace SingleResponsability
{
    public class SmtpClient
    {
        public async Task<string> SendMailAsync(MailMessage message)
        {
            Console.WriteLine(message.Head);
            Console.WriteLine(message.Body);
            Random rand = new Random();
            await Task.Delay(rand.Next(1001));
            return "ok";
        }
    }
    
}