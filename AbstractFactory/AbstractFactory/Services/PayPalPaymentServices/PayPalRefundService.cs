using AbstractFactory.Services.IPaymentServices;

namespace AbstractFactory.Services.PayPalPaymentServices
{
    public class PayPalRefundService:IRefundService
    {
        public void RefundPayment()
        {
            Console.WriteLine("PayPal Refund Payment");
        }
    }
}
