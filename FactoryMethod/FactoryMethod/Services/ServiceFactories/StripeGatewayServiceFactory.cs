namespace FactoryMethod.Services.ServiceFactories
{
    public class StripeGatewayServiceFactory: AbstractPaymentGatewayServiceFactory
    {
        public override IPaymentGatewayService CreatePaymentGateway() => new StripeGatewayService();

    }
}
