using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models.Entity
{
    public class Product
    {
        
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescripton { get; set; }
        public int ProductQuantity { get; set; }
        public float ProductPrice { get; set; }
        public bool ProductStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Order> Orders { get; set; }
    }
}
