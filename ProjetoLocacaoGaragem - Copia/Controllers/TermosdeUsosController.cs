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
using System.Web.Http.Description;
using ProjetoLocacaoGaragem.Models;

namespace ProjetoLocacaoGaragem.Controllers
{
    public class TermosdeUsosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/TermosdeUsos
        public IQueryable<TermosdeUso> GetTermosdeUsos()
        {
            return db.TermosdeUsos;
        }

        // GET: api/TermosdeUsos/5
        [ResponseType(typeof(TermosdeUso))]
        public async Task<IHttpActionResult> GetTermosdeUso(int id)
        {
            TermosdeUso termosdeUso = await db.TermosdeUsos.FindAsync(id);
            if (termosdeUso == null)
            {
                return NotFound();
            }

            return Ok(termosdeUso);
        }

        // PUT: api/TermosdeUsos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermosdeUso(int id, TermosdeUso termosdeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termosdeUso.Id)
            {
                return BadRequest();
            }

            db.Entry(termosdeUso).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermosdeUsoExists(id))
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

        // POST: api/TermosdeUsos
        [ResponseType(typeof(TermosdeUso))]
        public async Task<IHttpActionResult> PostTermosdeUso(TermosdeUso termosdeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TermosdeUsos.Add(termosdeUso);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termosdeUso.Id }, termosdeUso);
        }

        // DELETE: api/TermosdeUsos/5
        [ResponseType(typeof(TermosdeUso))]
        public async Task<IHttpActionResult> DeleteTermosdeUso(int id)
        {
            TermosdeUso termosdeUso = await db.TermosdeUsos.FindAsync(id);
            if (termosdeUso == null)
            {
                return NotFound();
            }

            db.TermosdeUsos.Remove(termosdeUso);
            await db.SaveChangesAsync();

            return Ok(termosdeUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermosdeUsoExists(int id)
        {
            return db.TermosdeUsos.Count(e => e.Id == id) > 0;
        }
    }
}