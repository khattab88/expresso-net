using Repositories;
using Repositories.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExpressoDbContext _context;
        // private readonly IUnitOfWork _unitOfWork;

        public HomeController()
        // public HomeController(IUnitOfWork unitOfWork)
        {
            _context = new ExpressoDbContext();
            // _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var tags = _context.Tags.ToList();
            // var tags = _unitOfWork.Tags.GetAll();

            return View(tags);
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();

            base.Dispose(disposing);
        }
    }
}