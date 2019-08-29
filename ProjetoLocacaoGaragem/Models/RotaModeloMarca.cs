using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProjetoLocacaoGaragem.Models
{
    public class RotaModeloMarca :ApiController
    {

        private ContextDB db = new ContextDB();


        [Route("Api/Locacao/Modelo/{Marca}")]
        [HttpGet]
        public IEnumerable<Modelo> ModelopeloMarca(int marca)
        {
            return db.Modelos.Where(x => x.Marca.Id == marca);
        }

    }
}