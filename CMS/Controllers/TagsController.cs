using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class TagsController : Controller
    {
        private readonly ExpressoDbContext _context;

        public TagsController()
        {
            _context = new ExpressoDbContext();
        }

        // GET: Tags
        public ActionResult Index()
        {
            var tags = _context.Tags.ToList();

            return View(tags);
        }

        public ActionResult New() 
        {
            return View();
        }

        public ActionResult Edit(string id) 
        {
            var tag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

            if (tag == null)
                return HttpNotFound();

            return View(tag);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


    }
}