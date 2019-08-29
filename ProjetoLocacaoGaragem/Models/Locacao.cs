using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class Locacao : UserControls
    {
     [Key]

        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaPlaca)]
        public string Placa { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaStatus)]
        public int Status { get; set; }

        [ForeignKey("Veiculofk")]
        public TipoVeiculo TipoVeiculo { get; set; }
        public int? Veiculofk { get; set; }


        [ForeignKey("Marcafk")]
        public Marca Marca { get; set; }
        public int? Marcafk { get; set; }


        [ForeignKey("Modelofk")]
        public Modelo Modelo { get; set; }
        public int? Modelofk { get; set; }


        [ForeignKey("CorVeiculofk")]
        public CorVeiculo CorVeiculo { get; set; }
        public int? CorVeiculofk { get; set; }


        [ForeignKey("Periodofk")]
        public Periodo Periodo { get; set; }
        public int? Periodofk { get; set; }


        [ForeignKey("Usuariofk")]
        public Usuario Usuario { get; set; }
        public int? Usuariofk { get; set; }


        [ForeignKey("TermosdeUsofk")]
        public TermosdeUso TermosdeUso { get; set; }
        public int? TermosdeUsofk { get; set; }


        public bool AceitaTermo { get; set; }




    }
}