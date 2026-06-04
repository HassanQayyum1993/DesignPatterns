using AbstractFactory.Services.IPaymentServices;

namespace AbstractFactory.PaymentFactories
{
    public interface IPaymentFactory
    {
        IPaymentProcessingService CreatePaymentProcessingService();
        IRefundService CreateRefundService();
        IInvoiceGeneratorService CreateInvoiceGeneratorService();
    }
}
