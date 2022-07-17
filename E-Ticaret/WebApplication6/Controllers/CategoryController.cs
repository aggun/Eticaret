using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication6.Data;
using WebApplication6.Models.Entity;

namespace WebApplication6.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var degerler = _context.Categories.ToList();
            return View(degerler);
        }
        public IActionResult Test()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _context.Categories.Add(category);
            category.CategoryStatus = true;
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
        public ActionResult ChangeStatusCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category.CategoryStatus == false)
            {
                category.CategoryStatus = true;
            }
            else
            {
                category.CategoryStatus = false;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
        public ActionResult DeleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            _context.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var deger = _context.Categories.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
    }
}
