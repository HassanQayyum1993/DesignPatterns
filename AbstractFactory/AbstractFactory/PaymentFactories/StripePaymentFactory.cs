using AbstractFactory.Services.IPaymentServices;
using AbstractFactory.Services.PayPalPaymentServices;

namespace AbstractFactory.PaymentFactories
{
    public class StripePaymentFactory:IPaymentFactory
    {
        public IPaymentProcessingService CreatePaymentProcessingService() => new StripePaymentProcessingService() as IPaymentProcessingService;
        public IRefundService CreateRefundService() => new StripeRefundService() as IRefundService;
        public IInvoiceGeneratorService CreateInvoiceGeneratorService() => new StripeInvoiceGeneratorService() as IInvoiceGeneratorService;
    }
}
