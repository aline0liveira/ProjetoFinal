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
    public class CorVeiculosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/CorVeiculos
        public IQueryable<CorVeiculo> GetCorVeiculos()
        {
            return db.CorVeiculos;
        }

        // GET: api/CorVeiculos/5
        [ResponseType(typeof(CorVeiculo))]
        public async Task<IHttpActionResult> GetCorVeiculo(int id)
        {
            CorVeiculo corVeiculo = await db.CorVeiculos.FindAsync(id);
            if (corVeiculo == null)
            {
                return NotFound();
            }

            return Ok(corVeiculo);
        }

        // PUT: api/CorVeiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCorVeiculo(int id, CorVeiculo corVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != corVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(corVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CorVeiculoExists(id))
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

        // POST: api/CorVeiculos
        [ResponseType(typeof(CorVeiculo))]
        public async Task<IHttpActionResult> PostCorVeiculo(CorVeiculo corVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CorVeiculos.Add(corVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = corVeiculo.Id }, corVeiculo);
        }

        // DELETE: api/CorVeiculos/5
        [ResponseType(typeof(CorVeiculo))]
        public async Task<IHttpActionResult> DeleteCorVeiculo(int id)
        {
            CorVeiculo corVeiculo = await db.CorVeiculos.FindAsync(id);
            if (corVeiculo == null)
            {
                return NotFound();
            }

            db.CorVeiculos.Remove(corVeiculo);
            await db.SaveChangesAsync();

            return Ok(corVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CorVeiculoExists(int id)
        {
            return db.CorVeiculos.Count(e => e.Id == id) > 0;
        }
    }
}