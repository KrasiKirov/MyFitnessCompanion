using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFitnessCompanion.Controllers
{
    public class MealPlannerController : Controller
    {
        // GET: MealPlannerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MealPlannerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MealPlannerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MealPlannerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MealPlannerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MealPlannerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MealPlannerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MealPlannerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
