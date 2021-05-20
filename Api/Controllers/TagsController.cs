using Api.Dtos;
using AutoMapper;
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


        [ResponseType(typeof(IEnumerable<TagDto>))]
        public IHttpActionResult Get()
        {
            try
            {
                var tags = _context.Tags.ToList();

                var dto = Mapper.Map<IEnumerable<Tag>, IEnumerable<TagDto>>(tags);

                return Ok(dto);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        [ResponseType(typeof(TagDto))]
        public IHttpActionResult Get(string id) 
        {
            try
            {
                var tag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

                var dto = Mapper.Map<Tag, TagDto>(tag);

                if (tag == null)
                    return NotFound();

                return Ok(dto);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [ResponseType(typeof(TagDto))]
        public IHttpActionResult Create(TagDto dto) 
        {
            try
            {
                if (dto == null || !ModelState.IsValid)
                    return BadRequest();

                var tag = Mapper.Map<TagDto, Tag>(dto);

                _context.Tags.Add(tag);
                _context.SaveChanges();

                dto = Mapper.Map<Tag, TagDto>(tag);

                return Created(string.Format("{0}/{1}", Request.RequestUri, tag.Id), dto);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult Update(string id, TagDto dto)
        {
            try
            {
                if (dto == null || !ModelState.IsValid || id != dto.Id.ToString())
                {
                    return BadRequest();
                }

                var existingTag = _context.Tags.SingleOrDefault(t => t.Id.ToString() == id);

                if (existingTag == null)
                    return NotFound();

                // existingTag.Name = dto.Name;
                Mapper.Map<TagDto, Tag>(dto, existingTag);

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