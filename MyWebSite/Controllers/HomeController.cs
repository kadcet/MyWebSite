using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;
using System.Diagnostics;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

       
    }
}