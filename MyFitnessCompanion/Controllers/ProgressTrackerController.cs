using Microsoft.AspNetCore.Mvc;

namespace MyFitnessCompanion.Controllers
{
    public class ProgressTrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
