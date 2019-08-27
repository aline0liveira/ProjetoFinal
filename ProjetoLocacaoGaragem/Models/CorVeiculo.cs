using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class CorVeiculo
    {
        [Key]
        public int Id { get; set; }

        public int CodigoCor { get; set; }
        public string DescricaoCor { get; set; }

    }
}