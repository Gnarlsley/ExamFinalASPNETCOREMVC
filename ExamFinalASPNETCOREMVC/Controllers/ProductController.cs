using ExamFinalASPNETCOREMVC.Data;
using ExamFinalASPNETCOREMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamFinalASPNETCOREMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context) //connecting database context
        {
            _context = context;
        }

        public IActionResult Index(string searchString)
        {
            var products = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
            }

            ViewBag.Slug = searchString;

            return View(products.ToList());
        }
        [HttpGet]
        public IActionResult Add(int id, string Name, string Description, double Price)
        {
            var product = new Product{Id = id, Name = Name, Description = Description, Price = Price};
            if (product == null)
            {
                return RedirectToAction("Edit");
            }
            return RedirectToAction("Add", product);
        }
        [HttpPost]
        public IActionResult Add(Product new_product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(new_product);
                _context.SaveChanges();

                // Redirect to the updated product's details page or wherever you want to go next
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit", new_product);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return View();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product updatedProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(updatedProduct);
                _context.SaveChanges();

                // Redirect to the updated product's details page or wherever you want to go next
                return RedirectToAction("Index");
            }

            // If ModelState is not valid, return to the edit view with validation errors
            return View(updatedProduct);
        }
    }
}
