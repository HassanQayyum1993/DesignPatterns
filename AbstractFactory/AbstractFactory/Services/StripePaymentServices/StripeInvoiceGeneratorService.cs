using AbstractFactory.Services.IPaymentServices;

namespace AbstractFactory.Services.StripePaymentServices
{
    public class StripeInvoiceGeneratorService : IInvoiceGeneratorService
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Stripe Generate Invoice");
        }
    }
}
