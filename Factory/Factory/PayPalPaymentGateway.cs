namespace Factory
{
    public class PayPalPaymentGateway:IPaymentGateway
    {
        public string ProcessPayment()
        {
            return "PayPal: Payment processed";
        }
    }
}
