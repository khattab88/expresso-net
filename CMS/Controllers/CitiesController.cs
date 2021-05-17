using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CMS.ViewModels;
using Models;
using Slugify;

namespace CMS.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ExpressoDbContext _context;

        public CitiesController()
        {
            _context = new ExpressoDbContext();
        }

        // GET: Cities
        public ActionResult Index()
        {
            var cities = _context.Cities.Include(c => c.Country).ToList();

            return View(cities);
        }

        public ActionResult New() 
        {
            var countries = _context.Countries.ToList();

            var cityViewModel = new CityViewModel
            {
                Countries = countries
            };

            return View("CityForm", cityViewModel);
        }

        public ActionResult Edit(string id) 
        {
            var city = _context.Cities.SingleOrDefault(c => c.Id.ToString() == id);

            if (city == null)
                return HttpNotFound();

            var cityViewModel = new CityViewModel
            {
                City = city,
                Countries = _context.Countries.ToList()
            };

            return View("CityForm", cityViewModel);
        }

        [HttpPost]
        public ActionResult Save(City city)
        {
            var slug = new SlugHelper().GenerateSlug(city.Name);


            if (city.Id == Guid.Empty)
            {
                city.Slug = slug;

                _context.Cities.Add(city);
            }
            else
            {
                var existingCity = _context.Cities.Single(c => c.Id == city.Id);

                existingCity.Name = city.Name;
                existingCity.Slug = slug;
                existingCity.CountryId = city.CountryId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Cities");
        }
    }
}