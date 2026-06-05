using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
