using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {

        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ProcessPayment")]
        public IActionResult ProcessPayment(string gatewayType)
        {
            try
            {
                PaymentGatewayFactory gatewayFactory = new PaymentGatewayFactory();
                IPaymentGateway paymentGateway = gatewayFactory.CreatePaymentGateway(gatewayType);
                return Ok(paymentGateway.ProcessPayment());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Payment processing failed");
            }
        }
    }
}
