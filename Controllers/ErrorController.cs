using Microsoft.AspNetCore.Mvc;

namespace HW3.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/404")]
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
