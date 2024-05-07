using Homework0705.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework0705.Controllers
{
    public class SupplierController : Controller
    {
        public static List<Supplier> suppliers = new List<Supplier>();

        public IActionResult Index()
        {
            return View(suppliers);
        }

        [HttpGet]
        //sayfaya yapılan isteklere cevap verir.
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //o sayfadan herhangi bir değer gönderildiğinde devreye girer.
        public IActionResult Create(Supplier supplier)
        {
            suppliers.Add(supplier);
            return RedirectToAction("Index");
        }
    }
}

