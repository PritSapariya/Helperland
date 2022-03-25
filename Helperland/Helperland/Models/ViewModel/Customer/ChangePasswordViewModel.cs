using Helperland.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel.Customer
{
    public class ChangePasswordViewModel
    {
        [Required]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter a old Password")]
        [DataType(DataType.Password)]
        [PasswordValidation(ErrorMessage = "Password must have 8 characters including capital, small and digit")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Please enter a new Password")]
        [DataType(DataType.Password)]
        [PasswordValidation(ErrorMessage = "Password must have 8 characters including capital, small and digit")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Please enter confirm password!")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Confirm Password and Password must be the same")]
        public string ConfirmPassword { get; set; }

    }
}
