using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class Gestor : UserControls
    {
        [Key]

        public string Id { get; set; }

        public int CodigoGestor { get; set; }
        public  string NomeGestor { get; set; }

    }
}