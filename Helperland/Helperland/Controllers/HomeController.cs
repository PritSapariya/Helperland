using Helperland.Data;
using Helperland.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HelperlandContext _DBContext;

        public HomeController(ILogger<HomeController> logger, HelperlandContext DBContext)
        {
            _DBContext = DBContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Prices()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult UserSignUp()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost] 
        public IActionResult UserSignUp(User user)
        {
            user.UserTypeId = 1; // 1 for all Cutomers

            if(String.IsNullOrEmpty(user.FirstName))
            {
                ModelState.AddModelError("FirstName", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.LastName))
            {
                ModelState.AddModelError("LastName", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.Email))
            {
                ModelState.AddModelError("Email", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.Mobile))
            {
                ModelState.AddModelError("Mobile", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                ModelState.AddModelError("Password", "Empty is not allowed");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _DBContext.Users.Add(user);
                    _DBContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return RedirectToAction("Faq");
                }

            }
            return View();
        }
        public IActionResult ServiceProviderSignUp()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult ServiceProviderSignUp(User user)
        {
            user.UserTypeId = 2; // 2 for all Service Providers

            if (String.IsNullOrEmpty(user.FirstName))
            {
                ModelState.AddModelError("FirstName", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.LastName))
            {
                ModelState.AddModelError("LastName", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.Email))
            {
                ModelState.AddModelError("Email", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.Mobile))
            {
                ModelState.AddModelError("Mobile", "Empty is not allowed");
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                ModelState.AddModelError("Password", "Empty is not allowed");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _DBContext.Users.Add(user);
                    _DBContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return RedirectToAction("Faq");
                }

            }
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User user)
        {
            return RedirectToAction("Index");
        }
        
        
        // FOR DEBUGGING PURPOSE
        public IActionResult List()
        {
            List<User> users = _DBContext.Users.ToList();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
