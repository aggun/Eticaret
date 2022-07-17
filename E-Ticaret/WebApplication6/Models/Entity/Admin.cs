using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models.Entity
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminUsername { get; set; }
        public string AdmiMail { get; set; }
        public string AdminPassword { get; set; }
        public string AdminUstatus { get; set; }

    }
}
