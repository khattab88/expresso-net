using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class CityViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid CountryId { get; set; }

        public IEnumerable<Country> Countries { get; set; }


        public CityViewModel()
        {
            Id = Guid.Empty;
        }

        public CityViewModel(City city)
        {
            Id = city.Id;
            Name = city.Name;
            CountryId = city.CountryId;
        }
    }
}