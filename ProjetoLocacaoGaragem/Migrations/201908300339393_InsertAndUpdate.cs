namespace ProjetoLocacaoGaragem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertAndUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CorVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoCor = c.Int(nullable: false),
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
                        CodigoGestor = c.Int(nullable: false),
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
                        Status = c.Int(nullable: false),
                        Veiculofk = c.Int(),
                        Marcafk = c.Int(),
                        Modelofk = c.Int(),
                        CorVeiculofk = c.Int(),
                        Periodofk = c.Int(),
                        Usuariofk = c.Int(),
                        TermosdeUsofk = c.Int(),
                        AceitaTermo = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CorVeiculoes", t => t.CorVeiculofk)
                .ForeignKey("dbo.Marcas", t => t.Marcafk)
                .ForeignKey("dbo.Modeloes", t => t.Modelofk)
                .ForeignKey("dbo.Periodoes", t => t.Periodofk)
                .ForeignKey("dbo.TermosdeUsoes", t => t.TermosdeUsofk)
                .ForeignKey("dbo.TipoVeiculoes", t => t.Veiculofk)
                .ForeignKey("dbo.Usuarios", t => t.Usuariofk)
                .Index(t => t.Veiculofk)
                .Index(t => t.Marcafk)
                .Index(t => t.Modelofk)
                .Index(t => t.CorVeiculofk)
                .Index(t => t.Periodofk)
                .Index(t => t.Usuariofk)
                .Index(t => t.TermosdeUsofk);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoMarca = c.Int(nullable: false),
                        Descricao = c.String(),
                        TipoVeiculofk = c.Int(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculofk)
                .Index(t => t.TipoVeiculofk);
            
            CreateTable(
                "dbo.TipoVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoTipo = c.Int(nullable: false),
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
                        CodigoModelo = c.Int(nullable: false),
                        Descricao = c.String(),
                        Marcafk = c.Int(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Marcafk)
                .Index(t => t.Marcafk);
            
            CreateTable(
                "dbo.Periodoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoPeriodo = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdVagas = c.Int(nullable: false),
                        DatInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        TipoVeiculofk = c.Int(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculofk)
                .Index(t => t.TipoVeiculofk);
            
            CreateTable(
                "dbo.TermosdeUsoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Vigente = c.Boolean(nullable: false),
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
                        Id = c.Int(nullable: false, identity: true),
                        CodigoUsuario = c.Int(nullable: false),
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
            DropForeignKey("dbo.Locacaos", "Usuariofk", "dbo.Usuarios");
            DropForeignKey("dbo.Locacaos", "Veiculofk", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "TermosdeUsofk", "dbo.TermosdeUsoes");
            DropForeignKey("dbo.Locacaos", "Periodofk", "dbo.Periodoes");
            DropForeignKey("dbo.Periodoes", "TipoVeiculofk", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "Modelofk", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "Marcafk", "dbo.Marcas");
            DropForeignKey("dbo.Locacaos", "Marcafk", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipoVeiculofk", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "CorVeiculofk", "dbo.CorVeiculoes");
            DropIndex("dbo.Periodoes", new[] { "TipoVeiculofk" });
            DropIndex("dbo.Modeloes", new[] { "Marcafk" });
            DropIndex("dbo.Marcas", new[] { "TipoVeiculofk" });
            DropIndex("dbo.Locacaos", new[] { "TermosdeUsofk" });
            DropIndex("dbo.Locacaos", new[] { "Usuariofk" });
            DropIndex("dbo.Locacaos", new[] { "Periodofk" });
            DropIndex("dbo.Locacaos", new[] { "CorVeiculofk" });
            DropIndex("dbo.Locacaos", new[] { "Modelofk" });
            DropIndex("dbo.Locacaos", new[] { "Marcafk" });
            DropIndex("dbo.Locacaos", new[] { "Veiculofk" });
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
