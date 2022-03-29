using Helperland.Models.DBModels;
using Helperland.Models.ViewModel.Customer;
using Helperland.Models.ViewModel.ServiceProvider;
using Helperland.Repository.IRepository;
using Helperland.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class ServiceProviderController : Controller
    {
        private readonly IServiceProviderRepository serviceProviderRepository;
        
        public ServiceProviderController(IServiceProviderRepository _serviceProviderRepository)
        {
            this.serviceProviderRepository = _serviceProviderRepository;
        }


        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/Index")]
        public IActionResult Index()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.PostalCode = HttpContext.Session.GetString("PostalCode");

            String PostalCode = HttpContext.Session.GetString("PostalCode");

            ViewBag.NewService = serviceProviderRepository.GetCountOfNewService(PostalCode, HttpContext.Session.GetInt32("UserId"));
            ViewBag.UpcomingService = serviceProviderRepository.GetCountOfUpcomingService(HttpContext.Session.GetInt32("UserId"));

            return View();
        }

        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/NewService")]
        public IActionResult NewService(String includePets)
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            String PostalCode = HttpContext.Session.GetString("PostalCode");

            var model = serviceProviderRepository.GetAllNewServiceRequest(PostalCode, includePets, HttpContext.Session.GetInt32("UserId"));

            return View(model);
        }

        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/UpcomingService")]
        public IActionResult UpcomingService()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            List<ServiceRequest> model = serviceProviderRepository.GetAllUpcomingService(HttpContext.Session.GetInt32("UserId"));

            return View(model);
        }

        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/ServiceHistory")]
        public IActionResult ServiceHistory()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            List<ServiceRequest> model = serviceProviderRepository.GetAllCompletedService(HttpContext.Session.GetInt32("UserId"));

            return View(model);
        }

        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/MyRatings")]
        public IActionResult MyRatings(string sort, string rate)
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            List<Rating> model = serviceProviderRepository.GetServiceHistory(HttpContext.Session.GetInt32("UserId"));



            if(sort == null)
            {
                sort = "cust_name_desc";
            }
            if(rate != null)
            {
                decimal temp = System.Convert.ToDecimal(rate);
                model = model.Where(x=> x.Ratings == temp).ToList();
            }

            ViewBag.RatingList = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Text = "Excellent", Value = "5" },
                new SelectListItem { Text = "Very Good", Value = "4" },
                new SelectListItem { Text = "Good", Value = "3" },
                new SelectListItem { Text = "Poor", Value = "2" },
                new SelectListItem { Text = "Very Poor", Value = "1" }
            }, "Value", "Text", rate );

            ViewBag.SortingList = new SelectList( new List<SelectListItem>
            {
                new SelectListItem { Text = "Customer Name : Ascending", Value = "cust_name_asec" },
                new SelectListItem { Text = "Customer Name : Descending", Value = "cust_name_desc" },
                new SelectListItem { Text = "Service Date : Latest", Value = "service_date_asec" },
                new SelectListItem { Text = "Service Date : Oldest", Value = "service_date_desc" },
                new SelectListItem { Text = "Rating : High to Low", Value = "rating_asec" },
                new SelectListItem { Text = "Rating : Low to High", Value = "rating_desc" }
            }, "Value", "Text", sort );




            switch (sort)
            {
                case "cust_name_asec":
                    model = model.OrderBy(x => x.RatingFromNavigation.FirstName).ToList();
                    break;

                case "cust_name_desc":
                    model = model.OrderByDescending(x => x.RatingFromNavigation.FirstName).ToList();
                    break;

                case "service_date_asec":
                    model = model.OrderBy(x => x.ServiceRequest.ServiceStartDate).ToList();
                    break;

                case "service_date_desc":
                    model = model.OrderByDescending(x => x.ServiceRequest.ServiceStartDate).ToList();
                    break;

                case "rating_asec":
                    model = model.OrderBy(x => x.ServiceRequest.ServiceStartDate).ToList();
                    break;

                case "rating_desc":
                    model = model.OrderByDescending(x => x.ServiceRequest.ServiceStartDate).ToList();
                    break;

                default:
                    break;
            }

            return View(model);
        }

        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/BlockCustomer")]
        public IActionResult BlockCustomer()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            List<ServiceRequest> model = serviceProviderRepository.GetAllCustomer(HttpContext.Session.GetInt32("UserId"));

            return View(model);
        }
        
        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/MySettings")]
        public IActionResult MySettings(bool isChanged)
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.PostalCode = HttpContext.Session.GetString("PostalCode");
            
            if(isChanged == true)
            {
                ViewBag.isChanged = true;
            }
            

            ServiceProviderSettingsViewModel model = serviceProviderRepository.GetUserDetailsById(HttpContext.Session.GetInt32("UserId"));

            return View(model);
        }

        [HttpPost]
        public IActionResult MySettings(ServiceProviderSettingsViewModel s)
        {
            s.UserId = (int)HttpContext.Session.GetInt32("UserId");
            if (ModelState.IsValid)
            {
                if(serviceProviderRepository.SaveDetails(s))
                {
                    return RedirectToAction("MySettings", "ServiceProvider", new { isChanged = true });
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/ChangePassword")]
        public IActionResult ChangePassword()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.PostalCode = HttpContext.Session.GetString("PostalCode");


            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                int userId = (int)HttpContext.Session.GetInt32("UserId");
                serviceProviderRepository.ChangePassword(changePasswordViewModel, userId);


                ViewBag.isCompleted = true;
            }

            ViewBag.isOpen = true;
            return View();
        }



        public IActionResult BlockCustomerById(int UserId)
        {
            int serviceProviderId = (int)HttpContext.Session.GetInt32("UserId");
            if (serviceProviderRepository.BlockCustomerById(UserId, serviceProviderId))
            {
                return RedirectToAction("BlockCustomer");
            }
            else
            {


                return View(new { hasError = true });
            }
            
        }
        public IActionResult AcceptService(int serviceId)
        {

            int userId = (int)HttpContext.Session.GetInt32("UserId");
            if ((bool)serviceProviderRepository.AssignServiceRequest(serviceId, userId) == true)
            {
                return RedirectToAction("NewService");
            }
            else
            {
                return RedirectToAction("NewService", new { hasAssigned = true });
            }
        }
        public IActionResult CancelService(int serviceId, int userId)
        {
            serviceProviderRepository.CancelServiceById(serviceId);

            return RedirectToAction("UpcomingService");
        }
        public IActionResult CompleteService(int serviceId, int userId)
        {
            serviceProviderRepository.CompleteServiceById(serviceId);

            return RedirectToAction("UpcomingService");
        }
        public IActionResult GetServiceDetailsById(int serviceId)
        {
            ServiceRequest model = new ServiceRequest();
            model = serviceProviderRepository.GetServiceDetailsById(serviceId);

            return View("~/Views/ServiceProvider/Partial/_ServiceHistoryDetails.cshtml", model);
        } 

    }
}
