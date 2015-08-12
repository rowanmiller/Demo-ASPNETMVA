//using Microsoft.AspNet.Mvc;
//using Microsoft.AspNet.Mvc.Rendering;
//using Microsoft.Data.Entity;
//using MyProductManager.Models;
//using System.Linq;

//namespace MyProductManager.Controllers
//{
//    public class ProductController : Controller
//    {
//        private ProductContext _context;

//        public ProductController(ProductContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            var products = _context.Products
//                .OrderBy(c => c.DisplayName)
//                .ToArray();

//            return View(products);
//        }

//        public IActionResult Create()
//        {
//            ViewBag.CategoryId = new SelectList(_context.Categories, "CategoryId", "DisplayName");
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create(Product product)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Products.Add(product);
//                _context.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(product);
//        }
//    }
//}
