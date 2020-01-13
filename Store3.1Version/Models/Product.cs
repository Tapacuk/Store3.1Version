using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store3._1Version.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsSold { get; set; } = false;
        public bool IsReturned { get; set; } = false;
        public IEnumerable<ProductLog> productLogs { get; set; }
    }
}
