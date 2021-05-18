using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class AreaViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid CityId { get; set; }

        public IEnumerable<City> Cities { get; set; }

        public AreaViewModel()
        {
            Id = Guid.Empty;
        }

        public AreaViewModel(Area area)
        {
            Id = area.Id;
            Name = area.Name;
            CityId = area.CityId;
        }
    }
}