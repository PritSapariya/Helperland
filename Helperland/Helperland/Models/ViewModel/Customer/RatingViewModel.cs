using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel.Customer
{
    public class RatingViewModel
    {
        public int RatingId { get; set; }

        [Required]
        public int ServiceRequestId { get; set; }
        [Required]
        public int RatingFrom { get; set; }
        [Required]
        public int RatingTo { get; set; }
        [Required]
        public decimal Ratings { get; set; }
        [Required]
        public string Comments { get; set; }
        public DateTime RatingDate { get { return DateTime.Now; } }
        
        [Required]
        public decimal OnTimeArrival { get; set; }
        
        [Required]
        public decimal Friendly { get; set; }
        
        [Required]
        public decimal QualityOfService { get; set; }

    }
}
