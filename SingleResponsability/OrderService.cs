using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    public class OrderService
    {
        private readonly NotificationService notificationService;
        public OrderService(NotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public async Task Add(Order order)
        {
            var message = new MailMessage(order.Email, "Este es el cuerpo del mail.\nUn cuerpo interesante...");
            await this.notificationService.SendEmail(message);
        }
        
    }
}
