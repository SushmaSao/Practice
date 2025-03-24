namespace IOC_Demo
{
    // Step 1: Define an Interface
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }

    // Step 2: Implement Payment Methods
    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(decimal amount) => Console.WriteLine($"Paid {amount} via PayPal. ");
    }

    public class StripePayment : IPayment
    {
        public void ProcessPayment(decimal amount) => Console.WriteLine($"Paid {amount} via Stripe.");
    }

    public class RazorpayPayment : IPayment
    {
        public void ProcessPayment(decimal amount) => Console.WriteLine($"Paid {amount} via Razorpay.");
    }


}
