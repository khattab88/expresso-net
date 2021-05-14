using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class TagsController : Controller
    {
        // GET: Tags
        public ActionResult Index()
        {
            var tags = new List<Tag> 
            {
                new Tag { Name = "Offers" },
                new Tag { Name = "American" }
            };

            return View(tags);
        }

        

    }
}