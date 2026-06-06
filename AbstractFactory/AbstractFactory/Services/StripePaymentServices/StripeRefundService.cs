using AbstractFactory.Services.IPaymentServices;

namespace AbstractFactory.Services.StripePaymentServices
{
    public class StripeRefundService:IRefundService
    {
        public void RefundPayment()
        {
            Console.WriteLine("Stripe Refund Payment");
        }
    }
}
