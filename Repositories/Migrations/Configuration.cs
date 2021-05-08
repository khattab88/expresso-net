namespace Repositories.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Repositories.ExpressoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Repositories.ExpressoDbContext context)
        {
           
            //var countries = new List<Country>
            //{
            //    new Country 
            //    { 
            //        Name = "Egypt", Slug = "egypt", Alias = "EGY", Currency = "EGP",
            //        Cities = new List<City> 
            //        {
            //            new City 
            //            {
            //                Name = "Cairo", Slug = "cairo",
            //                Areas = new List<Area> 
            //                {
            //                    new Area { Name = "Heliopolis", Slug = "heliopolis" },
            //                    new Area { Name = "Maadi", Slug = "maadi" },
            //                    new Area { Name = "DownTown", Slug = "downtown" },
            //                    new Area { Name = "Nasr City", Slug = "nasr-city" },
            //                }
            //            },
            //            new City 
            //            { 
            //                Name = "Giza", Slug = "giza",
            //                Areas = new List<Area> 
            //                {
            //                    new Area { Name = "Mohandesen", Slug = "mohandesen" },
            //                    new Area { Name = "Haram", Slug = "haram" },
            //                    new Area { Name = "Dokki", Slug = "dokki" },
            //                    new Area { Name = "6th October", Slug = "6th-october" },
            //                }
            //            },
            //        }
            //    },
            //    new Country { Name = "UAE", Slug = "uae", Alias = "uae", Currency = "AED" },
            //    new Country { Name = "Saudi Arabia", Slug = "saudi-arabia", Alias = "SAUDI", Currency = "SAR" },
            //};


            //foreach (var country in countries)
            //{
            //    context.Countries.AddOrUpdate(country);

            //    foreach (var city in country.Cities)
            //    {
            //        // city.CountryId = country.Id;
            //        context.Cities.AddOrUpdate(city);

            //        foreach (var area in city.Areas)
            //        {
            //            // area.CityId = city.Id;
            //            context.Areas.AddOrUpdate(area);
            //        }
            //    }
            //}

        }
    }
}
