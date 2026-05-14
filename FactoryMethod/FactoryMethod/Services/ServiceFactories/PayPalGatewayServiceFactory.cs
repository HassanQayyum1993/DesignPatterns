using System.Reflection.Metadata.Ecma335;

namespace FactoryMethod.Services.ServiceFactories
{
    public class PayPalGatewayServiceFactory:AbstractPaymentGatewayServiceFactory
    {
        public override IPaymentGatewayService CreatePaymentGateway() => new PaypalGatewayService(); 
    }
}
