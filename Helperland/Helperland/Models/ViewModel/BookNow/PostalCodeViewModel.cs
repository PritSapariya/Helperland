using Helperland.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Helperland.Models.ViewModel.BookNow
{
    public class PostalCodeViewModel
    {

        [Required(ErrorMessage = "Please enter a postal code")]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Please enter a valid postal code")]
        public int PostalCode { get; set; }

    }
}
