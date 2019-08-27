using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class Marca : UserControls
    {

        [Key]
        public int Id { get; set; }
        public int CodigoMarca { get; set; }
        public string Descricao { get; set; }
        public virtual TipoVeiculo CodigoVeiculo { get; set; }
    }
}