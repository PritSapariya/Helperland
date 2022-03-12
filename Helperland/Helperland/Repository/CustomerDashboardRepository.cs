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
                List<ServiceRequest> allService = _db.ServiceRequests.Where(x => x.UserId == userId && x.Status == ConstantString.StatusPending).ToList();
                
                foreach (ServiceRequest item in allService)
                {
                    CurrentServiceRequestViewModel result = new CurrentServiceRequestViewModel();


                    result.ServiceProviderId = item.ServiceProviderId;
                    if (item.ServiceProviderId != null)
                    {
                        User sp = _db.Users.Where(s => s.UserId == item.ServiceProviderId && s.UserTypeId == ConstantString.ServiceTypeId ).FirstOrDefault();
                        result.ServiceProviderName = sp.FirstName + " " + sp.LastName;
                        result.ServiceProviderAvatar = sp.UserProfilePicture;
                    }
                    result.ServiceRequestId = item.ServiceRequestId;
                    result.ServiceStartDate = item.ServiceStartDate;
                    result.ServiceHours = item.ServiceHours;
                    result.ExtraHours = item.ExtraHours;
                    result.TotalCost = item.TotalCost;

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

                if (serviceRequest.ServiceProviderId != null)
                {
                    User sp = _db.Users.Where(s => s.UserId == serviceRequest.ServiceRequestId && s.UserTypeId == ConstantString.ServiceTypeId).FirstOrDefault();
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
    }
}
