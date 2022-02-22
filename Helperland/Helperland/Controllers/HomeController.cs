using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel;
using Helperland.Repository.IRepository;
using Helperland.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Helperland.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserRegistrationRepository _userRegistrationRepository;
        private readonly LoginRepository _loginRepository;

        public HomeController ( ILogger<HomeController> logger,
                              IUserRegistrationRepository userRegistrationRepository,
                              ILoginRepository loginRepository )
        {
            _logger = logger;
            this._userRegistrationRepository = (UserRegistrationRepository)userRegistrationRepository;
            this._loginRepository = (LoginRepository)loginRepository;
        }

        public IActionResult Index ()
        {
            return View();
        }
        public IActionResult About ()
        {
            return View();
        }
        public IActionResult Prices ()
        {
            return View();
        }
        public IActionResult Contact ()
        {
            return View();
        }
        public IActionResult Faq ()
        {
            return View();
        }
        public IActionResult LoginRedirect (string returnurl)
        {
            return RedirectToAction("Index", "Home", new { isLoginOpen = "true", returnurl = returnurl });
        }
        public IActionResult UserRegistration ()
        {
            return View();
        }
        
        [HttpPost] 
        public IActionResult UserRegistration (UserRegistrationViewModel userRegistrationViewModel)
        {
            ViewBag.HasError = false;
            ViewBag.Success = false;
            ViewBag.ErrorMessage = "Please enter valid details";
            ViewBag.SuccessMessage = "User is successfully registered!";
            /*int userTypeId = class.customerTypeId;*/     // 1 is for user(Customer type) .....
            int userTypeId = 1;

            if (ModelState.IsValid)
            {
                if (_userRegistrationRepository.AddUser(userRegistrationViewModel, userTypeId))
                { 
                    ViewBag.Success = true;
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.ErrorMessage = _userRegistrationRepository.GetErrorMessage();
                    ViewBag.HasError = true;
                }

                return View();
            }
            else
            {
                ViewBag.HasError = true;
                return View();
            }

        }
        public IActionResult ServiceProviderRegistration ()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult ServiceProviderRegistration (UserRegistrationViewModel userRegistrationViewModel)
        {

            ViewBag.HasError = false;
            ViewBag.Success = false;
            ViewBag.ErrorMessage = "Please enter valid details";
            ViewBag.SuccessMessage = "User is successfully registered!";
            int userTypeId = 2;        // 2 is for ServiceProvier(Customer type) .....

            if (ModelState.IsValid)
            {
                if (_userRegistrationRepository.AddUser(userRegistrationViewModel, userTypeId))
                {
                    ViewBag.Success = true;
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.ErrorMessage = _userRegistrationRepository.GetErrorMessage();
                    ViewBag.HasError = true;
                }
                return View();
            }
            else
            {
                ViewBag.HasError = true;
                return View();
            }

        }
        
        [HttpPost]
        public IActionResult Index (LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {
                if(_loginRepository.IsValidUser(loginViewModel))
                {
                    int _id = _loginRepository.GetUserTypeId(loginViewModel.Email);
                    if (_id == 1)
                    {
                        HttpContext.Session.SetString("_id", _id.ToString());
                        HttpContext.Session.SetString("email", loginViewModel.Email);

                        return RedirectToAction("Index", "Customer");
                    }
                    else if (_id == 2)
                    {
                        HttpContext.Session.SetString("_id", _id.ToString());
                        HttpContext.Session.SetString("email", loginViewModel.Email);

                        return RedirectToAction("Index", "ServiceProvider");
                    }
                    else
                    {
                        ViewBag.IsLoginOpen = true;
                        ViewBag.HasError = true;
                        ViewBag.ErrorMessage = _loginRepository.GetErrorMessage();
                        return View();
                    }
                }
                else
                {
                    ViewBag.IsLoginOpen = true;
                    ViewBag.HasError = true;
                    ViewBag.ErrorMessage = _loginRepository.GetErrorMessage();
                    return View();
                }
            }
            else
            {
                ViewBag.IsLoginOpen = true;
                ViewBag.HasError = true;
                ViewBag.ErrorMessage = "Please enter valid details";
                return View();
            }
        }
        





        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
