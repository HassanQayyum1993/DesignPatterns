using AbstractFactory.Services.IPaymentServices;

namespace AbstractFactory.Services.PayPalPaymentServices
{
    public class PayPalInvoiceGeneratorService: IInvoiceGeneratorService
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("PayPal Generate Invoice");
        }
    }
}
