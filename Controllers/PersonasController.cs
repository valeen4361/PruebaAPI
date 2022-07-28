﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PruebaAPI.Models;

namespace PruebaAPI.Controllers
{
    public class PersonasController : ApiController
    {
        private PruebaApiEntities2 db = new PruebaApiEntities2();

        // GET: api/Personas
        public IQueryable<Personas> GetPersonas()
        {
            return db.Personas;
        }

        // GET: api/Personas/5
        [ResponseType(typeof(Personas))]
        public IHttpActionResult GetPersonas(int id)
        {
            Personas personas = db.Personas.Find(id);
            if (personas == null)
            {
                return NotFound();
            }

            return Ok(personas);
        }

        // PUT: api/Personas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPersonas(int id, Personas personas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != personas.Id)
            {
                return BadRequest();
            }

            db.Entry(personas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Personas
        [ResponseType(typeof(Personas))]
        public IHttpActionResult PostPersonas(Personas personas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Personas.Add(personas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = personas.Id }, personas);
        }

        // DELETE: api/Personas/5
        [ResponseType(typeof(Personas))]
        public IHttpActionResult DeletePersonas(int id)
        {
            Personas personas = db.Personas.Find(id);
            if (personas == null)
            {
                return NotFound();
            }

            db.Personas.Remove(personas);
            db.SaveChanges();

            return Ok(personas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PersonasExists(int id)
        {
            return db.Personas.Count(e => e.Id == id) > 0;
        }
    }
}