using Helperland.Models.ViewModel.Customer;
using Helperland.Models.ViewModel;
using Helperland.Repository;
using Helperland.Repository.IRepository;
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
        private readonly ICustomerDashboardRepository customerDashboardRepository;
        
        public CustomerController ( ICustomerDashboardRepository _customerDashboardRepository )
        {
            this.customerDashboardRepository = _customerDashboardRepository;
        }



        [SessionHelper(UserTypeID: 1, returnUrl: "/Customer/Index")]
        public IActionResult Index()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            int userId = (int)HttpContext.Session.GetInt32("UserId");

            List<CurrentServiceRequestViewModel> model =  customerDashboardRepository.GetAllCurrentServiceRequest(userId);

            return View(model);
        }

        [SessionHelper(UserTypeID: 1, returnUrl: "/Customer/ServiceHistory")]
        public IActionResult ServiceHistory ()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            int userId = (int)HttpContext.Session.GetInt32("UserId");

            List<CurrentServiceRequestViewModel> model = customerDashboardRepository.GetServiceRequestHistory(userId);

            return View(model);
        }

        [SessionHelper(UserTypeID: 1, returnUrl: "/Customer/MySettings")]
        public IActionResult MySettings()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            ChangePasswordViewModel model = new ChangePasswordViewModel();

            return View(model);
        }

        [HttpPost] 
        public IActionResult MySettings(ChangePasswordViewModel changePasswordViewModel)
        {
            if(ModelState.IsValid)
            {
                int userId =  (int)HttpContext.Session.GetInt32("UserId");
                customerDashboardRepository.ChangePassword(changePasswordViewModel, userId);

                
                ViewBag.isCompleted = true;
            }
           
            ViewBag.isOpen = true;
            return View();
        }


        // ******************** Dashboard Actions ********************* //
        [HttpGet]
        public IActionResult GetServiceDetails (int serviceId)
        {
            CurrentServiceRequestViewModel model = customerDashboardRepository.GetServiceRequestDetailByServiceId(serviceId);
            return View("_ServiceDetails", model);
        }
        
        [HttpPost]
        public IActionResult GetServiceDateTimeById (int serviceId)
        {
            String data = customerDashboardRepository.GetDateTimeById(serviceId);

            return Json( new { success = true , data = data}); 
        }

        [HttpPost]
        public IActionResult RescheduleServiceRequest(int serviceId, DateTime newDateAndTime)
        {

            if (customerDashboardRepository.RescheduleServiceRequest(serviceId, newDateAndTime) == true) { 
                return Json( new { success = true });
            }
            else
            {
                return Json( new { success = false });
            }

        }

        [HttpPost]
        public IActionResult CancelServiceRequest (int serviceId, String message)
        {
            if(customerDashboardRepository.CancelServiceRequest(serviceId, message))
            {
                return Json( new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }


        // ******************** Service History Actions ********************* //
        [HttpPost]
        public IActionResult SetServiceRating(RatingViewModel ratingViewModel)
        {
            
            if(ModelState.IsValid)
            {
                if (customerDashboardRepository.SetServiceRating(ratingViewModel))
                {
                    return Json(new { success = true, message = "Service Rating is successfully given" });
                }
                else
                {
                    return Json(new { success = false, message = "Internal Server Error" });
                }
            }
            else
            {
                return Json(new { success = false, message = "Data is not valid." });
            }
            

        }

        [HttpGet]
        public IActionResult GetUserDetails()
        {

            int id = (int)HttpContext.Session.GetInt32("UserId");
            var modal = customerDashboardRepository.GetUserDetails(id);

            return View("~/Views/Customer/Partial/_UserDetails.cshtml", modal);
        }
        [HttpGet]
        public IActionResult GetUserAddress()
        {
            int id = (int)HttpContext.Session.GetInt32("UserId");
            List<UserAddressViewModel> modal = customerDashboardRepository.GetAllUserAddressById(id);

            return View("~/Views/Customer/Partial/_UserAddresses.cshtml", modal);
        }

        [HttpPost] 
        public JsonResult SaveUserDetails(UserDetailsViewModel userDetailsViewModel)
        {
            if (ModelState.IsValid) 
            {
                if(customerDashboardRepository.SaveUserDetails(userDetailsViewModel))
                {
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Internal server error" });
                }
            }
            else
            {
                return Json( new { success = false, message = "Please enter valid details" });
            }
        }

        [HttpPost]
        public JsonResult GetAddressById(int addressId)
        {
            var result = customerDashboardRepository.GetAddreesById(addressId);
            return Json( new { success = true, data = result } );
        }
        [HttpPost]
        public JsonResult SaveUpdatedResult(UserAddressViewModel userAddressViewModel) 
        {
            if(ModelState.IsValid)
            {
                if(customerDashboardRepository.SaveUpdatedAddress(userAddressViewModel))
                {
                    return Json(new { success = true, message = "Adddress is updated successfully" });
                }
                else
                {
                    return Json(new { success = false, message = "Internal Server Error" });
                }
            }
            else
            {
                return Json( new { success = false, message = "Please enter valid data" });
            }
        }
        [HttpPost] 
        public JsonResult DeleteAddress(int addressId)
        {
            if (customerDashboardRepository.DeleteAddress(addressId))
            {
                return Json(new { success = true, message = "Address is successfully deleted" });
            }
            else
            {
                return Json(new { success = false, message = "Internal Server Error" });
            }

            
        }
    }
}
