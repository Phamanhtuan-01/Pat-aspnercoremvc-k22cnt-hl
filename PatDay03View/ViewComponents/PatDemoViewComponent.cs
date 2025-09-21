using Microsoft.AspNetCore.Mvc;
using PatDay03View.Models;

namespace PatDay03View.ViewComponents
{
    public class PatDemoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Category> categories = new List<Category>
            {
                new Category {Id=1,Name="Điện tử" },
                new Category {Id=2,Name="Điện Lạnh"},

                new Category {Id=3,Name="Đồ gia dụng"},
                new Category {Id=4,Name="Tiện ích"},
            };
            return View(categories);
        }
    }
}