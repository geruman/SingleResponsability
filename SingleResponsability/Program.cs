using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient smtp = new SmtpClient();
            NotificationService ns = new NotificationService(smtp);
            OrderService os = new OrderService(ns);

            os.Add(new Order("german@nowhere.com"));
            os.Add(new Order("german2@nowhere.com"));
            os.Add(new Order("german3@nowhere.com"));
            Console.ReadKey();
        }
    }
}
