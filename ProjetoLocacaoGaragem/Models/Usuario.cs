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
        public int Id { get; set; }

        public int CodigoUsuario { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaNomeUsuario)]
        public string NomeUsuario { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

        public bool PCD { get; set; } = false;

        public bool TrabalhoNoturno { get; set; } = false;

        public bool Idoso { get; set; } = false;

        public bool Carona { get; set; } = false;

        public bool OutroMunicipio { get; set; } = false;

    }
}