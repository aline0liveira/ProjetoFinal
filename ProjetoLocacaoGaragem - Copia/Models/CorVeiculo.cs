﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class CorVeiculo : UserControls
    {
        [Key]
        public int Id { get; set; }

<<<<<<< HEAD
        public int Codigo { get; set; }
=======
        public int CodigoCor { get; set; }
>>>>>>> 4d065b88f45247a73660f30de0d54a0b00640175
        public string DescricaoCor { get; set; }

    }
}