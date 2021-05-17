using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class CityViewModel
    {
        public City City { get; set; }

        public IEnumerable<Country> Countries { get; set; }
    }
}