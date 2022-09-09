using Microsoft.AspNetCore.Mvc;
using OrganizationAccsessLayer.EntityFramework;
using OrganizationBusinessLayer.Concrete;

namespace OrganizationProject_Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
