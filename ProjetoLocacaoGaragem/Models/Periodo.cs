using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class Periodo
    {
        [Key]

       public int Id { get; set; }
       public int Codigo { get; set; }

        [ForeignKey("TipoFK")]
       public TipoVeiculo TipoVeiculo { get; set; }
       public int TipoFK { get; set; }
       public DateTime DatInicial { get; set; }
       public DateTime DataFinal { get; set; }

    }
}