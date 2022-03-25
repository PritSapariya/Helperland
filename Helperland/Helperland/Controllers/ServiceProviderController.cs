using Helperland.Models.DBModels;
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

            ViewBag.NewService = serviceProviderRepository.GetCountOfNewService(PostalCode);
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

            var model = serviceProviderRepository.GetAllNewServiceRequest(PostalCode, includePets);

            return View(model);
        }

        [SessionHelper(UserTypeID: 2, returnUrl: "/ServiceProvider/UpcomingService")]
        public IActionResult UpcomingService()
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            List<ServiceRequest> model = serviceProviderRepository.GetALlUpcomingService(HttpContext.Session.GetInt32("UserId"));

            return View();
        }

        public IActionResult AcceptService(int serviceId, int userId)
        {

            if ((bool)serviceProviderRepository.AssignServiceRequest(serviceId, userId) == true)
            {
                return RedirectToAction("NewService");
            }
            else
            {
                return RedirectToAction("NewService", new { hasAssigned = true });
            }

        }

        public IActionResult GetServiceDetailsById(int serviceId)
        {
            ServiceRequest model = new ServiceRequest();
            model = serviceProviderRepository.GetServiceDetailsById(serviceId);

            return View("~/Views/ServiceProvider/Partial/_ServiceHistoryDetails.cshtml", model);
        }

    }
}
