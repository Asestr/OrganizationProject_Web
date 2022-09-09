using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrganizationAccsessLayer.EntityFramework;
using OrganizationBusinessLayer.Concrete;
using OrganizationBusinessLayer.ValidationRules;
using OrganizationEntityLayer.Event;

namespace OrganizationProject_Web.Controllers
{
    public class RegisterController : Controller
    {
        
        OrganizerManager om = new OrganizerManager(new EfOrganizerRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Organizer o)
        {
            OrganizerRuller orl = new OrganizerRuller();
            ValidationResult result = orl.Validate(o);

            if (result.IsValid)
            {
                o.OrganizerLoginControl = true;
                om.TAdd(o);
                return RedirectToAction("Index", "Event");
            }
            else
            {
                foreach(var item  in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
            
        }
    }
}
