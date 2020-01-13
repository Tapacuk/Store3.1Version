using Store3._1Version.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store3._1Version.Interfaces
{
    public interface IProductLogRepository
    {
        void AddProductLog(ProductLog p);
        ProductLog FetchProductLog(int id);
        IEnumerable<ProductLog> ProductLogs();
    }
}
