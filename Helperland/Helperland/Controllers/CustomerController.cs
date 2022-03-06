using Helperland.Utilities;
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
        [SessionHelper(UserTypeID: 1, returnUrl: "/Customer/Index")]
        public IActionResult Index()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");                 

            return View();
        }

        [SessionHelper(UserTypeID: 1, returnUrl: "/Customer/ServiceHistory")]
        public IActionResult ServiceHistory ()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            return View();
        }
    }
}
