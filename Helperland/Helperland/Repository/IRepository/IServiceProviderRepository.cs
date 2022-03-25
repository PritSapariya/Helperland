using Helperland.Models.DBModels;
using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface IServiceProviderRepository
    {
        object GetAllNewServiceRequest(String includePets, string includePets1);
        object AssignServiceRequest(int serviceId, int userId);
        ServiceRequest GetServiceDetailsById(int serviceId);
        dynamic GetCountOfNewService(string postalCode);
        dynamic GetCountOfUpcomingService(int? v);
        public List<ServiceRequest> GetALlUpcomingService(int? id);
    }
}
