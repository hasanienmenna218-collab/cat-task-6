using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal static class Format_Extentions
    {
            public static string FormatOrderMessage(this Order order)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Order ID: {order.Id}");
              
                sb.AppendLine("Products:");
                foreach (var product in order.products)
                {
                    sb.AppendLine($"- {product.Name}: ${product.Price}");
                }
                Console.WriteLine("-----------------------------------");
                sb.AppendLine($"Total: ${order.Total}");
                return sb.ToString();
            }

            public static string EmailFormat(this Order order)
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                while (string.IsNullOrEmpty(order.CustomerEmail) ||
                       !Regex.IsMatch(order.CustomerEmail, emailPattern))
                {
                    Console.Write("Invalid email format. Please enter a valid email: ");
                    order.CustomerEmail = Console.ReadLine();
                }
                return order.CustomerEmail;
            }

            public static string PhoneNumberFormat(this Order order)
            {

                string phonePattern = @"^\+?\d{7,15}$";
                while (string.IsNullOrEmpty(order.CustomerNumber) ||
                       !Regex.IsMatch(order.CustomerNumber, phonePattern))
                {
                    Console.Write("Invalid phone number. Please enter a valid phone number (digits, optional +): ");
                    order.CustomerNumber = Console.ReadLine();
                }
                return order.CustomerNumber;
            }
        
    }
}
