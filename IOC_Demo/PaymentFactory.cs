using Microsoft.Extensions.DependencyInjection;

namespace IOC_Demo
{
    public class PaymentFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public PaymentFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPayment GetPaymentMethod(string gateway)
        {
            return gateway switch
            {
                "1" => _serviceProvider.GetRequiredService<StripePayment>(),
                "2" => _serviceProvider.GetRequiredService<RazorpayPayment>(),
                "3" => _serviceProvider.GetRequiredService<PayPalPayment>(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
