using Microsoft.AspNetCore.Mvc;
using MyFitnessCompanion.Models;  // replace this with the actual path to your models

namespace MyFitnessCompanion.Controllers
{
    public class GoalSettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitGoal()
        {
            if (!ModelState.IsValid)
            {
                return View("Index");// returns the initial view with the submitted data
            }

            // Save goal and do other work here...

            // Redirect back to Index (or another page) on success
            return RedirectToAction("Index");
        }
    }
}
