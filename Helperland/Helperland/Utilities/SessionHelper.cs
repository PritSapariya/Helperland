using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Utilities
{
    public class SessionHelper : ActionFilterAttribute
    {
       
        private readonly int UserTypeID;
        private String returnUrl;
        public SessionHelper(int UserTypeID, String returnUrl)
        {
            this.UserTypeID = UserTypeID;
            this.returnUrl = returnUrl;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userType = context.HttpContext.Session.GetInt32("UserTypeId");
            if (userType == null)
            {
                context.Result = new RedirectToActionResult ("LoginRedirect", "Home",  new { returnUrl = returnUrl });
                return;
            }
            else
            {
                if (userType != UserTypeID)
                {
                    context.Result = new RedirectToActionResult("Index", "Home", true);
                    return;
                }
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
        
    }
}
