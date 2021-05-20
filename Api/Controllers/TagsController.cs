using Marvin.JsonPatch;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace Api.Controllers
{
    public class TagsController : ApiController
    {
        private readonly ExpressoDbContext _context;

        public TagsController()
        {
            _context = new ExpressoDbContext();
        }


        public IHttpActionResult Get()
        {
            try
            {
                var tags = _context.Tags.ToList();

                return Ok(tags);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Get(string id) 
        {
            try
            {
                var tag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

                if (tag == null)
                    return NotFound();

                return Ok(tag);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [ResponseType(typeof(Tag))]
        public IHttpActionResult Create(Tag tag) 
        {
            try
            {
                if (tag == null || !ModelState.IsValid)
                    return BadRequest();

                _context.Tags.Add(tag);
                _context.SaveChanges();

                return Created(string.Format("{0}/{1}", Request.RequestUri, tag.Id), tag);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult Update(string id, Tag tag)
        {
            try
            {
                if (tag == null || !ModelState.IsValid || id != tag.Id.ToString())
                {
                    return BadRequest();
                }

                var existingTag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

                if (existingTag == null)
                    return NotFound();

                existingTag.Name = tag.Name;

                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //[HttpPatch]
        //[ResponseType(typeof(void))]
        //public IHttpActionResult Update(string id, JsonPatchDocument<Tag> tag)
        //{
        //    try
        //    {
        //        if (tag == null)
        //        {
        //            return BadRequest();
        //        }

        //        var existingTag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

        //        if (existingTag == null)
        //            return NotFound();

        //        tag.ApplyTo(existingTag);

        //        _context.SaveChanges();

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return InternalServerError(ex);
        //    }
        //}

        [HttpDelete]
        [ResponseType(typeof(void))]
        public IHttpActionResult Delete(string id) 
        {
            try
            {
                var existingTag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

                if (existingTag == null)
                    return NotFound();

                _context.Tags.Remove(existingTag);
                _context.SaveChanges();

                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();

            base.Dispose(disposing);
        }
    }
}