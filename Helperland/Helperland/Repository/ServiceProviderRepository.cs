using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.Customer;
using Helperland.Repository.IRepository;
using Helperland.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Helperland.Repository
{


    public class ServiceProviderRepository : IServiceProviderRepository
    {
        private readonly HelperlandContext _db;
        private String Message;

        public ServiceProviderRepository(HelperlandContext _db)
        {
            this._db = _db;
        }


        public string GetErrorMessage()
        {
            return Message;
        }


        // ************* New Service Request ************* //
        public object GetAllNewServiceRequest(String PostalCode,String includePets)
        {
            List<ServiceRequest> service = new List<ServiceRequest>();

            service = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceProviderId == null && s.Status == 1 && s.ServiceStartDate > DateTime.Now && s.ZipCode == PostalCode).ToList();

            if(includePets == "true")
            {
                return service;
            }
            else
            {
                service = service.Where(s => s.HasPets == false).ToList();
                return service;
            }
           
        }

        public object AssignServiceRequest(int serviceId, int userId)
        {
            ServiceRequest service = new ServiceRequest();

            service = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceRequestId == serviceId && s.Status == ConstantString.StatusPending).FirstOrDefault();

            if(service == null)
            {
                return false;
            }


            User sp = _db.Users.Where(x => x.UserId == userId).FirstOrDefault();

            service.ServiceProvider = sp;
            service.Status = ConstantString.StatusAssigned;
            service.ServiceProviderId = userId;

            _db.SaveChanges();

            return true;
            
        }

        public ServiceRequest GetServiceDetailsById(int serviceId)
        {
            ServiceRequest result = new ServiceRequest();

            result = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceRequestId == serviceId).FirstOrDefault();

            return result;

        }

        public dynamic GetCountOfNewService(string postalCode)
        {
            int result = _db.ServiceRequests.Where(x => x.ServiceProviderId == null && x.ZipCode == postalCode && x.Status == ConstantString.StatusPending && x.ServiceStartDate >= DateTime.Now).ToList().Count();

            return result;
        }

        public dynamic GetCountOfUpcomingService(int? v)
        {
            int result = _db.ServiceRequests.Where(x => x.ServiceProviderId == v && x.Status == ConstantString.StatusAssigned && x.ServiceStartDate >= DateTime.Now).ToList().Count();

            return result;
        }

        public List<ServiceRequest> GetALlUpcomingService(int? id)
        {
            List<ServiceRequest> result = new List<ServiceRequest>();

            result = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceProviderId == id && s.Status == ConstantString.StatusAssigned && s.ServiceStartDate >= DateTime.Now).ToList();

            return result;
        }
    }
}
