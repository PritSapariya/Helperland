using Helperland.Models.DBModels;
using Helperland.Models.ViewModel.ServiceProvider;
using Helperland.Models.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface IServiceProviderRepository
    {
        List<ServiceRequest> GetAllNewServiceRequest(String includePets, string includePets1, int? v);
        object AssignServiceRequest(int serviceId, int userId);
        ServiceRequest GetServiceDetailsById(int serviceId);
        dynamic GetCountOfNewService(string postalCode, int? id);
        dynamic GetCountOfUpcomingService(int? v);
        public List<ServiceRequest> GetAllUpcomingService(int? id);
        public void CancelServiceById(int serviceId);
        public void CompleteServiceById(int serviceId);
        public List<ServiceRequest> GetAllCompletedService(int? id);
        public List<ServiceRequest> GetAllCustomer(int? id);

        public bool BlockCustomerById(int UserId, int serviceProviderId);
        bool ChangePassword(ChangePasswordViewModel changePasswordViewModel, int userId);
        public ServiceProviderSettingsViewModel GetUserDetailsById(int? v);
        public Boolean SaveDetails(ServiceProviderSettingsViewModel user);
        public List<Rating> GetServiceHistory(int? id);
    }
}
