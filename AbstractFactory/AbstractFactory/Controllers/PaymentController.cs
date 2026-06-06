using AbstractFactory.PaymentFactories;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult ProcessPayment(string paymentMethod)
        {
            IPaymentFactory paymentFactory;

            switch (paymentMethod)
            {
                case "Stripe":
                    paymentFactory = new StripePaymentFactory();
                    break;
                case "PayPal":
                    paymentFactory = new PayPalPaymentFactory();
                    break;
                default:
                    return BadRequest("Invalid payment method");
            }

            paymentFactory.CreatePaymentProcessingService().ProcessPayment();
            paymentFactory.CreateInvoiceGeneratorService().GenerateInvoice();

            return View();
        }
    }
}
