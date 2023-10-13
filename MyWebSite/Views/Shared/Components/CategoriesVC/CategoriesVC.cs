using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MyWebSite.Models;

namespace MyWebSite.Views.Shared.Components.CategoriesVC
{
    public class CategoriesVC:ViewComponent
    {
        private readonly ETradeDbContext context;

        public CategoriesVC(ETradeDbContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var model = context.Categories.ToList();
            return View("_categoryVC",model);
        }
    }
}
