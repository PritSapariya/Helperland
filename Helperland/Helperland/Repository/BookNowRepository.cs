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
        private String Message = "Internal server error";
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

            User user = _db.Users.Where(x => x.UserTypeId == ConstantString.ServiceTypeId && x.ZipCode == _pincode).FirstOrDefault();
            if ( user != null )
            {
                return true;
            }
            return false;
        }

        public Boolean SaveNewAddress ( UserAddressViewModel userAddressViewModel )
        {
            try
            {

                UserAddress address = new UserAddress();
                address.AddressLine1 = userAddressViewModel.AddressLine1;
                address.AddressLine2 = userAddressViewModel.AddressLine2;
                address.City = userAddressViewModel.City;
                address.UserId = (int)userAddressViewModel.UserId;
                address.Mobile = userAddressViewModel.Mobile;
                address.PostalCode = userAddressViewModel.PostalCode;

                _db.UserAddresses.Add(address);
                _db.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                Message = "Internal Server Error";
            }

            return false;
        }

        public List<UserAddressViewModel> GetSavedAddress( int _id, string _postalCode )
        {

            List<UserAddressViewModel> addressArr = new List<UserAddressViewModel>();
            List<UserAddress> results = _db.UserAddresses.Where(x => x.UserId == _id && x.PostalCode == _postalCode).ToList();
            foreach ( var item in results )
            {
                UserAddressViewModel address = new UserAddressViewModel();
                address.AddressId = item.AddressId;
                address.UserId = item.UserId;
                address.AddressLine1 = item.AddressLine1;
                address.AddressLine2 = item.AddressLine2;
                address.PostalCode = item.PostalCode;
                address.Email = item.Email;
                address.Mobile = item.Mobile;
                address.City = item.City;

                addressArr.Add(address);
                
            }

            return addressArr;
        }

        public Boolean SaveServiceRequest(ServiceRequestViewModel serviceRequestViewModel)
        {

            try
            {
                User u =  _db.Users.Where(x => x.UserId == serviceRequestViewModel.UserId).FirstOrDefault();
                String _email = u.Email;

                ServiceRequest request = new ServiceRequest();
                request.UserId = (int)serviceRequestViewModel.UserId;
                request.Comments = serviceRequestViewModel.Comments;
                request.ExtraHours = serviceRequestViewModel.ExtraHours;
                request.ServiceHours = serviceRequestViewModel.ServiceHours;
                request.ZipCode = serviceRequestViewModel.ZipCode;
                request.HasPets = serviceRequestViewModel.HasPets;
                request.ServiceStartDate = serviceRequestViewModel.ServiceStartDate;
                request.ServiceHours = serviceRequestViewModel.ServiceHours;
                request.Status = ConstantString.StatusPending;
                request.TotalCost = serviceRequestViewModel.TotalCost;  // Payment can be changes once the Hourly Rate is fixed

                _db.ServiceRequests.Add(request);
                _db.SaveChanges();

                int serviceId = request.ServiceRequestId;

                UserAddress result = _db.UserAddresses.Where(x => x.AddressId == serviceRequestViewModel.AddressID).FirstOrDefault();
                ServiceRequestAddress address = new ServiceRequestAddress();
                
                address.ServiceRequestId = serviceId;
                address.AddressLine1 = result.AddressLine1;
                address.AddressLine2 = result.AddressLine2;
                address.City = result.City;
                address.State = result.State;
                address.Mobile = result.Mobile;
                address.PostalCode = result.PostalCode;
                address.Email = _email;

                _db.ServiceRequestAddresses.Add(address);
                _db.SaveChanges();


                if(serviceRequestViewModel.ExtraServiceId != null)
                {
                    foreach ( int i in serviceRequestViewModel.ExtraServiceId )
                    {
                        ServiceRequestExtra extra = new ServiceRequestExtra();
                        extra.ServiceRequestId = serviceId;
                        extra.ServiceExtraId = i;
                        _db.ServiceRequestExtra.Add(extra);
                        _db.SaveChanges();
                    }
                }

            }
            catch (Exception ex) 
            {
                Message = ex.Message;
                return false;
            }

            return true;
        }
    }
}
