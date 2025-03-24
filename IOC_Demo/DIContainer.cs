using Microsoft.Extensions.DependencyInjection;

namespace IOC_Demo
{
    public static class DIContainer
    {
        public static ServiceProvider SetupDIContainer()
        {
            // 1. Create a service collection. (using Microsoft.Extensions.DependencyInjection;)
            // ServiceCollection is the core of the DI container.
            var services = new ServiceCollection();

            // 2. Register your services.
            services.AddSingleton<RazorpayPayment>(); // or AddSingleton, AddTransient
            services.AddSingleton<StripePayment>(); // or AddSingleton, AddTransient
            services.AddSingleton<PayPalPayment>(); // or AddSingleton, AddTransient
            services.AddSingleton<PaymentFactory>(); // or AddSingleton, AddTransient
            services.AddSingleton<PaymentProcessor>(); // or AddSingleton, AddTransient


            // 3. Build the service provider.
            //services.BuildServiceProvider() builds the service provider, which is responsible for resolving services.
            return services.BuildServiceProvider();
        }
    }
}
