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
    public class AreasController : Controller
    {
        private readonly ExpressoDbContext _context;

        public AreasController()
        {
            _context = new ExpressoDbContext();
        }

        public ActionResult Index()
        {
            var areas = _context.Areas.Include(a => a.City).ToList();

            return View(areas);
        }

        public ActionResult New() 
        {
            var cities = _context.Cities.ToList();

            var areaViewModel = new AreaViewModel
            {
                Cities = cities
            };

            return View("AreaForm", areaViewModel);
        }

        public ActionResult Edit(string id) 
        {
            var area = _context.Areas.Single(a => a.Id.ToString() == id);

            if (area == null)
                return HttpNotFound();

            var areaViewModel = new AreaViewModel(area) 
            {
                Cities = _context.Cities.ToList()
            };

            return View("AreaForm", areaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Area area) 
        {
            if (!ModelState.IsValid) 
            {
                var areaViewModel = new AreaViewModel(area) 
                {
                    Cities = _context.Cities.ToList()
                };

                return View("AreaForm", areaViewModel);
            }

            var slug = new SlugHelper().GenerateSlug(area.Name);

            if (area.Id == Guid.Empty)
            {
                area.Slug = slug;

                _context.Areas.Add(area);
            }
            else 
            {
                var existingArea = _context.Areas.Single(a => a.Id == area.Id);

                existingArea.Name = area.Name;
                existingArea.Slug = slug;
                existingArea.CityId = area.CityId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Areas");
        }
    }
}