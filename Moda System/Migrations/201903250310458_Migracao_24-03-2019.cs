namespace Moda_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracao_24032019 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BarrasPro",
                c => new
                    {
                        CodBarId = c.Int(nullable: false, identity: true),
                        ProCodBar = c.Int(nullable: false),
                        ForCodBar = c.Int(),
                        Codbarras = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.CodBarId)
                .ForeignKey("dbo.Produto", t => t.ProCodBar)
                .Index(t => t.ProCodBar);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        CodRefPro = c.String(maxLength: 40),
                        StaProd = c.String(maxLength: 1),
                        DescProd = c.String(nullable: false, maxLength: 150),
                        CodMarca = c.Int(nullable: false),
                        CodGrupo = c.Int(nullable: false),
                        CodSubGrupo = c.Int(nullable: false),
                        CodUniSai = c.Int(nullable: false),
                        CodUniEnt = c.Int(nullable: false),
                        QntEquiv = c.Decimal(nullable: false, storeType: "money"),
                        PrecoVenda = c.Decimal(storeType: "money"),
                        QtdMinima = c.Decimal(storeType: "money"),
                        ObsProd = c.String(maxLength: 2048),
                        DataCadPro = c.DateTime(),
                        ControlaQnt = c.String(maxLength: 100),
                        CustoMedPro = c.Decimal(storeType: "money"),
                        CustoRepPro = c.Decimal(storeType: "money"),
                        DataCusPro = c.DateTime(),
                        UsaTabPre = c.String(maxLength: 100),
                        ImagProd = c.Binary(nullable: false, maxLength: 4000),
                        NomeImgPro = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Grupo", t => t.CodGrupo)
                .ForeignKey("dbo.Marca", t => t.CodMarca)
                .ForeignKey("dbo.SubGrupo", t => t.CodSubGrupo)
                .ForeignKey("dbo.Unidade", t => t.CodUniEnt)
                .ForeignKey("dbo.Unidade", t => t.CodUniSai)
                .Index(t => t.CodMarca)
                .Index(t => t.CodGrupo)
                .Index(t => t.CodSubGrupo)
                .Index(t => t.CodUniSai)
                .Index(t => t.CodUniEnt);
            
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        GrupoId = c.Int(nullable: false, identity: true),
                        DescGrupo = c.String(nullable: false, maxLength: 150),
                        CorFundoGrd = c.Int(),
                        CorFonteGrd = c.Int(),
                        UsarGrade = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.GrupoId);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        DescMarca = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.MarcaId);
            
            CreateTable(
                "dbo.SubGrupo",
                c => new
                    {
                        SubGrupoId = c.Int(nullable: false, identity: true),
                        GrupoId = c.Int(nullable: false),
                        DescSubGrupo = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.SubGrupoId)
                .ForeignKey("dbo.Grupo", t => t.GrupoId)
                .Index(t => t.GrupoId);
            
            CreateTable(
                "dbo.Unidade",
                c => new
                    {
                        UnidadeId = c.Int(nullable: false, identity: true),
                        DescUnidade = c.String(maxLength: 50),
                        SiglaUnidade = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.UnidadeId);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                        cnpjEmp = c.String(maxLength: 18),
                        statEmp = c.String(maxLength: 1),
                        tipoEmp = c.String(maxLength: 1),
                        codMatriz = c.Int(),
                        razaoEmp = c.String(nullable: false, maxLength: 150),
                        fantEmp = c.String(maxLength: 150),
                        inscEstEmp = c.String(maxLength: 20),
                        inscMunEmp = c.String(maxLength: 20),
                        tel1Emp = c.String(maxLength: 20),
                        tel2Emp = c.String(maxLength: 20),
                        endEmp = c.String(maxLength: 150),
                        nroEndEmp = c.Int(),
                        compEndEmp = c.String(maxLength: 150),
                        bairroEmp = c.String(maxLength: 150),
                        cidadeEmp = c.String(maxLength: 100),
                        dataCadEmp = c.DateTime(),
                        CEPEmp = c.String(maxLength: 8),
                        UFEmp = c.String(maxLength: 2),
                        empPadrao = c.String(maxLength: 1),
                        tipoData = c.String(maxLength: 10),
                        versaoEmp = c.Int(nullable: false),
                        nomImglogo = c.String(maxLength: 150),
                        extimglogo = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.EmpresaId);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        EstoqueId = c.Int(nullable: false, identity: true),
                        DescEstoque = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.EstoqueId);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        FornecedorId = c.Int(nullable: false, identity: true),
                        StatusFor = c.String(maxLength: 1),
                        NomeForn = c.String(nullable: false, maxLength: 150),
                        CpfForn = c.String(maxLength: 11),
                        CnpjForn = c.String(maxLength: 14),
                        ContatoForn = c.String(maxLength: 50),
                        Tel1Forn = c.String(maxLength: 20),
                        Tel2Forn = c.String(maxLength: 20),
                        EmailForn = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.FornecedorId);
            
            CreateTable(
                "dbo.PrecosPro",
                c => new
                    {
                        PrecoProId = c.Int(nullable: false, identity: true),
                        TabPreId = c.Int(nullable: false),
                        DesTabPre = c.String(maxLength: 100),
                        ValProduto = c.Decimal(nullable: false, storeType: "money"),
                        DescProg = c.Decimal(nullable: false, storeType: "money"),
                        ValAntPro = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.PrecoProId)
                .ForeignKey("dbo.TabPreco", t => t.TabPreId)
                .Index(t => t.TabPreId);
            
            CreateTable(
                "dbo.TabPreco",
                c => new
                    {
                        SeqTabPre = c.Int(nullable: false, identity: true),
                        DescTabPre = c.String(nullable: false, maxLength: 150),
                        PercLucro = c.Decimal(storeType: "money"),
                        CalcPreCmp = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.SeqTabPre);
            
            CreateTable(
                "dbo.SaldoEstoque",
                c => new
                    {
                        SaldoEstId = c.Int(nullable: false, identity: true),
                        CodLocalEst = c.Int(nullable: false),
                        CodProEst = c.Int(nullable: false),
                        QntEntradas = c.Decimal(nullable: false, storeType: "money"),
                        QntSaidas = c.Decimal(storeType: "money"),
                        QntSaldo = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.SaldoEstId)
                .ForeignKey("dbo.Estoque", t => t.CodLocalEst)
                .ForeignKey("dbo.Produto", t => t.CodProEst)
                .Index(t => t.CodLocalEst)
                .Index(t => t.CodProEst);
            
            CreateTable(
                "dbo.SYS000",
                c => new
                    {
                        SysId = c.Int(nullable: false, identity: true),
                        VersaoSistema = c.Int(),
                        ScriptBD = c.Int(),
                    })
                .PrimaryKey(t => t.SysId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        StaUser = c.String(maxLength: 1),
                        NomeUser = c.String(maxLength: 150),
                        EmailUser = c.String(maxLength: 150),
                        LoginUser = c.String(maxLength: 20),
                        SenUser = c.String(maxLength: 256),
                        PerfilUser = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        VendedorId = c.Int(nullable: false, identity: true),
                        NomeVendedor = c.String(nullable: false, maxLength: 150),
                        PerComissao = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.VendedorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaldoEstoque", "CodProEst", "dbo.Produto");
            DropForeignKey("dbo.SaldoEstoque", "CodLocalEst", "dbo.Estoque");
            DropForeignKey("dbo.PrecosPro", "TabPreId", "dbo.TabPreco");
            DropForeignKey("dbo.BarrasPro", "ProCodBar", "dbo.Produto");
            DropForeignKey("dbo.Produto", "CodUniSai", "dbo.Unidade");
            DropForeignKey("dbo.Produto", "CodUniEnt", "dbo.Unidade");
            DropForeignKey("dbo.Produto", "CodSubGrupo", "dbo.SubGrupo");
            DropForeignKey("dbo.SubGrupo", "GrupoId", "dbo.Grupo");
            DropForeignKey("dbo.Produto", "CodMarca", "dbo.Marca");
            DropForeignKey("dbo.Produto", "CodGrupo", "dbo.Grupo");
            DropIndex("dbo.SaldoEstoque", new[] { "CodProEst" });
            DropIndex("dbo.SaldoEstoque", new[] { "CodLocalEst" });
            DropIndex("dbo.PrecosPro", new[] { "TabPreId" });
            DropIndex("dbo.SubGrupo", new[] { "GrupoId" });
            DropIndex("dbo.Produto", new[] { "CodUniEnt" });
            DropIndex("dbo.Produto", new[] { "CodUniSai" });
            DropIndex("dbo.Produto", new[] { "CodSubGrupo" });
            DropIndex("dbo.Produto", new[] { "CodGrupo" });
            DropIndex("dbo.Produto", new[] { "CodMarca" });
            DropIndex("dbo.BarrasPro", new[] { "ProCodBar" });
            DropTable("dbo.Vendedor");
            DropTable("dbo.Usuario");
            DropTable("dbo.SYS000");
            DropTable("dbo.SaldoEstoque");
            DropTable("dbo.TabPreco");
            DropTable("dbo.PrecosPro");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Estoque");
            DropTable("dbo.Empresa");
            DropTable("dbo.Unidade");
            DropTable("dbo.SubGrupo");
            DropTable("dbo.Marca");
            DropTable("dbo.Grupo");
            DropTable("dbo.Produto");
            DropTable("dbo.BarrasPro");
        }
    }
}
