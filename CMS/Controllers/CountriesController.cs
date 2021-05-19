using CMS.Helpers;
using CMS.ViewModels;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ExpressoDbContext _context;

        public CountriesController()
        {
            _context = new ExpressoDbContext();
        }

        // GET: Countries
        public ActionResult Index()
        {
            var countries = _context.Countries.ToList();

            return View(countries);
        }

        public ActionResult New() 
        {
            var countryViewModel = new CountryViewModel();

            return View("CountryForm", countryViewModel);
        }

        public ActionResult Edit(string id) 
        {
            var country = _context.Countries.SingleOrDefault(c => c.Id.ToString() == id);

            if (country == null)
                return HttpNotFound();

            var countryViewModel = new CountryViewModel(country);


            return View("CountryForm", countryViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Country country, IList<HttpPostedFileBase> files) 
        {
            if (!ModelState.IsValid) 
            {
                var countryViewModel = new CountryViewModel(country);

                return View("CountryForm", countryViewModel);
            }


            // generate base64 string for image
            string base64String = "";
            if (files[0] != null)
            {
                string folder = Server.MapPath("~/Content/Images/Uploads/");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                base64String = ImageHelper.GenerateBase64String(folder, files[0]);
            }

            // create slug
            var slug = SlugHelper.Generate(country.Name);

            if (country.Id == Guid.Empty)
            {
                country.Image = base64String;
                country.Slug = slug;

                _context.Countries.Add(country);
            }
            else 
            {
                var existingCountry = _context.Countries.Single(c => c.Id == country.Id);

                existingCountry.Name = country.Name;
                existingCountry.Slug = slug;
                existingCountry.Alias = country.Alias;
                existingCountry.Currency = country.Currency;
                existingCountry.Image = base64String;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Countries");
        }
    }
}