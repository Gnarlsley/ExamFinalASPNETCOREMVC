using ExamFinalASPNETCOREMVC.Data;
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
            return View(products.ToList());
        }
    }
}
