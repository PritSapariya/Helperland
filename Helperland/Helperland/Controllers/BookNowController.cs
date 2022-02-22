using Helperland.Models.ViewModel.BookNow;
using Helperland.Repository;
using Helperland.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            //if (HttpContext.Session.GetString("_id") == "1")
            //{
                return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Home", new { isLoginOpen = "true" });
            //}

        }

        [HttpPost]
        public IActionResult CheckPostalCode ( [FromBody] PostalCodeViewModel postalCodeViewModel)
        {
            if (ModelState.IsValid)
            {
                if(_bookNowRepository.CheckAvailabilityOfPostalCode(postalCodeViewModel))
                {
                    return Json( new { success = true } );
                }
                else
                {
                    return Json(new { success = false, message = "We are not providing service in this area. We’ll notify you if any helper would start working near your area." });
                }
            }
            else
            {
                return Json( new { success = false, message = "Please enter valid data" } );
            }
        }

        [HttpGet] 
        public IActionResult GetDetail ()
        {
            return View("_Schedule");
        }



    }
}
