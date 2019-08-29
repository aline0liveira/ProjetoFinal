using Newtonsoft.Json;
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
        public int CodigoPeriodo { get; set; }
        public decimal Valor { get; set; } 
        public int QtdVagas { get; set; }


        [JsonConverter(typeof(CustomDataFormat))]
        public DateTime DatInicial { get; set; }

        [JsonConverter(typeof(CustomDataFormat))]
        public DateTime DataFinal { get; set; }


        [ForeignKey("TipoVeiculofk")]
        public TipoVeiculo TipoVeiculo { get; set; }
        public int? TipoVeiculofk { get; set; }

    }
}