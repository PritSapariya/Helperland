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
    public class LoginRepository : ILoginRepository
    {
        private readonly HelperlandContext _db;
        private String Message = "Default Message";

        public LoginRepository(HelperlandContext _db)
        {
            this._db = _db;
        }

        public string GetErrorMessage()
        {
            return Message;
        }


        public Boolean IsUserEmailExists(string _email)
        {
            User result = _db.Users.Where(u => u.Email == _email).FirstOrDefault();
            if(result != null)
            {
                return true;
            }
            Message = _email + " is not registered yet!" ;
            return false;
        }

        public Boolean IsValidUser(LoginViewModel loginViewModel)
        {
            if(IsUserEmailExists(loginViewModel.Email))
            {
                try
                {
                    User result = _db.Users.Where(u => u.Email == loginViewModel.Email && u.Password == loginViewModel.Password).FirstOrDefault();
                    if(result != null)
                    {
                        return true;
                    }    
                    else
                    {
                        Message = "Username or Password is invalid";
                        return false;
                    }
                }
                catch
                {
                    Message = "Internal Server Error";
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
    
        public int GetUserTypeId(string _email)
        {
            User result = _db.Users.Where(u => u.Email == _email).FirstOrDefault();
            if(result != null)
            {
                return (int)result.UserTypeId;
            }
            Message = "Error in getting useId";
            return -1;
        }

    }
}
