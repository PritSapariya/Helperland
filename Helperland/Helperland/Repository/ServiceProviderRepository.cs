using Helperland.Models.DBModels;
using Helperland.Models.DBModels.Data;
using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.Customer;
using Helperland.Repository.IRepository;
using Helperland.Utilities;
using Microsoft.AspNetCore.Http;
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
        public List<ServiceRequest> GetAllNewServiceRequest(String PostalCode,String includePets, int? id)
        {
            List<ServiceRequest> service = new List<ServiceRequest>();

            service = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceProviderId == null && s.Status == 1 && s.ServiceStartDate > DateTime.Now && s.ZipCode == PostalCode).ToList();

            // Remoing Blocked Customer Service Request

            List<int> blockedId = _db.FavoriteAndBlockeds.Where(x => x.UserId == id).Select(x => x.TargetUserId).ToList();

            foreach (int i in blockedId)
            {
                service.RemoveAll(r => r.UserId == i);
            }



            if (includePets == "true")
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

        public dynamic GetCountOfNewService(string postalCode, int? id)
        {
            List<ServiceRequest> service = new List<ServiceRequest>();

            service = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceProviderId == null && s.Status == 1 && s.ServiceStartDate > DateTime.Now && s.ZipCode == postalCode).ToList();

            // Remoing Blocked Customer Service Request

            List<int> blockedId = _db.FavoriteAndBlockeds.Where(x => x.UserId == id).Select(x => x.TargetUserId).ToList();

            foreach (int i in blockedId)
            {
                service.RemoveAll(r => r.UserId == i);
            }

            return service.Count();
        }

        public dynamic GetCountOfUpcomingService(int? v)
        {
            int result = _db.ServiceRequests.Where(x => x.ServiceProviderId == v && x.Status == ConstantString.StatusAssigned && x.ServiceStartDate >= DateTime.Now).ToList().Count();

            return result;
        }

        public List<ServiceRequest> GetAllUpcomingService(int? id)
        {
            List<ServiceRequest> result = new List<ServiceRequest>();

            result = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceProviderId == id && s.Status == ConstantString.StatusAssigned && s.ServiceStartDate >= DateTime.Now).ToList();

            return result;
        }

        public void CancelServiceById(int serviceId)
        {
            ServiceRequest service = _db.ServiceRequests.Where(x => x.ServiceRequestId == serviceId).FirstOrDefault();
            service.Status = ConstantString.StatusCancelled;
            _db.SaveChanges();
        }

        public void CompleteServiceById(int serviceId)
        {
            ServiceRequest service = _db.ServiceRequests.Where(x => x.ServiceRequestId == serviceId).FirstOrDefault();
            service.Status = ConstantString.StatusCompleted;
            _db.SaveChanges();
        }

        public List<ServiceRequest> GetAllCompletedService(int? id)
        {
            List<ServiceRequest> result;

            result = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceProviderId == id && s.Status == ConstantString.StatusCompleted).ToList();

            return result;
        }

        public List<ServiceRequest> GetAllCustomer(int? id)
        {
            List<ServiceRequest> result;

            result = _db.ServiceRequests.Include(s => s.ServiceProvider)
                                        .Include(s => s.User)
                                        .Include(s => s.ServiceRequestAddresses)
                                        .Include(s => s.ServiceRequestExtras).AsSplitQuery()
                                        .Where(s => s.ServiceProviderId == id && s.Status == ConstantString.StatusCompleted).ToList();

            List<int> blockedId = _db.FavoriteAndBlockeds.Where(x => x.UserId == id).Select(x => x.TargetUserId).ToList();

            foreach(int i in blockedId)
            {
                result.RemoveAll(r => r.UserId == i);
            }

            return result;
        }

       
        public bool BlockCustomerById(int UserId, int serviceProviderId)
        {
            try
            {
                FavoriteAndBlocked f = new FavoriteAndBlocked();

                f.UserId = serviceProviderId;
                f.TargetUserId = UserId;
                f.IsBlocked = true;
                f.IsFavorite = false;

                _db.FavoriteAndBlockeds.Add(f);
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
