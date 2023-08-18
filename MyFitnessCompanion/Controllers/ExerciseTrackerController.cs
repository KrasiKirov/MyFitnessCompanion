using Microsoft.AspNetCore.Mvc;

namespace MyFitnessCompanion.Controllers
{
    public class ExerciseTrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
