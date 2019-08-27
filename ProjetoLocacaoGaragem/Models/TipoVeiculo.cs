using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class TipoVeiculo : UserControls
    {
   
        [Key]
        public int Id { get; set; }

        public int CodigoTipo { get; set; }
        public string Descricao { get; set; }


    }
}