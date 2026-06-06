using AbstractFactory.Services.IPaymentServices;
using AbstractFactory.Services.StripePaymentServices;

namespace AbstractFactory.PaymentFactories
{
    public class StripePaymentFactory:IPaymentFactory
    {
        public IPaymentProcessingService CreatePaymentProcessingService() => new StripePaymentProcessingService();
        public IRefundService CreateRefundService() => new StripeRefundService();
        public IInvoiceGeneratorService CreateInvoiceGeneratorService() => new StripeInvoiceGeneratorService();
    }
}
