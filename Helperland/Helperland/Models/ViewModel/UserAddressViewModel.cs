using Helperland.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel
{
    public class UserAddressViewModel
    {

        public int AddressId { get; set; }

        [Required(ErrorMessage = "Please enter valid details")]
        public int? UserId { get; set; }

        [Required(ErrorMessage = "Please enter valid details", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Please enter valid details", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter City Name", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string City { get; set; }

        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a Postal Code")]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Please enter a valid postal code")]
        public string PostalCode { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }

        [Required(ErrorMessage = "Please enter a Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid Mobile Number")]
        public string Mobile { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }




    }
}
