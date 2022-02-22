using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.BookNow;
using Helperland.Repository.IRepository;
using Helperland.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class BookNowRepository : IBookNowRepository
    {
        private readonly HelperlandContext _db;
        private String Message = "Default Message";

        public BookNowRepository ( HelperlandContext _db )
        {
            this._db = _db;
        }

        public string GetErrorMessage ()
        {
            return Message;
        }
        public Boolean CheckAvailabilityOfPostalCode ( PostalCodeViewModel postalCodeViewModel )
        {
            string _pincode = postalCodeViewModel.PostalCode.ToString();

            User user = _db.Users.Where(x => x.UserTypeId == ConstantString.serviceTypeId && x.ZipCode == _pincode).FirstOrDefault();
            if ( user != null )
            {
                return true;
            }
            return false;
        }


    }
}
