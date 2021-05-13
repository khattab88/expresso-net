using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    public class TagsController : ApiController
    {
        private readonly ExpressoDbContext _context;

        public TagsController()
        {
            _context = new ExpressoDbContext();
        }

        // GET: Tags
        public IHttpActionResult Get()
        {
            var tags = _context.Tags.ToList();

            return Ok(tags);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();

            base.Dispose(disposing);
        }
    }
}