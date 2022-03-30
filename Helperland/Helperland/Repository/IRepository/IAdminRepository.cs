using Helperland.Models.DBModels;
using Helperland.Models.ViewModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface IAdminRepository
    {
        public List<ServiceRequest> GetAllServiceRequest();
        public CustomServiceRequestViewModel GetServiceDetailsById(int? serviceId);
        public void SaveDetails(CustomServiceRequestViewModel model);
        public Dictionary<int, decimal> GetAllSPRating();
        public List<User> GetAllUser(int? id);
        public List<String> GetAllUserName(int? id);
        public void CancelServiceById(int? id);

        public List<String> GetAllCustomerName(int? id);
        public List<String> GetAllSPName(int? id);
        public Boolean Active(int? id);
        public Boolean Deactive(int? id);
        public Boolean Approve(int? id);
    }
}
