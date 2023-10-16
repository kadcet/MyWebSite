using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;
using System.Diagnostics;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ETradeDbContext _context;

        public HomeController(ETradeDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var model=_context.Products.ToList();
            return View(model);
        }
       
    }
}