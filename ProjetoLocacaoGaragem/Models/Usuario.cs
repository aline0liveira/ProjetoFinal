using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class Usuario : UserControls
    {
        [Key]

        public string Id { get; set; }

        public int CodigoUsuario { get; set; }

        public string NomeUsuario { get; set; }

        public string Email { get; set; }

        public bool PCD { get; set; } 

        public bool TrabalhoNoturno { get; set; } 

        public bool Idoso { get; set; }

        public bool Carona { get; set; }

        public bool OutroMunicipio { get; set; }

    }
}