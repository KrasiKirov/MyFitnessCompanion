using Microsoft.AspNetCore.Mvc;

namespace MyFitnessCompanion.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
