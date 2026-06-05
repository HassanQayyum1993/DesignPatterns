using AbstractFactory.Services.IPaymentServices;

namespace AbstractFactory.Services.PayPalPaymentServices
{
    public class PayPalPaymentProcessingService: IPaymentProcessingService
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PayPal Process Payment");
        }
    }
}
