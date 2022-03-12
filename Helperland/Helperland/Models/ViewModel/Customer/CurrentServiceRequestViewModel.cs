using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel.Customer
{
    public class CurrentServiceRequestViewModel
    {
        public int ServiceRequestId { get; set; }

        public DateTime ServiceStartDate { get; set; }
        public double? ServiceHours { get; set; }
        public double? ExtraHours { get; set; }
        public string ZipCode { get; set; }
        public decimal? TotalCost { get; set; }
        public string Comments { get; set; }
        public int? ServiceProviderId { get; set; }
        public string ServiceProviderName { get; set; }
        public decimal? ServiceProviderRating { get; set; }
        public string ServiceProviderAvatar { get; set; }
        public bool HasPets { get; set; }

        public int? AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public List<int> ExtraServiceId { get; set; }

    }
}
