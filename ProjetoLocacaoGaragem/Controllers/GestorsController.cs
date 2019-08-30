using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using ProjetoLocacaoGaragem.Models;

namespace ProjetoLocacaoGaragem.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GestorsController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Gestors
        public IQueryable<Gestor> GetGestors()
        {
            return db.Gestors;
        }

        // GET: api/Gestors/5
        [ResponseType(typeof(Gestor))]
        public async Task<IHttpActionResult> GetGestor(string id)
        {
            Gestor gestor = await db.Gestors.FindAsync(id);
            if (gestor == null)
            {
                return NotFound();
            }

            return Ok(gestor);
        }

        // PUT: api/Gestors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGestor(string id, Gestor gestor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gestor.Id)
            {
                return BadRequest();
            }

            db.Entry(gestor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GestorExists(id))
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

        // POST: api/Gestors
        [ResponseType(typeof(Gestor))]
        public async Task<IHttpActionResult> PostGestor(Gestor gestor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Gestors.Add(gestor);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GestorExists(gestor.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = gestor.Id }, gestor);
        }

        // DELETE: api/Gestors/5
        [ResponseType(typeof(Gestor))]
        public async Task<IHttpActionResult> DeleteGestor(string id)
        {
            Gestor gestor = await db.Gestors.FindAsync(id);
            if (gestor == null)
            {
                return NotFound();
            }

            db.Gestors.Remove(gestor);
            await db.SaveChangesAsync();

            return Ok(gestor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GestorExists(string id)
        {
            return db.Gestors.Count(e => e.Id == id) > 0;
        }
    }
}