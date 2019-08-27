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
        public string Status { get; set; }
        public virtual TipoVeiculo TipoVeiculo { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual CorVeiculo CorVeiculo { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual TermosdeUso TermosdeUso { get; set; }
    }
}