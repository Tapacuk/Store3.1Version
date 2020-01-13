using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store3._1Version.Interfaces;
using Store3._1Version.Models;

namespace Store3._1Version.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        private readonly IProductLogRepository productLogRepository;
        public ProductController(IProductRepository _productRepository, IProductLogRepository _productLogRepository)
        {
            productRepository = _productRepository;
            productLogRepository = _productLogRepository;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(productRepository.Products());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new Product());
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            productRepository.AddProduct(product);
            productLogRepository.AddProductLog(new ProductLog()
            {
                Description = "Product Added",
                Date = DateTime.Now,
                ProductId = product.Id,
                Product = product
            });
            return RedirectToAction("Index", "Home");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var p = productRepository.FetchProduct(id);
            return View(p);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            var p = productRepository.FetchProduct(id);
            p.Name = product.Name;
            p.Price = product.Price;
            p.productLogs = product.productLogs;
            p.IsReturned = product.IsReturned;
            p.IsSold = product.IsSold;
            productRepository.UpdateProduct(p);
            return RedirectToAction("Index", "Home");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}