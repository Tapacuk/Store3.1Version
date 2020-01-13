using Store3._1Version.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store3._1Version.Models
{
    public class ProductLogRepository : IProductLogRepository
    {
        private StoreContext storeContext;

        public ProductLogRepository(StoreContext _storeContext)
        {
            storeContext = _storeContext;
        }

        public void AddProductLog(ProductLog p)
        {
            storeContext.ProductLogs.Add(p);
        }

        public ProductLog FetchProductLog(int id)
        {
            return storeContext.ProductLogs.Where(p => p.ProductId == id).FirstOrDefault();
        }

        public IEnumerable<ProductLog> ProductLogs() => storeContext.ProductLogs;
    }
}
