using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Demo
{
    // Step 3: Use Dependency Injection (Select Payment Dynamically)
    public class PaymentProcessor
    {

        private readonly PaymentFactory _paymentFactory;

        public PaymentProcessor(PaymentFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }

        public void MakePayment(string gateway, decimal amount)
        {
            IPayment _payment = _paymentFactory.GetPaymentMethod(gateway);
            _payment.ProcessPayment(amount);
        }
    }
}
