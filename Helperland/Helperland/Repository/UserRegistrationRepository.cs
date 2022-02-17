using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel;
using Helperland.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
