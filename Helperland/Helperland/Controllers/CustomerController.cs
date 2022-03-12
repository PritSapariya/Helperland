using Helperland.Models.ViewModel.Customer;
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

            return View();
        }

        // ************* Dashboard Actions **************** //
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
    }
}
