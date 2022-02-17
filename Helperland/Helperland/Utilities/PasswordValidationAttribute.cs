using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Utilities
{
    public class PasswordValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            string s = obj.ToString();

            // Logic for checking 
            // 1. String must have at least 8 characters
            // 2. String must have combination of Upper and Lower case
            // 3. String must have at least 1 Number digit

            if (s.Length < 8)
                return false;
            else if (!s.Any(char.IsLower))
                return false;
            else if (!s.Any(char.IsUpper))
                return false;
            else if (!s.Any(char.IsDigit))
                return false;
            else
                return true;

        }
    }
}
