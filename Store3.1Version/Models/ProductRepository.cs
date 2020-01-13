using Store3._1Version.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store3._1Version.Models
{
    public class ProductRepository : IProductRepository
    {
        private StoreContext storeContext;

        public ProductRepository(StoreContext _storeContext)
        {
            storeContext = _storeContext;
        }

        public void AddProduct(Product p)
        {
            storeContext.Products.Add(p);
            storeContext.SaveChanges();
        }

        public Product FetchProduct(int id)
        {
            return storeContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public void RemoveProduct(Product p)
        {
            storeContext.Products.Remove(p);
            storeContext.SaveChanges();
        }

        public void UpdateProduct(Product p)
        {
            storeContext.Products.Update(p);
            storeContext.SaveChanges();
        }

        public IEnumerable<Product> Products() => storeContext.Products;
    }
}
