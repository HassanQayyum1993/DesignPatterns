using AbstractFactory.Services.IPaymentServices;
using AbstractFactory.Services.PayPalPaymentServices;

namespace AbstractFactory.PaymentFactories
{
    public class PayPalPaymentFactory: IPaymentFactory
    {
        public IPaymentProcessingService CreatePaymentProcessingService() => new PayPalPaymentProcessingService();
        public IRefundService CreateRefundService() => new PayPalRefundService();
        public IInvoiceGeneratorService CreateInvoiceGeneratorService() => new PayPalInvoiceGeneratorService();
    }
}
