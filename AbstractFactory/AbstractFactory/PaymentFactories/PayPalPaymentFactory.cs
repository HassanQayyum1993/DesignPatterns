using AbstractFactory.Services.IPaymentServices;
using AbstractFactory.Services.PayPalPaymentServices;

namespace AbstractFactory.PaymentFactories
{
    public class PayPalPaymentFactory: IPaymentFactory
    {
        public IPaymentProcessingService CreatePaymentProcessingService() => new PayPalPaymentProcessingService() as IPaymentProcessingService;
        public IRefundService CreateRefundService() => new PayPalRefundService() as IRefundService;
        public IInvoiceGeneratorService CreateInvoiceGeneratorService() => new PayPalInvoiceGeneratorService() as IInvoiceGeneratorService;
    }
}
