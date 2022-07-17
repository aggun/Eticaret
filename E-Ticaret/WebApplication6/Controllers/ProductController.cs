using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication6.Data;
using WebApplication6.Models.Entity;

namespace WebApplication6.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        public readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productvalues = _context.Products.Include(x => x.Category)
              .OrderBy(y => y.CategoryId).ToList();
            return View(productvalues);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> productcategory = (from x in _context.Categories.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryId.ToString()
                                                    }).ToList();
            ViewBag.vlc = productcategory;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            product.ProductStatus = true;
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
        public ActionResult ChangeStatusProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == id);
            if (product.ProductStatus == false)
            {
                product.ProductStatus = true;
            }
            else
            {
                product.ProductStatus = false;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
        public ActionResult DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == id);
            _context.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> productcategory = (from x in _context.Categories.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryId.ToString()
                                                    }).ToList();
            ViewBag.vlc = productcategory;
            var deger = _context.Products.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}
