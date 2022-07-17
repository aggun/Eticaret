using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Data;
using WebApplication6.Models.Entity;

namespace WebApplication6.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        public readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var productvalues = _context.Products.OrderBy(x => x.ProductPrice).ToList();
            return View(productvalues);
        }
        [AllowAnonymous]
        public IActionResult ProductByCategory(int id)
        {
            var productvalues = _context.Products.Where(x => x.CategoryId == id).ToList();
            return View(productvalues);
        }
        public IActionResult MyOrders()
        {
            var userinfo = User.Identity.Name;
            ViewBag.info = userinfo;
            var userid = _context.Users.Where(x => x.UserName == userinfo).Select(y => y.Id).FirstOrDefault();
            var ordervalues = _context.Orders.Include(x => x.Product).Include(y => y.Bank)
                .Include(t => t.IdentityUser).Where(w => w.IdentityUser.Id == userid).OrderBy(z => z.OrderDate).ToList();
            return View(ordervalues);
        }
        [HttpGet]
        public ActionResult AddOrder(int id)
        {
            List<SelectListItem> SelectBank = (from x in _context.Banks.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.BankName,
                                                   Value = x.BankId.ToString()
                                               }).ToList();
            ViewBag.bank = SelectBank;

            //    var selectquantity = _context.Products.Where(x => x.ProductId == id).Select(y => y.ProductQuantity).FirstOrDefault();
            //   List<SelectListItem> pr = new List<SelectListItem>();

            return View();

        }
        [HttpPost]
        public ActionResult AddOrder(Order order, Product product, int id, IFormCollection datas)
        {
            int qnt = Convert.ToInt32(datas["Txtqnt"]);
            var userinfo = User.Identity.Name;
            var userid = _context.Users.Where(x => x.UserName == userinfo).Select(y => y.Id).FirstOrDefault();
            order.OrderPrice = _context.Products.Where(x => x.ProductId == id).Select(y => y.ProductPrice).FirstOrDefault() * qnt;
         //   product.ProductQuantity = _context.Products.Where(x => x.ProductId == id).Select(y => y.ProductQuantity).FirstOrDefault() - qnt;
            order.ProductId = id;
            order.ProducQuantity = qnt;
            order.OrderDate = DateTime.Now;
            order.IdentityUserId = userid;
            _context.Orders.Add(order);
            _context.SaveChanges();
            return RedirectToAction("MyOrders", "User");
        }

    }
}
