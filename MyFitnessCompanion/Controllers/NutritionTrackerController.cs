using Microsoft.AspNetCore.Mvc;

namespace MyFitnessCompanion.Controllers
{
    public class NutritionTrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
