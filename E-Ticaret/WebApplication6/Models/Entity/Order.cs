using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models.Entity
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public bool OrderStatus { get; set; }       
        public DateTime OrderDate { get; set; }
        public string IdentityUserId { get; set; }  
        public IdentityUser IdentityUser { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProducQuantity { get; set; }
        public float OrderPrice { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }


    }
}
