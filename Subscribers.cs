using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Subscribers
    {
        internal class EmailService
        {

            public void SendEmail(Order order)
            {
                Console.WriteLine("----------------------------------------");
                if (order == null) throw new ArgumentNullException(nameof(order));

                Console.WriteLine($"Email sent to {order.CustomerEmail}");
                Console.WriteLine("Your order has been placed successfully.");
                order.OrderMassage = order.FormatOrderMessage();
                Console.WriteLine(order.OrderMassage);
                Console.WriteLine("Thank you for shopping with us!");
            }
        }

        internal class SMSService
        {
            public void SendSMS(Order order)
            {
                Console.WriteLine("----------------------------------------");
                if (order == null) throw new ArgumentNullException(nameof(order));

                Console.WriteLine($"SMS sent to {order.CustomerNumber}");
                Console.WriteLine("Your order has been placed successfully.");
                order.OrderMassage = order.FormatOrderMessage();
                Console.WriteLine(order.OrderMassage);
                Console.WriteLine("Thank you for shopping with us!");
            }
        }
    }
}
