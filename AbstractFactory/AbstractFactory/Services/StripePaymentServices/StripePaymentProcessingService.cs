using AbstractFactory.Services.IPaymentServices;

namespace AbstractFactory.Services.StripePaymentServices
{
    public class StripePaymentProcessingService : IPaymentProcessingService
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Stripe Process Payment");
        }
    }
}
