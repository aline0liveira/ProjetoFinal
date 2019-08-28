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
        public string Placa { get; set; }
<<<<<<< HEAD
        public string Status { get; set; }
        public virtual TipoVeiculo TipoVeiculo { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual CorVeiculo CorVeiculo { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual TermosdeUso TermosdeUso { get; set; }
=======

        public string Status { get; set; }

        public decimal Valor { get; set; }

        public int QtdVagas { get; set; }

        [ForeignKey("TipoFK")]
        public TipoVeiculo TipoVeiculo { get; set; }
        public int TipoFK { get; set; }


        [ForeignKey("MarcaAutFK")]
        public MarcaAutomovel MarcaAutomovel { get; set; }
        public int MarcaAutFK { get; set; }



        [ForeignKey("ModeloAutFK")]
        public ModeloAutomovel ModeloAutomovel { get; set; }
        public int ModeloAutFK { get; set; }



        [ForeignKey("MarcaMotFK")]
        public MarcaMoto MarcaMoto{ get; set; }
        public int MarcaMotFK { get; set; }



        [ForeignKey("ModeloMotFK")]
        public ModeloMoto ModeloMoto { get; set; }
        public int ModeloMotFK { get; set; }



        [ForeignKey("DescricaoCorFK")]
        public CorVeiculo CorVeiculo { get; set; }
        public int DescricaoCorFK { get; set; }


        [ForeignKey("PeriodoFK")]
        public Periodo Periodo { get; set; }
        public int PeriodoFK { get; set; }


        [ForeignKey("NomeUsuarioFK")]
        public Usuario Usuario { get; set; }
        public int NomeUsuarioFK { get; set; }
>>>>>>> 4d065b88f45247a73660f30de0d54a0b00640175
    }
}