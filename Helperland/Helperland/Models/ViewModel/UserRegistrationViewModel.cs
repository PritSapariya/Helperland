using Helperland.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel
{
    public class UserRegistrationViewModel
    {
        [Required(ErrorMessage = "Please enter a First Name", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid Mobile Number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        [DataType(DataType.Password)]
        [PasswordValidation(ErrorMessage = "Password must have 8 characters including capital, small and digit")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm Password and Password must be the same")]
        public string ConfirmPassword { get; set; }


    }
}
