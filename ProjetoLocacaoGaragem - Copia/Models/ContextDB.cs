using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class ContextDB : DbContext
    {
<<<<<<< HEAD
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CorVeiculo> CorVeiculos { get; set; }
        public DbSet<Gestor> Gestors { get; set; }
        public DbSet<Locacao> Locacaos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<TermosdeUso> TermosdeUsos { get; set; }
        public DbSet<TipoVeiculo> TipoVeiculos { get; set; }

=======
        
>>>>>>> 4d065b88f45247a73660f30de0d54a0b00640175
    }
}