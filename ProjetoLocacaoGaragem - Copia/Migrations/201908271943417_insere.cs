namespace ProjetoLocacaoGaragem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insere : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CorVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescricaoCor = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Gestors",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NomeGestor = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        Status = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        CorVeiculo_Id = c.Int(),
                        Marca_Id = c.Int(),
                        Modelo_Id = c.Int(),
                        Periodo_Id = c.Int(),
                        TermosdeUso_Id = c.Int(),
                        TipoVeiculo_Id = c.Int(),
                        Usuario_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CorVeiculoes", t => t.CorVeiculo_Id)
                .ForeignKey("dbo.Marcas", t => t.Marca_Id)
                .ForeignKey("dbo.Modeloes", t => t.Modelo_Id)
                .ForeignKey("dbo.Periodoes", t => t.Periodo_Id)
                .ForeignKey("dbo.TermosdeUsoes", t => t.TermosdeUso_Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculo_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.CorVeiculo_Id)
                .Index(t => t.Marca_Id)
                .Index(t => t.Modelo_Id)
                .Index(t => t.Periodo_Id)
                .Index(t => t.TermosdeUso_Id)
                .Index(t => t.TipoVeiculo_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        TipoVeiculo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculo_Id)
                .Index(t => t.TipoVeiculo_Id);
            
            CreateTable(
                "dbo.TipoVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Marca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Marca_Id)
                .Index(t => t.Marca_Id);
            
            CreateTable(
                "dbo.Periodoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdVagas = c.Int(nullable: false),
                        DatInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        TipoVeiculo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculo_Id)
                .Index(t => t.TipoVeiculo_Id);
            
            CreateTable(
                "dbo.TermosdeUsoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NomeUsuario = c.String(),
                        Email = c.String(),
                        PCD = c.Boolean(nullable: false),
                        TrabalhoNoturno = c.Boolean(nullable: false),
                        Idoso = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        OutroMunicipio = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Locacaos", "TipoVeiculo_Id", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "TermosdeUso_Id", "dbo.TermosdeUsoes");
            DropForeignKey("dbo.Locacaos", "Periodo_Id", "dbo.Periodoes");
            DropForeignKey("dbo.Periodoes", "TipoVeiculo_Id", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "Modelo_Id", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "Marca_Id", "dbo.Marcas");
            DropForeignKey("dbo.Locacaos", "Marca_Id", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipoVeiculo_Id", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "CorVeiculo_Id", "dbo.CorVeiculoes");
            DropIndex("dbo.Periodoes", new[] { "TipoVeiculo_Id" });
            DropIndex("dbo.Modeloes", new[] { "Marca_Id" });
            DropIndex("dbo.Marcas", new[] { "TipoVeiculo_Id" });
            DropIndex("dbo.Locacaos", new[] { "Usuario_Id" });
            DropIndex("dbo.Locacaos", new[] { "TipoVeiculo_Id" });
            DropIndex("dbo.Locacaos", new[] { "TermosdeUso_Id" });
            DropIndex("dbo.Locacaos", new[] { "Periodo_Id" });
            DropIndex("dbo.Locacaos", new[] { "Modelo_Id" });
            DropIndex("dbo.Locacaos", new[] { "Marca_Id" });
            DropIndex("dbo.Locacaos", new[] { "CorVeiculo_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.TermosdeUsoes");
            DropTable("dbo.Periodoes");
            DropTable("dbo.Modeloes");
            DropTable("dbo.TipoVeiculoes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Gestors");
            DropTable("dbo.CorVeiculoes");
        }
    }
}
