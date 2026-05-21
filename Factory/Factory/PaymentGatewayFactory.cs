namespace Factory
{
    public class PaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway(string input)
        {
            switch (input)
            {
                case "PayPal":
                    return new PayPalPaymentGateway();
                case "Pioneer":
                    return new PioneerPaymentGateway();
                default:
                    throw new ArgumentException($"Unsupported payment gateway: {input}");
            }
        }
    }
}
