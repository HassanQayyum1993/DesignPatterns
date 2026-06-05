using AbstractFactory.Services.IPaymentServices;
using AbstractFactory.Services.PayPalPaymentServices;

namespace AbstractFactory.PaymentFactories
{
    public class StripePaymentFactory
    {
        public IPaymentProcessingService CreatePaymentProcessingService() => new StripePaymentProcessingService();
        public IRefundService CreateRefundService() => new StripeRefundService();
        public IInvoiceGeneratorService CreateInvoiceGeneratorService() => new StripeInvoiceGeneratorService();
    }
}
