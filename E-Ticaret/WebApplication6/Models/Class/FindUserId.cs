using System.Linq;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Models.Class
{
    public class FindUserId
    {
        public readonly ApplicationDbContext _context;
        public FindUserId(ApplicationDbContext context)
        {
            _context = context;
        }
        public void GetUserInfo()
        { 
       // var userinfo = User.Identity.Name;
      //  var userid = _context.Users.Where(x => x.UserName == userinfo).Select(y => y.Id).FirstOrDefault();


        }
    }
}
