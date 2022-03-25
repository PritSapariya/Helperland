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
        public List<CurrentServiceRequestViewModel> GetServiceRequestHistory(int userId);
        public CurrentServiceRequestViewModel GetServiceRequestDetailByServiceId(int serviceId);
        public String GetDateTimeById(int serviceId);
        public Boolean RescheduleServiceRequest(int serviceId, DateTime newDateAndTime);
        public Boolean CancelServiceRequest(int serviceId, String Boolean);
        public Boolean SetServiceRating(RatingViewModel ratingViewModel);
        public UserDetailsViewModel GetUserDetails(int id);
        public List<UserAddressViewModel> GetAllUserAddressById(int id);
        bool SaveUserDetails(UserDetailsViewModel userDetailsViewModel);
        object GetAddreesById(int addressId);
        bool SaveUpdatedAddress(UserAddressViewModel userAddressViewModel);
        bool DeleteAddress(int addressId);
        Boolean ChangePassword(ChangePasswordViewModel changePasswordViewModel, int userId);
    }
}
