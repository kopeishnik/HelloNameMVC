using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HelloNameMVC.Models;

namespace HelloNameMVC.Controllers
{
    [Controller]
    public class HomeControllerOlexandr : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        public IActionResult Index(NameViewModel name)
        {
            return View("HelloName", name);
        }
        public IActionResult Privacy()
        {
            return View("Privacy");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
