using Microsoft.AspNetCore.Mvc;
using OrganizationAccsessLayer.EntityFramework;
using OrganizationBusinessLayer.Concrete;

namespace OrganizationProject_Web.Controllers
{
    public class EventController : Controller
    {
        EventManager em = new EventManager(new EfEventRepository());
        public IActionResult Index()
        {
           var values = em.GetListEventWithOrganizer();
            return View(values);
        }

        public IActionResult EventDetails(int id)
        {
            return View();
        }
    }
}
