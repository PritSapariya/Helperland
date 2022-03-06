using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.BookNow;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface IBookNowRepository
    {
        public string GetErrorMessage ();
        public Boolean CheckAvailabilityOfPostalCode ( PostalCodeViewModel postalCodeViewModel );
        public Boolean SaveNewAddress( UserAddressViewModel userAddressViewModel );
        public List<UserAddressViewModel> GetSavedAddress(int _id, string _postalCode);
        public Boolean SaveServiceRequest ( ServiceRequestViewModel serviceRequestViewModel );
    }
}
