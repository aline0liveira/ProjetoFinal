using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProjetoLocacaoGaragem.Models
{
    public class RotaPeriodoTipo :ApiController
    {

       private ContextDB db= new ContextDB();

        [Route("Api/Locacao/Periodo/{TipoVeiculo}")]
        [HttpGet]
        public IEnumerable<Periodo> PeriodopeloTipo(int tipoVeiculos)
        {
            return db.Periodos.Where(x => x.TipoVeiculo.Id == tipoVeiculos);
        }

    }
}