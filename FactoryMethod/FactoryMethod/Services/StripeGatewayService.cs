namespace FactoryMethod.Services
{
    public class StripeGatewayService:IPaymentGatewayService
    {
        public string Charge()
        {
            return "Stripe: Charged";
        }
    }
}
