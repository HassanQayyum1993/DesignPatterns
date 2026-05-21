namespace Factory
{
    public class PioneerPaymentGateway:IPaymentGateway
    {
        public string ProcessPayment()
        {
            return "Pioneer: Payment processed";
        }

    }
}
