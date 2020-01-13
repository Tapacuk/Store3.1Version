using Store3._1Version.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store3._1Version.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product p);
        void RemoveProduct(Product p);
        void UpdateProduct(Product p);
        Product FetchProduct(int id);
        IEnumerable<Product> Products();
    }
}
