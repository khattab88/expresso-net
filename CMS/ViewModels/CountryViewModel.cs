using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class CountryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Alias { get; set; }
        public string Currency { get; set; }
        public string Image { get; set; }

        public CountryViewModel()
        {
            Id = Guid.Empty;
        }

        public CountryViewModel(Country country)
        {
            Id = country.Id;
            Name = country.Name;
            Alias = country.Alias;
            Currency = country.Currency;
            Image = country.Image;
        }
    }
}