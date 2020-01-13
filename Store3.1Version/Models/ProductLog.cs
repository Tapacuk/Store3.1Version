using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store3._1Version.Models
{
    public class ProductLog
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
