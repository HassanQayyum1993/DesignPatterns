namespace FactoryMethod.Services.ServiceFactories
{
    public abstract class AbstractPaymentGatewayServiceFactory
    {
        public abstract IPaymentGatewayService CreatePaymentGateway();

        public string ProcessPayment()
        {
            var paymentGateway = CreatePaymentGateway();
            return paymentGateway.Charge();
        }
    }
}
