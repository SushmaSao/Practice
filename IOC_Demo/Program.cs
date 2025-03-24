using Microsoft.Extensions.DependencyInjection;

namespace IOC_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IOC demo using DI container");

            var serviceProvider = DIContainer.SetupDIContainer();

            string input;
            do
            {
                Console.WriteLine("Enter amount:");
                try
                {
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Select payment method:");
                    Console.WriteLine("1. Stripe");
                    Console.WriteLine("2. Razorpay");
                    Console.WriteLine("3. Paypal");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                        case "2":
                        case "3":
                            PaymentProcessor paymentProcessor = serviceProvider.GetRequiredService<PaymentProcessor>();
                            paymentProcessor?.MakePayment(option, amount);
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid amount");
                }
                finally
                {
                    input = Retry();
                }

            } while (input.ToLower() != "q");
        }


        private static string Retry()
        {
            Console.WriteLine("Press 'q' to quit, or any other key to continue.");
            return Console.ReadLine();
        }




    }
}
