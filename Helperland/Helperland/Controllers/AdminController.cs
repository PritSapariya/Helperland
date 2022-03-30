using Helperland.Models.DBModels;
using Helperland.Models.ViewModel.Admin;
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
    public class AdminController : Controller
    {
        private readonly IAdminRepository adminRepository;

        public AdminController(IAdminRepository _adminRepository)
        {
            this.adminRepository = _adminRepository;
        }


        [SessionHelper(UserTypeID: 3, returnUrl: "/Admin/ServiceManagement")]
        public IActionResult ServiceManagement(int? serviceid, string postalcode, string email, string customer, string serviceprovider, int? status, DateTime? startdate, DateTime? todate)
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");

            ViewBag.RatingOfServiceProvider = adminRepository.GetAllSPRating();
            


            List<ServiceRequest> model = adminRepository.GetAllServiceRequest();

            // Filerting by Customer name
            if(customer != null )
            {
                ViewBag.CustomerList = new SelectList(adminRepository.GetAllCustomerName(HttpContext.Session.GetInt32("UserId")), customer);
                String first = customer.Split(" ")[0];
                String last = customer.Split(" ")[1];

                model = model.Where(x => (x.User.FirstName == first && x.User.LastName == last)).ToList();
            }
            else
            {
                ViewBag.CustomerList = new SelectList(adminRepository.GetAllCustomerName(HttpContext.Session.GetInt32("UserId")), null);
            }

            // Filerting by Service Provider name
            if (serviceprovider != null)
            {
                ViewBag.ServiceProviderList = new SelectList(adminRepository.GetAllSPName(HttpContext.Session.GetInt32("UserId")), serviceprovider);
                String first = serviceprovider.Split(" ")[0];
                String last = serviceprovider.Split(" ")[1];

                model = model.Where(x => x.ServiceProvider != null).ToList();
                model = model.Where(x => x.ServiceProvider.FirstName == first && x.ServiceProvider.LastName == last).ToList();
            }
            else
            {
                ViewBag.ServiceProviderList = new SelectList(adminRepository.GetAllSPName(HttpContext.Session.GetInt32("UserId")), null);
            }

            // Filerting by status
            if (status != null)
            {
                ViewBag.StatusList = new SelectList(new List<SelectListItem> {

                    new SelectListItem { Text = "New", Value = "1" },
                    new SelectListItem { Text = "Upcoming", Value = "5" },
                    new SelectListItem { Text = "Rescheduled", Value = "4" },
                    new SelectListItem { Text = "Completed", Value = "2" },
                    new SelectListItem { Text = "Cancelled", Value = "3" }

                    }, "Value", "Text", status);

                model = model.Where(x => x.Status == status).ToList();
            }
            else
            {
                ViewBag.StatusList = new SelectList(new List<SelectListItem> {

                    new SelectListItem { Text = "New", Value = "1" },
                    new SelectListItem { Text = "Upcoming", Value = "5" },
                    new SelectListItem { Text = "Rescheduled", Value = "4" },
                    new SelectListItem { Text = "Completed", Value = "2" },
                    new SelectListItem { Text = "Cancelled", Value = "3" }

                    }, "Value", "Text");
            }

            // Filerting by Service Id
            if (serviceid != null)
            {
                model = model.Where(x => x.ServiceRequestId == serviceid).ToList();
                ViewBag.ServiceId = serviceid;
            }

            // Filerting by postalcode
            if (postalcode != null)
            {
                model = model.Where(x => x.ZipCode == postalcode).ToList();
                ViewBag.PostalCode = postalcode;
            }

            // Filerting by postalcode
            if (email != null)
            {
                model = model.Where(x => x.ServiceRequestAddresses.First().Email == email).ToList();
                ViewBag.Email = email;
            }

            // Filtering by Start Date
            if (startdate != null)
            {
                model = model.Where(x => x.ServiceStartDate >= startdate).ToList();
                ViewBag.StartDate = ((DateTime)startdate).ToString("yyyy-MM-dd");
            }

            // Filtering by End Date
            if (todate != null)
            {
                model = model.Where(x => x.ServiceStartDate <= todate).ToList();
                ViewBag.ToDate = ((DateTime)todate).ToString("yyyy-MM-dd");
            }


            return View(model);
        }

        [SessionHelper(UserTypeID: 3, returnUrl: "/Admin/UserManagement")]
        public IActionResult UserManagement(String username, String userrole, String mobile, String zipcode)
        {
            ViewBag.UserTypeId = HttpContext.Session.GetInt32("UserTypeId");
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            
            // Getting Data from the backend
            List<User> model = adminRepository.GetAllUser(HttpContext.Session.GetInt32("UserId"));


            if(username != null)
            {
                ViewBag.UserList = new SelectList(adminRepository.GetAllUserName(HttpContext.Session.GetInt32("UserId")), username);

                String first = username.Split(" ")[0];
                String last = username.Split(" ")[1];

                model = model.Where(x => (x.FirstName == first && x.LastName == last)).ToList();
            }
            else
            {
                ViewBag.UserList = new SelectList(adminRepository.GetAllUserName(HttpContext.Session.GetInt32("UserId")), null);
            }

            if(userrole != null)
            {
                ViewBag.RoleList = new SelectList( new List<SelectListItem> { 
                    new SelectListItem{ Text = "Customer", Value = "1" },
                    new SelectListItem{ Text = "Service Provider", Value = "2" },
                    new SelectListItem{ Text = "Admin", Value = "3" }
                }, "Value", "Text", userrole );

                int temp = System.Convert.ToInt32(userrole);
                model = model.Where(x => x.UserTypeId == temp).ToList();
            }
            else
            {
                ViewBag.RoleList = new SelectList(new List<SelectListItem> {
                    new SelectListItem{ Text = "Customer", Value = "1" },
                    new SelectListItem{ Text = "Service Provider", Value = "2" },
                    new SelectListItem{ Text = "Admin", Value = "3" }
                }, "Value", "Text");
            }
            if(mobile != null)
            {
                model = model.Where(x => x.Mobile == mobile).ToList();
                ViewBag.Mobile = mobile;
            }
            if(zipcode != null)
            {
                model = model.Where(x => x.ZipCode == zipcode).ToList();
                ViewBag.Zipcode = zipcode;
            }
            



            return View(model);
        }

        public IActionResult EditService(int? serviceId)
        {
            CustomServiceRequestViewModel model = adminRepository.GetServiceDetailsById(serviceId);

            ViewBag.TimeList = new SelectList( new List<SelectListItem> { 
                new SelectListItem { Text = "08:00", Value = "8" },
                new SelectListItem { Text = "08:30", Value = "8.5" },
                new SelectListItem { Text = "09:00", Value = "9" },
                new SelectListItem { Text = "09:30", Value = "9.5" },
                new SelectListItem { Text = "10:00", Value = "10" },
                new SelectListItem { Text = "10:30", Value = "10.5" },
                new SelectListItem { Text = "11:00", Value = "11" },
                new SelectListItem { Text = "11:30", Value = "11.5" },
                new SelectListItem { Text = "12:00", Value = "12" },
                new SelectListItem { Text = "12:30", Value = "12.5" },
                new SelectListItem { Text = "13:00", Value = "13" },
                new SelectListItem { Text = "13:30", Value = "13.5" },
                new SelectListItem { Text = "14:00", Value = "14" },
                new SelectListItem { Text = "14:30", Value = "14.5" },
                new SelectListItem { Text = "15:00", Value = "15" },
                new SelectListItem { Text = "15:30", Value = "15.5" },
                new SelectListItem { Text = "16:00", Value = "16" },
                new SelectListItem { Text = "16:30", Value = "16.5" },
                new SelectListItem { Text = "17:00", Value = "17" },
                new SelectListItem { Text = "17:30", Value = "17.5" },
                new SelectListItem { Text = "18:00", Value = "18" },
                new SelectListItem { Text = "18:30", Value = "18.5" }
            }, "Value", "Text", model.Time);

            return View(model);
        }

        public IActionResult CancelService(int? serviceid)
        {
            adminRepository.CancelServiceById(serviceid);
            return Redirect("/Admin/ServiceManagement");
        }
        [HttpPost]
        public IActionResult SaveDetails(CustomServiceRequestViewModel service)
        {
            adminRepository.SaveDetails(service);
            return Redirect("/Admin/ServiceManagement");
        }
        public IActionResult Deactive(int? userId)
        {
            adminRepository.Deactive(userId);
            return RedirectToAction("UserManagement", "Admin");
        }

        public IActionResult Active(int? userId)
        {
            adminRepository.Active(userId);
            return RedirectToAction("UserManagement", "Admin");
        }

        public IActionResult Approve(int? userId)
        {
            adminRepository.Approve(userId);
            return RedirectToAction("UserManagement", "Admin");
        }

    }
}
