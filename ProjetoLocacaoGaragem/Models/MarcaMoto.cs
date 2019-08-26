using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class MarcaMoto
    {

        [Key]

        public int Id { get; set; }

        public int Codigo { get; set; }
        public string MarcaoMot { get; set; }

        [ForeignKey("ModeloMotFK")]
        public ModeloMoto ModeloMoto { get; set; }
        public int ModeloMotFK { get; set; }
    }
}