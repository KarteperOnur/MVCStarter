using Homework0705.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Homework0705.Controllers
{
    public class CategoryController : Controller
    {
        public static List<Category> categories = new List<Category>();

        public IActionResult Index()
        {
            return View(categories);
        }

        [HttpGet]
        //sayfaya yapılan isteklere cevap verir.
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //o sayfadan herhangi bir değer gönderildiğinde devreye girer.
        public IActionResult Create(Category category)
        {
            categories.Add(category);
            return RedirectToAction("Index");
        }
    }
}
