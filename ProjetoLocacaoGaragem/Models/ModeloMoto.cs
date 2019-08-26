using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class ModeloMoto
    {

        [Key]

        public int Id { get; set; }

        public int Codigo { get; set; }

        public string ModeloMot { get; set; }
    }
}