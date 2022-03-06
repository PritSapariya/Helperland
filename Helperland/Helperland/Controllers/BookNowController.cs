using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.BookNow;
using Helperland.Repository;
using Helperland.Repository.IRepository;
using Helperland.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class BookNowController : Controller
    {

        public readonly IBookNowRepository _bookNowRepository;

        public BookNowController ( IBookNowRepository _bookNowRepository )
        {
            this._bookNowRepository = _bookNowRepository;
        }

        [SessionHelper(UserTypeID: 1, returnUrl: "/BookNow/Index")]
        public IActionResult Index ()
        {
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            //ViewBag.UserId = 3;
            return View();
        }

        [HttpGet]
        public IActionResult GetSchedulePage ()
        {
            ViewBag.ExtraServiceInsideCabinet = ConstantString.ExtraServiceInsideCabinet;
            ViewBag.ExtraServiceInsideFridge = ConstantString.ExtraServiceInsideFridge;
            ViewBag.ExtraServiceInsideOven = ConstantString.ExtraServiceInsideOven;
            ViewBag.ExtraServiceInsideLaundry = ConstantString.ExtraServiceInsideLaundry;
            ViewBag.ExtraServiceInsideWindows = ConstantString.ExtraServiceInsideWindows;

            return View("_Schedule");
        }

        [HttpGet]
        public IActionResult GetAddressPage ()
        {
            return View("_Details");
        }
        
        [HttpGet]
        public IActionResult GetPaymentPage ()
        {
            return View("_Payment");
        }

        [HttpPost]
        public IActionResult CheckPostalCode ( [FromBody] PostalCodeViewModel postalCodeViewModel )
        {
            if (ModelState.IsValid)
            {
                if(_bookNowRepository.CheckAvailabilityOfPostalCode(postalCodeViewModel))
                {
                    return Json( new { success = true } );
                }
                else
                {
                    return Json( new { success = false, message = "We are not providing service in this area. We’ll notify you if any helper would start working near your area." });
                }
            }
            else
            {
                return Json( new { success = false, message = "Please enter valid data" } );
            }
        }

        [HttpPost]
        public IActionResult AddAddress ( [FromBody] UserAddressViewModel userAddessViewModel )
        {
            if ( ModelState.IsValid )
            {
                if ( _bookNowRepository.SaveNewAddress( userAddessViewModel ))
                {
                    return Json( new { success = true, message = "Address added successfully!" });
                }
                else
                {
                    return Json( new { success = false, message = _bookNowRepository.GetErrorMessage() });
                }
            }
            else
            {
                return Json( new { success = false, message = "Please enter valid data" } );
            }
        }

        [HttpPost]
        public JsonResult GetAddress ( int _id, string _postalCode )
        {
            List<UserAddressViewModel> results = _bookNowRepository.GetSavedAddress(_id, _postalCode);

            return Json(JsonConvert.SerializeObject(new { success = false, address = results }));

        }

        [HttpPost]
        public IActionResult SaveServiceRequest ( ServiceRequestViewModel serviceRequestViewModel )
        {
            if (ModelState.IsValid)
            {

                if (_bookNowRepository.SaveServiceRequest(serviceRequestViewModel))
                {
                    return Json( new { success = true, message = "Your service request is successfully registered !!!" } );
                }
                else
                {
                    return Json(new { success = false, message = _bookNowRepository.GetErrorMessage() });
                }

            }
            else
            {
                return Json(new { success = false, message = "Invalid Data" });
            }

        }

    }
}
