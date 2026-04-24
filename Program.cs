using ConsoleApp7;
using static ConsoleApp7.Subscribers;

public class Program
{
    public static void Main()
    {

        OrderService service = new OrderService();
        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();

        service.PlacedOrder += emailService.SendEmail;
        service.PlacedOrder += smsService.SendSMS;

        Console.WriteLine("==========================================");
        Console.WriteLine("          Welcome To Order System         ");
        Console.WriteLine("==========================================");

        while (true)
        {
            Console.WriteLine("You can start ordering :) ");
            var myOrder = new Order();
            service.PlaceOrder(myOrder);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Press Enter to continue or type 'exit' to quit...");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;
        }

    }
}



