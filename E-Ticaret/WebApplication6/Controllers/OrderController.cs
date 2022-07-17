using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication6.Data;

namespace WebApplication6.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        public readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          //  var userinfo = User.Identity.Name;
          //  ViewBag.info = userinfo;
         // var userid=  _context.Users.Where(x => x.UserName == userinfo).Select(y => y.Id).FirstOrDefault();
            var ordervalues = _context.Orders.Include(x => x.Product).Include(y=>y.Bank)
                .Include(t=>t.IdentityUser).OrderBy(z => z.OrderDate).ToList();
            return View(ordervalues);            
        }
        public ActionResult ChangeStatusOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderId == id);
            if (order.OrderStatus == false)
            {
                order.OrderStatus = true;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Order");
        }
    }
}
