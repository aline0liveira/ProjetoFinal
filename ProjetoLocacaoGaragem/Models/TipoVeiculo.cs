using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class TipoVeiculo
    {
     [Key]
        public int  Id { get; set; }

        public int Codigo { get; set; }


        public  string Tipo { get; set; }


        [ForeignKey("MarcasAutFK")]
        public MarcaAutomovel MarcaAutomovel { get; set; }
        public int MarcasAutFK { get; set; }


        public DateTime DatInicial { get; set; }

        public DateTime DataFinal { get; set; }


    }
}