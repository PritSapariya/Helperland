using Helperland.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface IUserRegistrationRepository
    {
        public Boolean IsUserExists(string _email);
        public string GetErrorMessage();
        public Boolean AddUser(UserRegistrationViewModel _userRegistrationViewModel, int userTypeId);
    }
}
