using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.Customer;
using Helperland.Repository.IRepository;
using Helperland.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Helperland.Repository
{


    public class CustomerDashboardRepository : ICustomerDashboardRepository
    {
        private readonly HelperlandContext _db;
        private String Message;

        public CustomerDashboardRepository(HelperlandContext _db)
        {
            this._db = _db;
        }


        public string GetErrorMessage()
        {
            return Message;
        }

        public List<CurrentServiceRequestViewModel> GetAllCurrentServiceRequest(int userId)
        {
            List<CurrentServiceRequestViewModel> resultList = new List<CurrentServiceRequestViewModel>();

            try
            {
                List<ServiceRequest> allService = _db.ServiceRequests.Where(x => x.UserId == userId && (x.Status == ConstantString.StatusPending || x.Status == ConstantString.StatusRescheduled )).ToList();
                
                foreach (ServiceRequest item in allService)
                {
                    CurrentServiceRequestViewModel result = new CurrentServiceRequestViewModel();

                    // Service Provider Rating Details
                    if (item.Status == ConstantString.StatusCompleted)
                    {
                        Rating temp = _db.Ratings.Where(r => r.ServiceRequestId == item.ServiceRequestId).FirstOrDefault();
                        if (temp != null) { result.IsRated = true; }
                        else { result.IsRated = false; }
                    }
                    if (item.ServiceProviderId != null)
                    {
                        decimal sum = _db.Ratings.Where(x => x.RatingTo == item.ServiceProviderId).Sum(s => s.Ratings);
                        int count = _db.Ratings.Where(x => x.RatingTo == item.ServiceProviderId).Count();

                        if (count > 0)
                        {
                            result.ServiceProviderRating = Math.Round((sum / count), 2);
                        }
                    }

                    if (item.ServiceProviderId != null)
                    {
                        result.ServiceProviderId = item.ServiceProviderId;
                        User sp = _db.Users.Where(s => s.UserId == item.ServiceProviderId && s.UserTypeId == ConstantString.ServiceTypeId ).FirstOrDefault();
                        result.ServiceProviderName = sp.FirstName + " " + sp.LastName;
                        result.ServiceProviderAvatar = sp.UserProfilePicture;
                    }
                    result.ServiceRequestId = item.ServiceRequestId;
                    result.ServiceStartDate = item.ServiceStartDate;
                    result.ServiceHours = item.ServiceHours;
                    result.ExtraHours = item.ExtraHours;
                    result.TotalCost = item.TotalCost;
                    result.Status = item.Status;

                    resultList.Add(result);
                }


            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }

            return resultList;
        }

        public CurrentServiceRequestViewModel GetServiceRequestDetailByServiceId(int serviceId)
        {
            CurrentServiceRequestViewModel result = new CurrentServiceRequestViewModel();

            try
            {
                ServiceRequestAddress serviceRequestAddress = _db.ServiceRequestAddresses.Where(x => x.ServiceRequestId == serviceId).FirstOrDefault();
                result.AddressId = serviceRequestAddress.Id;
                result.AddressLine1 = serviceRequestAddress.AddressLine1;
                result.AddressLine2 = serviceRequestAddress.AddressLine2;
                result.Mobile = serviceRequestAddress.Mobile;
                result.Email = serviceRequestAddress.Email;
                result.PostalCode = serviceRequestAddress.PostalCode;
                result.City = serviceRequestAddress.City;
                result.State = serviceRequestAddress.State;

                List<int> extraServiceArr = _db.ServiceRequestExtra.Where(x => x.ServiceRequestId == serviceId)
                                                                        .Select(x => x.ServiceExtraId)
                                                                        .ToList();
                result.ExtraServiceId = extraServiceArr;

                ServiceRequest serviceRequest = _db.ServiceRequests.Where(s => s.ServiceRequestId == serviceId).FirstOrDefault();
                result.ServiceRequestId = serviceId;
                result.ServiceStartDate = serviceRequest.ServiceStartDate;
                result.ServiceHours = serviceRequest.ServiceHours;
                result.ExtraHours = serviceRequest.ExtraHours;
                result.ZipCode = serviceRequest.ZipCode;
                result.TotalCost = serviceRequest.TotalCost;
                result.Comments = serviceRequest.Comments;
                result.HasPets = serviceRequest.HasPets;
                result.Status = serviceRequest.Status;

                // Service Provider Rating Details
                if (serviceRequest.ServiceProviderId != null)
                {
                    Rating temp = _db.Ratings.Where(r => r.ServiceRequestId == serviceRequest.ServiceRequestId).FirstOrDefault();
                    if (temp != null) { result.IsRated = true; }
                    else { result.IsRated = false; }

                    decimal sum = _db.Ratings.Where(x => x.RatingTo == serviceRequest.ServiceProviderId).Sum(s => s.Ratings);
                    int count = _db.Ratings.Where(x => x.RatingTo == serviceRequest.ServiceProviderId).Count();

                    if (count > 0)
                    {
                        result.ServiceProviderRating = Math.Round((sum / count), 2);
                    }

                }
                if (serviceRequest.ServiceProviderId != null)
                {
                    User sp = _db.Users.Where(s => s.UserId == serviceRequest.ServiceProviderId && s.UserTypeId == ConstantString.ServiceTypeId).FirstOrDefault();
                    result.ServiceProviderId = serviceRequest.ServiceProviderId;
                    result.ServiceProviderName = sp.FirstName + " " + sp.LastName;
                    result.ServiceProviderAvatar = sp.UserProfilePicture;
                }

                return result;

            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }

            return result;
        }

        public String GetDateTimeById(int serviceId)
        {
            DateTime data = _db.ServiceRequests.Where(x => x.ServiceRequestId == serviceId).Select(c => c.ServiceStartDate).FirstOrDefault();

            return data.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        public Boolean RescheduleServiceRequest(int serviceId, DateTime newDateAndTime) 
        {
            ServiceRequest service = _db.ServiceRequests.Where(x => x.ServiceRequestId == serviceId).FirstOrDefault();
            try
            {
                service.ServiceStartDate = newDateAndTime;
                service.Status = ConstantString.StatusRescheduled;
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    
        public Boolean CancelServiceRequest(int serviceId, String Boolean)
        {
            ServiceRequest service = _db.ServiceRequests.Where(x => x.ServiceRequestId == serviceId).FirstOrDefault();
            try
            {
                service.Status = ConstantString.StatusCancelled;
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<CurrentServiceRequestViewModel> GetServiceRequestHistory(int userId)
        {
            List<CurrentServiceRequestViewModel> resultList = new List<CurrentServiceRequestViewModel>();

            try
            {
                List<ServiceRequest> allService = _db.ServiceRequests.Where(x => x.UserId == userId && (x.Status == ConstantString.StatusCancelled || x.Status == ConstantString.StatusCompleted)).ToList();

                foreach (ServiceRequest item in allService)
                {
                    CurrentServiceRequestViewModel result = new CurrentServiceRequestViewModel();

                    // Service Provider Rating Details
                    //if(item.Status == ConstantString.StatusCompleted)
                    {
                        Rating temp = _db.Ratings.Where(r => r.ServiceRequestId == item.ServiceRequestId).FirstOrDefault();
                        if (temp != null) { result.IsRated = true; }
                        else { result.IsRated = false; }
                    }
                    if (item.ServiceProviderId != null)
                    {
                        decimal sum = _db.Ratings.Where(x => x.RatingTo == item.ServiceProviderId).Sum(s => s.Ratings);
                        int count = _db.Ratings.Where(x => x.RatingTo == item.ServiceProviderId).Count();

                        if(count > 0)
                        {
                            result.ServiceProviderRating = Math.Round((sum / count), 2);
                        }
                    }

                    // Service Provider Details
                    if (item.ServiceProviderId != null)
                    {
                        User sp = _db.Users.Where(s => s.UserId == item.ServiceProviderId && s.UserTypeId == ConstantString.ServiceTypeId).FirstOrDefault();
                        result.ServiceProviderId = item.ServiceProviderId;
                        result.ServiceProviderName = sp.FirstName + " " + sp.LastName;
                        result.ServiceProviderAvatar = sp.UserProfilePicture;
                    }


                    result.ServiceRequestId = item.ServiceRequestId;
                    result.ServiceStartDate = item.ServiceStartDate;
                    result.ServiceHours = item.ServiceHours;
                    result.ExtraHours = item.ExtraHours;
                    result.TotalCost = item.TotalCost;
                    result.Status = item.Status;

                    resultList.Add(result);
                }


            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }

            return resultList;

        }

        public bool SetServiceRating(RatingViewModel ratingViewModel)
        {
            try
            {
                Rating rating = new Rating();
                rating.ServiceRequestId = ratingViewModel.ServiceRequestId;
                rating.RatingFrom = ratingViewModel.RatingFrom;
                rating.RatingTo = ratingViewModel.RatingTo;
                rating.Ratings = Math.Round( ratingViewModel.Ratings, 2 );
                rating.Comments = ratingViewModel.Comments;
                rating.QualityOfService = ratingViewModel.QualityOfService;
                rating.OnTimeArrival = ratingViewModel.OnTimeArrival;
                rating.Friendly = ratingViewModel.Friendly;
                rating.RatingDate = ratingViewModel.RatingDate;

                _db.Ratings.Add(rating);
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }


        // *********** My Settigs Starts ************ //
        public UserDetailsViewModel GetUserDetails(int id)
        {
            UserDetailsViewModel user = new UserDetailsViewModel();

            User r = _db.Users.Where(x => x.UserId == id).FirstOrDefault();
            user.FirstName = r.FirstName;
            user.LastName = r.LastName;
            user.Mobile = r.Mobile;
            user.Email = r.Email;

            if(r.DateOfBirth == null)
            {
                DateTime d = new DateTime(2000, 01, 01);
                user.DateOfBirth = d;
            }
            else
            {
                user.DateOfBirth = (DateTime)r.DateOfBirth;
            }

            return user;
        }
        public List<UserAddressViewModel> GetAllUserAddressById(int id)
        {
            List<UserAddressViewModel> results = new List<UserAddressViewModel>();

            List<UserAddress> arr = _db.UserAddresses.Where(x=> x.UserId == id).ToList();
            foreach(var item in arr)
            {
                UserAddressViewModel u = new UserAddressViewModel();

                u.AddressId = item.AddressId;
                u.AddressLine1 = item.AddressLine1;
                u.AddressLine2 = item.AddressLine2;
                u.City = item.City;
                u.Email = item.Email;
                u.Mobile = item.Mobile;
                u.PostalCode = item.PostalCode;

                results.Add(u);
            }

            return results;
        }
        public bool SaveUserDetails(UserDetailsViewModel userDetailsViewModel)
        {

            User u = _db.Users.Where(x => x.UserId == userDetailsViewModel.UserId).FirstOrDefault();

            try
            {
                u.FirstName = userDetailsViewModel.FirstName;
                u.LastName = userDetailsViewModel.LastName;
                u.DateOfBirth = userDetailsViewModel.DateOfBirth;
                u.Mobile = userDetailsViewModel.Mobile;

                _db.SaveChanges();

                return true;
            }
            catch {
                return false;
            }
        }

        public object GetAddreesById(int addressId)
        {
            UserAddressViewModel address = new UserAddressViewModel();

            try
            {
                UserAddress a = _db.UserAddresses.Where(x => x.AddressId == addressId).FirstOrDefault();
                address.AddressId = a.AddressId;
                address.AddressLine1 = a.AddressLine1;
                address.AddressLine2 = a.AddressLine2;
                address.PostalCode = a.PostalCode;
                address.City = a.City;
                address.Mobile = a.Mobile;

                return address;
            }
            catch
            {
                return null;
            }

        }

        public bool SaveUpdatedAddress(UserAddressViewModel userAddressViewModel)
        {

            try {

                if (userAddressViewModel.AddressId == -1)
                {
                    UserAddress userAddress = new UserAddress();

                    userAddress.AddressLine1 = userAddressViewModel.AddressLine1;
                    userAddress.AddressLine2 = userAddressViewModel.AddressLine2;
                    userAddress.PostalCode = userAddressViewModel.PostalCode;
                    userAddress.Mobile = userAddressViewModel.Mobile;
                    userAddress.Email = userAddressViewModel.Email;
                    userAddress.City = userAddressViewModel.City;
                    userAddress.UserId = (int)userAddressViewModel.UserId;

                    _db.UserAddresses.Add(userAddress);
                    _db.SaveChanges();

                }
                else
                {
                    UserAddress userAddress = _db.UserAddresses.Where(x => x.AddressId == userAddressViewModel.AddressId).FirstOrDefault();

                    userAddress.AddressLine1 = userAddressViewModel.AddressLine1;
                    userAddress.AddressLine2 = userAddressViewModel.AddressLine2;
                    userAddress.PostalCode = userAddressViewModel.PostalCode;
                    userAddress.Mobile = userAddressViewModel.Mobile;
                    userAddress.Email = userAddressViewModel.Email;
                    userAddress.City = userAddressViewModel.City;
                    _db.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteAddress(int addressId)
        {
            try
            {
                UserAddress u = _db.UserAddresses.Where(x => x.AddressId == addressId).FirstOrDefault();
                _db.UserAddresses.Remove(u);
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean ChangePassword(ChangePasswordViewModel changePasswordViewModel, int userId)
        {

            try
            {
                User u = _db.Users.Where(x => x.UserId == userId && x.Password == changePasswordViewModel.OldPassword).FirstOrDefault();
                u.Password = changePasswordViewModel.NewPassword;

                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
