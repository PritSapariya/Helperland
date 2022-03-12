using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface ICustomerDashboardRepository
    {
        public List<CurrentServiceRequestViewModel> GetAllCurrentServiceRequest(int userId);
        public CurrentServiceRequestViewModel GetServiceRequestDetailByServiceId(int serviceId);
        public String GetDateTimeById(int serviceId);
    }
}
