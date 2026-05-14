namespace FactoryMethod.Services
{
    public class PaypalGatewayService: IPaymentGatewayService
    {
        public string Charge()
        {
            return "Paypal: Charged";
        }
    }
}
