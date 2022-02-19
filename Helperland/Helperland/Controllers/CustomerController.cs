using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag._id = HttpContext.Session.GetString("_id");
            ViewBag.email = HttpContext.Session.GetString("email");                 

            if (ViewBag._id == null)
            {
                return RedirectToAction("LoginRedirect", "Home");
            }
            return View();
        }
    }
}
