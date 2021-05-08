using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linq

            var context = new ExpressoDbContext();


            // Query syntax
            //var query =
            //    from a in context.Areas
            //    where a.Slug.Contains("h")
            //    orderby a.Name
            //    select a;

            //foreach (var area in query)
            //    Console.WriteLine(area.Name);

            // -----------------------------------------------------------;

            // Extension methods syntax
            //var areas = context.Areas
            //    .Where(a => a.Name.Contains("h"))
            //    .OrderBy(a => a.City.Name)
            //    .ThenByDescending(a => a.Name)
            //    .Select(a => new { Area = a.Name, City = a.City.Name });

            //foreach (var area in areas)
            //    Console.WriteLine(area);

            // -----------------------------------------------------------;

            //var city = context.Cities.Include(c => c.Areas).FirstOrDefault();
            //Console.WriteLine(city.Name);

            //foreach (var area in city.Areas)
            //{
            //    Console.WriteLine("\t {0}", area.Name);
            //}

            // -----------------------------------------------------------;

            // var country = context.Countries.FirstOrDefault();

            //var newCity = new City 
            //{
            //    Name = "Alexandria",
            //    Slug = "alexandria",
            //    CountryId = country.Id
            //};

            //context.Cities.Add(newCity);

            // var city = context.Cities.Single(c => c.Name.Contains("Alex"));

            //city.Slug = "alexandria";

            // context.Cities.Remove(city);

            // context.SaveChanges();

            // -----------------------------------------------------------;



            #endregion



        }
    }
}
