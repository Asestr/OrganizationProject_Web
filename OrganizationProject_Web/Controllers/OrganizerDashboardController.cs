using Microsoft.AspNetCore.Mvc;

namespace OrganizationProject_Web.Controllers
{
    public class OrganizerDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
