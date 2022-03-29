using Helperland.Models.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel.ServiceProvider
{
    public class ServiceProviderSettingsViewModel
    {

        public ServiceProviderSettingsViewModel()
        {
            UserAddresses = new HashSet<UserAddress>();
        }

        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter your First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter your Last Name")]
        public string LastName { get; set; }
       
        public string Email { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter your Mobile Number")]
        public string Mobile { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateOfBirth {
            get; set;
        }
        public string UserProfilePicture
        {
            get; set;
        }
        public bool? IsRegisteredUser { get; set; }
        
        [Required(ErrorMessage = "Enter Zipcode")]
        public string ZipCode { get; set; }
        public bool? WorksWithPets { get; set; }

        public DateTime? CreatedDate { get {
                return DateTime.Now;
            } }
        public DateTime? ModifiedDate {
            get; set;
        }
        public int? ModifiedBy { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Status { get; set; }

        public int AddressId { get; set; }
        [Required(ErrorMessage = "Enter adddress line")]
        public string AddressLine1 { get; set; }
        [Required(ErrorMessage = "Enter adddress line")]
        public string AddressLine2 { get; set; }
        public string City { get; set; }



        public virtual ICollection<UserAddress> UserAddresses { get; set; }

    }
}
