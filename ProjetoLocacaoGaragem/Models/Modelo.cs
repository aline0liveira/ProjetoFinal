using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class Modelo :UserControls
    {


        [Key]

        public int Id { get; set; }

        public int CodigoModelo { get; set; }

        public string Descricao { get; set; }


        [ForeignKey("Marcafk")]
        public Marca Marca { get; set; }
        public int? Marcafk { get; set; }
    }
}