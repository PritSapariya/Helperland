using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel.Admin;
using Helperland.Repository.IRepository;
using Helperland.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly HelperlandContext _db;

        public AdminRepository(HelperlandContext _db)
        {
            this._db = _db;
        }

        public List<ServiceRequest> GetAllServiceRequest()
        {
            List<ServiceRequest> result = _db.ServiceRequests.Include(s => s.ServiceProvider).Include(s => s.User).Include(s => s.ServiceRequestAddresses).ToList();
            return result;
        }

        public bool Active(int? id)
        {
            try
            {
                User user = _db.Users.Where(x => x.UserId == id).FirstOrDefault();
                user.IsActive = true;
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Approve(int? id)
        {
            try
            {
                User user = _db.Users.Where(x => x.UserId == id).FirstOrDefault();
                user.IsActive = true;
                user.IsApproved = true;
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Deactive(int? id)
        {
            try
            {
                User user = _db.Users.Where(x => x.UserId == id).FirstOrDefault();
                user.IsActive = false;
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> GetAllUser(int? id)
        {
            List<User> result = _db.Users.Where(x => x.UserId != id).ToList();
            return result;
        }

        public List<string> GetAllUserName(int? id)
        {

            List<String> result = GetAllUser(id).Select(x => (x.FirstName + " " + x.LastName)).ToList();
            return result;
        }

        public Dictionary<int, decimal> GetAllSPRating()
        {
            Dictionary<int, decimal> result = new Dictionary<int, decimal>();

            List<int> serviceProviders = _db.Users.Where(x => x.UserTypeId == ConstantString.ServiceTypeId).Select(x => x.UserId).ToList();

            foreach(int i in serviceProviders)
            {
                decimal rating;

                int count = _db.Ratings.Where(x => x.RatingTo == i).Select(x => x.Ratings).Count();
                decimal sum = _db.Ratings.Where(x => x.RatingTo == i).Select(x => x.Ratings).Sum();

                if(count == 0)
                {
                    rating = 0;
                }
                else
                {
                    rating = (sum / count);
                    rating = decimal.Round(rating, 2);
                }

                result.Add(i, rating);
            }

            return result;
        }

        public List<string> GetAllCustomerName(int? id)
        {
            List<String> result = GetAllUser(id).Where(x => x.UserTypeId == ConstantString.CustomerTypeId).Select(x => (x.FirstName + " " + x.LastName)).ToList();
            return result;
        }

        public List<string> GetAllSPName(int? id)
        {
            List<String> result = GetAllUser(id).Where(x => x.UserTypeId == ConstantString.ServiceTypeId).Select(x => (x.FirstName + " " + x.LastName)).ToList();
            return result;
        }

        public CustomServiceRequestViewModel GetServiceDetailsById(int? serviceId)
        {
            ServiceRequest service = _db.ServiceRequests.Where(x => x.ServiceRequestId == serviceId).Include(s => s.ServiceRequestAddresses).FirstOrDefault();

            CustomServiceRequestViewModel result = new CustomServiceRequestViewModel();
            result.ServiceRequestId = service.ServiceRequestId;
            result.ServiceStartDate = service.ServiceStartDate;
            result.ZipCode = service.ZipCode;
            result.AddressLine1 = service.ServiceRequestAddresses.First().AddressLine1;
            result.AddressLine2 = service.ServiceRequestAddresses.First().AddressLine2;

            int hour = service.ServiceStartDate.Hour;
            int minute = service.ServiceStartDate.Minute;

            if(minute == 0)
            {
                result.Time = hour;
            }
            else
            {
                result.Time = (decimal)(hour + 0.5);
            }
            

            return result;
        }

        public void SaveDetails(CustomServiceRequestViewModel model)
        {
            DateTime temp;
            ServiceRequest service = _db.ServiceRequests.Where(x => x.ServiceRequestId == model.ServiceRequestId).Include(s => s.ServiceRequestAddresses).FirstOrDefault();
           
            temp = model.ServiceStartDate.AddHours(System.Convert.ToDouble(model.Time));

            service.ServiceStartDate = temp;
            service.ServiceRequestAddresses.First().AddressLine1 = model.AddressLine1;
            service.ServiceRequestAddresses.First().AddressLine2 = model.AddressLine2;

            _db.SaveChanges();
        }

        public void CancelServiceById(int? id)
        {
            ServiceRequest service = _db.ServiceRequests.Where(s => s.ServiceRequestId == id).FirstOrDefault();
            service.Status = ConstantString.StatusCancelled;

            _db.SaveChanges();
        }
    }
}
