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
    public class PeriodosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Periodos
        public IQueryable<Periodo> GetPeriodos()
        {
            return db.Periodos;
        }

        // GET: api/Periodos/5
        [ResponseType(typeof(Periodo))]
        public async Task<IHttpActionResult> GetPeriodo(int id)
        {
            Periodo periodo = await db.Periodos.FindAsync(id);
            if (periodo == null)
            {
                return NotFound();
            }

            return Ok(periodo);
        }

        // PUT: api/Periodos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPeriodo(int id, Periodo periodo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != periodo.Id)
            {
                return BadRequest();
            }

            db.Entry(periodo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodoExists(id))
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

        // POST: api/Periodos
        [ResponseType(typeof(Periodo))]
        public async Task<IHttpActionResult> PostPeriodo(Periodo periodo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Periodos.Add(periodo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = periodo.Id }, periodo);
        }

        // DELETE: api/Periodos/5
        [ResponseType(typeof(Periodo))]
        public async Task<IHttpActionResult> DeletePeriodo(int id)
        {
            Periodo periodo = await db.Periodos.FindAsync(id);
            if (periodo == null)
            {
                return NotFound();
            }

            db.Periodos.Remove(periodo);
            await db.SaveChangesAsync();

            return Ok(periodo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeriodoExists(int id)
        {
            return db.Periodos.Count(e => e.Id == id) > 0;
        }
    }
}