using Microsoft.AspNetCore.Mvc;

namespace MyFitnessCompanion.Controllers
{
    public class MealPlanner : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
