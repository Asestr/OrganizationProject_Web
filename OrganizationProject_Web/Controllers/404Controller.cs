using Microsoft.AspNetCore.Mvc;

namespace OrganizationProject_Web.Controllers
{
    public class _404Controller : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
