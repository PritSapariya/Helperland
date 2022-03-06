using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel;
using Helperland.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private readonly HelperlandContext _db;
        private String Message;

        public UserRegistrationRepository(HelperlandContext _db)
        {
            this._db = _db;
        }

        public string GetErrorMessage()
        {
            return Message;
        }
        public Boolean IsUserExists(string _email)
        {
            User result = _db.Users.Where(u => u.Email == _email).FirstOrDefault();
            if(result != null)
            {
                Message = "Someone is already registred with " + _email ;
                return true;
            }
            return false;
        }
        public Boolean AddUser(UserRegistrationViewModel _userRegistrationViewModel, int _userTypeId)
        {
            if(!IsUserExists(_userRegistrationViewModel.Email))
            {
                try
                {
                    // User model
                    User user = new User();
                    user.FirstName = _userRegistrationViewModel.FirstName;
                    user.LastName = _userRegistrationViewModel.LastName;
                    user.Email = _userRegistrationViewModel.Email;
                    user.UserTypeId = _userTypeId;
                    user.Mobile = _userRegistrationViewModel.MobileNumber;
                    user.Password = _userRegistrationViewModel.Password;
                    user.CreatedDate = DateTime.Now.Date;

                    // Entry to database
                    _db.Users.Add(user);
                    _db.SaveChanges();                    

                    return true;
                }
                catch (Exception ex)
                {
                    Message = ex.Message;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //[HttpPost]
        //[Route("ForgotPassword")]
        //public ActionResult ForgotPassword(Models.ForgotPassword model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var isExist = IsEmailExist(model.Email);
        //        if (isExist == false)
        //        {
        //            ModelState.AddModelError("Email", "Email Does not exist");
        //            return View(model);
        //        }
        //        UserTable obj = dbobj.UserTable.Where(x => x.Email == model.Email).FirstOrDefault();
        //        string pwd = Membership.GeneratePassword(6, 2);
        //        obj.Password = Crypto.Hash(pwd);
        //        dbobj.SaveChanges();
        //        SendPassword(obj.Email, pwd);
        //        TempData["Success"] = "New password has been sent to your email";
        //    }
        //    return RedirectToAction("ForgotPassword");
        //}

        //[NonAction]
        //public void SendPassword(string emailID, string pwd)
        //{
        //    var fromEmail = new MailAddress("email");//temp@gmail.com
        //    var toEmail = new MailAddress(emailID);
        //    var fromEmailPassword = "password"; //abc123
        //    string subject = "Note Marketplace - Forgot Password";

        //    string body = "Hello," +
        //        "<br/><br/>We have generated a new password for you" +
        //        "<br/><br/>Password: " + pwd +
        //        "<br/><br/>Regards,<br/>Notes Marketplace";

        //    var smtp = new SmtpClient
        //    {
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
        //    };

        //    using (var message = new MailMessage(fromEmail, toEmail)
        //    {
        //        Subject = subject,
        //        Body = body,
        //        IsBodyHtml = true
        //    })

        //    smtp.Send(message);
        //}
    }
}
