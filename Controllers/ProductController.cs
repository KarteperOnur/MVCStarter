using Homework0705.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Homework0705.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>();

        // GET: ProductController
        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        // GET: ProductController/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");
        }


    }
}
