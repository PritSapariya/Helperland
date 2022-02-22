using Helperland.Models.ViewModel;
using Helperland.Models.ViewModel.BookNow;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository.IRepository
{
    public interface IBookNowRepository
    {
        public Boolean CheckAvailabilityOfPostalCode ( PostalCodeViewModel postalCodeViewModel );

    }
}
