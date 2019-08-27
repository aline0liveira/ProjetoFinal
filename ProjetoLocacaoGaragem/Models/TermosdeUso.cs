using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class TermosdeUso : UserControls
    {
        [Key]

        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}