using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class TipoVeiculo : UserControls
    {
   
        [Key]
        public int Id { get; set; }

<<<<<<< HEAD
        public int CodigoTipo { get; set; }
        public string Descricao { get; set; }
=======
        public int Codigo { get; set; }


        public  string Tipo { get; set; }


        [ForeignKey("MarcasAutFK")]
        public MarcaAutomovel MarcaAutomovel { get; set; }
        public int MarcasAutFK { get; set; }
>>>>>>> 4d065b88f45247a73660f30de0d54a0b00640175


    }
}