using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescripton { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }


    }
}
