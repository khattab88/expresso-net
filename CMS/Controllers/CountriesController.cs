using Repositories;
using System;
using System.Collections.Generic;
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
            return View();
        }

        public ActionResult Edit(string id) 
        {
            var country = _context.Countries.SingleOrDefault(c => c.Id.ToString() == id);

            if (country == null)
                return HttpNotFound();

            return View(country);
        }
    }
}