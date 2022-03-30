using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel.Admin
{
    public class CustomServiceRequestViewModel
    {

        public int ServiceRequestId { get; set; }
        public int? UserId { get; set; }
        public DateTime ServiceStartDate { get; set; }
        public decimal Time { get; set; }
        public string ZipCode { get; set; }
        public int? ServiceProviderId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Reason { get; set; }
    }
}
