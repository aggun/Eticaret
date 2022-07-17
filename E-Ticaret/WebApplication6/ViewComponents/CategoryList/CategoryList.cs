using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication6.Data;

namespace WebApplication6.ViewComponents.CategoryList
{
    public class CategoryList : ViewComponent
    {
        public readonly ApplicationDbContext _context;
        public CategoryList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var categoryvalues = _context.Categories.ToList();
            return View(categoryvalues);
        }
    }
}
