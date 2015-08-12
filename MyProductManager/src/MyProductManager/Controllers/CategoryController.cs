using MyProductManager.Models;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace MyProductManager.Controllers
{
    public class CategoryController : Controller
    {
        

        public ViewResult Index()
        {
            var categories = new Category[0];

            return View(categories);
        }
         
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Edit(string id)
        {
            var category = new Category();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(category);
        }

        [ActionName("Delete")]
        public IActionResult Delete(string id)
        {
            var category = new Category();
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {

            return RedirectToAction("Index");
        }
    }
}
