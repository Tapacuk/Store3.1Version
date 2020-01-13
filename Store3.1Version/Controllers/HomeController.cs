using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store3._1Version.Interfaces;
using Store3._1Version.Models;

namespace Store3._1Version.Controllers
{
    public class HomeController : Controller
    {
        private IProductLogRepository productLogRepository;

        public HomeController(IProductLogRepository _productLogRepository)
        {
            productLogRepository = _productLogRepository;
        }
        public IActionResult Index()
        {
            return View(productLogRepository.ProductLogs());
        }
    }
}