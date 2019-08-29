using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProjetoLocacaoGaragem.Models
{
    public class RotaMarcaTipo : ApiController
    {
        private ContextDB db = new ContextDB();


        [Route("Api/Locacao/Marca/{TipoVeiculo}")]
        [HttpGet]
        public IEnumerable<Marca> MarcaspeloTipoController(int tipoVeiculo)
        {
            return db.Marcas.Where(x => x.TipoVeiculo.Id == tipoVeiculo);
        }

    }
}