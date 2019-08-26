using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class MarcaAutomovel
    {
        [Key]

        public int Id { get; set; }
        public int Codigo { get; set; }
        public string MarcaAut { get; set; }

        [ForeignKey("ModeloAutFK")]
        public ModeloAutomovel ModeloAutomovel { get; set; }
        public int ModeloAutFK { get; set; }
    }
}