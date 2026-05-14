using FactoryMethod.Services.ServiceFactories;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentGatewayController : ControllerBase
    {

        private readonly ILogger<PaymentGatewayController> _logger;

        public PaymentGatewayController(ILogger<PaymentGatewayController> logger)
        {
            _logger = logger;
        }

        [HttpPost("ProcessPayPalPayment")]
        public IActionResult ProcessPayPalPayment()
        {
            AbstractPaymentGatewayServiceFactory factory = new PayPalGatewayServiceFactory();
            
            return Ok(factory.ProcessPayment());
        }

        [HttpPost("ProcessStripePayment")]
        public IActionResult ProcessStripePayment()
        {
            AbstractPaymentGatewayServiceFactory factory = new StripeGatewayServiceFactory();

            return Ok(factory.ProcessPayment());
        }
    }
}
