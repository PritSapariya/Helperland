using Helperland.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface ILoginRepository
    {
        public Boolean IsUserEmailExists(string _email);
        public Boolean IsValidUser(LoginViewModel loginViewModel);
        public int GetUserTypeId(string _email);
        public int GetUserId(string _email);

    }
}
