using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrganizationAccsessLayer.Concrete;
using OrganizationEntityLayer.Event;
using System.Security.Claims;

namespace OrganizationProject_Web.Controllers
{
    
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult>  Index(Organizer p)
        {
            Context c = new Context();
            var datavalue = c.Organizers.FirstOrDefault(x => x.OrganizerMail == p.OrganizerMail && x.OrganizerPassword == p.OrganizerPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.OrganizerMail)
                };
                var useridentity = new ClaimsIdentity(claims, "o");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Organizer");
            }
            else
            {
                return View();
            }
            
        }

        //Context c = new Context();
        //   var datavalue = c.Organizers.FirstOrDefault(x => x.OrganizerMail == p.OrganizerMail && x.OrganizerPassword == p.OrganizerPassword);
           //if (datavalue != null)
           //{
           //    HttpContext.Session.SetString("username", p.OrganizerMail);
           //    return RedirectToAction("Index", "Organizer");
           //}
           //return View();

    }
}
