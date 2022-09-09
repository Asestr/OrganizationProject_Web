using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OrganizationProject_Web.Controllers
{
    public class OrganizerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrganizerProfile()
        {
            return View();
        }

        public IActionResult OrganizerMail()
        {
            return View();
        }

        public IActionResult OrganizerEventCreate()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult organizerPartialNavBar()
        {
            return PartialView();

        }

        [AllowAnonymous]
        public PartialViewResult organizerPartialFooter()
        {
            return PartialView();

        }
    }
}
