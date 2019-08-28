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
        public int Codigo { get; set; }

<<<<<<< HEAD
        public string Descricao { get; set; }
=======
        public string Texto { get; set; }
>>>>>>> 4d065b88f45247a73660f30de0d54a0b00640175
    }
}