using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication6.Data;

namespace WebApplication6.Models.Entity
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public string BankName { get; set; }
        public double BankValue { get; set; }
        public List<Order> Orders { get; set; }
    }
}
