using Helperland.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel
{
    public class LoginViewModel
    {
        public int userId { get; set; }

        [Required(ErrorMessage = "Please enter an Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter a Password")]
        [DataType(DataType.Password)]
        [PasswordValidation(ErrorMessage = "Password must have 8 characters including capital, small and digit")]
        public string Password { get; set; }

    }
}
