using Helperland.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel.BookNow
{
    public class ServiceRequestViewModel
    {
        public int ServiceRequestId { get; set; }
        [Required]
        public int? UserId { get; set; }
        [Required]
        public DateTime ServiceStartDate { get; set; }
        public double ServiceHours { get; set; }
        public double? ExtraHours { get; set; }
        [Required]
        public string ZipCode { get; set; }
        public decimal? TotalCost { get; set; }
        public string Comments { get; set; }
        [Required]
        public bool HasPets { get; set; }
        public int? AddressID { get; set; }
        public List<int> ExtraServiceId { get; set; }

        public DateTime CreatedDate { 
            get { return DateTime.Now; } 
        }
    }
}
