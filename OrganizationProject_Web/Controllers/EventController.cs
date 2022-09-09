using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using OrganizationAccsessLayer.Abstract;
using OrganizationAccsessLayer.EntityFramework;
using OrganizationBusinessLayer.Concrete;
using OrganizationBusinessLayer.ValidationRules;
using OrganizationEntityLayer.Event;

namespace OrganizationProject_Web.Controllers
{
    [AllowAnonymous]
    public class EventController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        EventManager em = new EventManager(new EfEventRepository());
        public IActionResult Index()
        {
            var values = em.GetListEventWithOrganizer();

            return View(values);

            //var valuesa = em.GetListEventWithCategory();
            //return View(valuesa);
        }



        public IActionResult EventDetails(int id)
        {
            return View();
        }


        public IActionResult GetListByOrganizer()
        {
            var values = em.GetEventListCategoryByOrganizer(1);
            return View(values);

        }
        [HttpGet]
        public IActionResult EventADD()
        {
            //CityManager cim = new CityManager(new EfCityRepository());
            //List<SelectListItem> cityValues = (from x in cim.GetList()
            //                                   select new SelectListItem
            //                                   {
            //                                       Text = x.CityName,
            //                                       Value = x.CityID.ToString()
            //                                   }).ToList();

            //ViewBag.civ = cityValues;

            
            List<SelectListItem> categoryValues = (from x in cm
                                                   .GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryValues;




            return View();
        }
        [HttpPost]
        public IActionResult EventADD(Event p)
        {
            EventValidation ev = new EventValidation();
            ValidationResult result = ev.Validate(p);

            if (result.IsValid)
            {
                p.EventStatus = true;
                p.EventTickedOrNotTicked = true;
                p.EventStartTime = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.OrganizerID = 1;
                em.TAdd(p);
                return RedirectToAction("GetListByOrganizer", "Event");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }


        public IActionResult EventDelete(int id)
        {
            var eventValue = em.GetByID(id);
            em.TDelete(eventValue);
            return RedirectToAction("GetListByOrganizer");
        }
        [HttpGet]
        public IActionResult EditEvent(int id) 
        {
            var eventvalue = em.GetByID(id);
            List<SelectListItem> categoryValues = (from x in cm
                                                   .GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryValues;
            return View(eventvalue); 
        }
        [HttpPost]
        public IActionResult EditEvent(Event p)
        {
            p.EventStatus = true;
            p.EventTickedOrNotTicked = true;
            p.EventStartTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.OrganizerID = 1;
            em.TUpdate(p);
            return RedirectToAction("GetListByOrganizer");
        }
    }
}
