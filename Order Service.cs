using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class OrderService
    {
        public event Action<Order> PlacedOrder;

        public Predicate<Order> ValidOrder = order => order.Total > 100;

        public void PlaceOrder(Order order)
        {
            Console.Write("Enter the order ID: ");
            order.Id = Console.ReadLine();

            order.products.Clear();
            Console.Write("Enter number of products: ");

            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                count = 1;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter product {i + 1} name: ");
                var name = Console.ReadLine();

                Console.Write($"Enter product {i + 1} price: ");
                int price;
                while (!int.TryParse(Console.ReadLine(), out price))
                {
                    Console.Write("Invalid price. Enter an integer value: ");
                }

                order.products.Add(new Product { Name = name, Price = price });
            }

            Console.Write("Enter your email: ");
            order.CustomerEmail = Console.ReadLine();
            order.EmailFormat();

            Console.Write("Enter your phone number: ");
            order.CustomerNumber = Console.ReadLine();
            order.PhoneNumberFormat();

            order.Total = order.products.Sum(p => p.Price);

            NotifyCustomer(order);
        }


        public void NotifyCustomer(Order order)
        {
            if (ValidOrder(order))
            {
                PlacedOrder?.Invoke(order);
            }
            else
            {
                Console.WriteLine("Order is not valid, the total should be greater than 100.");
            }
        }
    }
}
