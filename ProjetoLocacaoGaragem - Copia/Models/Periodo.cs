using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class Periodo :UserControls
    {
        [Key]

        public int Id { get; set; }
        public int Codigo { get; set; }
        public decimal Valor { get; set; }
        public int QtdVagas { get; set; }
        public DateTime DatInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public virtual TipoVeiculo TipoVeiculo { get; set; }

    }
}