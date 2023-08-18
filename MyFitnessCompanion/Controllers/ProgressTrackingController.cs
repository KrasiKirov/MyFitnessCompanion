using Microsoft.AspNetCore.Mvc;

namespace MyFitnessCompanion.Controllers
{
    public class ProgressTrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
