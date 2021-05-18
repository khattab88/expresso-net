using CMS.ViewModels;
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
            var tagViewModel = new TagViewModel();

            return View("TagForm", tagViewModel);
        }

        public ActionResult Edit(string id) 
        {
            var tag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

            if (tag == null)
                return HttpNotFound();

            var tagViewModel = new TagViewModel(tag);

            return View("TagForm", tagViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Tag tag) 
        {
            if (!ModelState.IsValid) 
            {
                var tagViewModel = new TagViewModel(tag);

                return View("TagForm", tagViewModel);
            }

            if (tag.Id == Guid.Empty)
            {
                _context.Tags.Add(tag);
            }
            else 
            {
                var existingTag = _context.Tags.Single(t => t.Id == tag.Id);

                existingTag.Name = tag.Name;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Tags");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


    }
}