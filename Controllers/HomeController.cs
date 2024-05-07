using Homework0705.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework0705.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
