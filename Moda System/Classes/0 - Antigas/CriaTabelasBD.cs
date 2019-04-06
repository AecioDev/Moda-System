
namespace Moda_System.Classes
{
    public class CriaTabelasBD
    {
        //Nessa Classe Será Incluída a Criação de Todas as Tabelas do Banco de Dados 
        //No formato do SQL Server Compact
        //Na Forma de um único Script.
        //Isso inclui a criação das Tabelas e integridade Referencial que se Fizer necessário.

        public static string CriaTabelas(int codScript)
        {
            string script = "";
            switch (codScript)
            {
                case 0: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Vendedor]([VendedorId] int IDENTITY (1,1) NOT NULL, [NomeVendedor] nvarchar(150) NOT NULL, [PerComissao] money NULL, CONSTRAINT [PK_Vendedor] PRIMARY KEY ([VendedorId]));";
                    break;
                case 1: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Usuario]([UsuarioId] int IDENTITY (1,1) NOT NULL, [StaUser] nvarchar(1) NULL, [NomeUser] nvarchar(150) NULL, [EmailUser] nvarchar(150) NULL, [LoginUser] nvarchar(20) NULL, [SenUser] nvarchar(256) NULL, [PerfilUser] nvarchar(1) NULL, CONSTRAINT [PK_Usuario] PRIMARY KEY ([UsuarioId]));";
                    break;
                case 2: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Unidade]([UnidadeId] int IDENTITY (1,1) NOT NULL, [DescUnidade] nvarchar(50) NULL, [SiglaUnidade] nvarchar(4) NULL, CONSTRAINT [PK_Unidade] PRIMARY KEY ([UnidadeId]));";
                    break;
                case 3: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [TabPreco]([SeqTabPre] int IDENTITY (1,1) NOT NULL, [DescTabPre] nvarchar(150) NOT NULL, [PercLucro] money NULL, [CalcPreCmp] nvarchar(1) NOT NULL, CONSTRAINT [PK_TabPreco] PRIMARY KEY ([SeqTabPre]));";
                    break;
                case 4: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [SYS000]([SysId] int IDENTITY (1,1) NOT NULL, [VersaoSistema] int NULL, [ScriptBD] int NULL, CONSTRAINT [PK_SYS000] PRIMARY KEY ([SysId]));";
                    break;
                case 5: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [PrecosPro] ([PrecoProId] int IDENTITY (1,1) NOT NULL, [TabPreId] int NOT NULL, [DesTabPre] nvarchar(4000) NULL, [ValProduto] money NOT NULL, [DescProg] money NOT NULL, [ValAntPro] money NOT NULL, CONSTRAINT [PK_PrecosPro] PRIMARY KEY ([PrecoProId]));";
                    break;
                case 6: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Marca] (  [MarcaId] int IDENTITY (1,1) NOT NULL, [DescMarca] nvarchar(150) NOT NULL, CONSTRAINT [PK_Marca] PRIMARY KEY ([MarcaId]));";
                    break;
                case 7: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Grupo] (  [GrupoId] int IDENTITY (1,1) NOT NULL, [DescGrupo] nvarchar(150) NOT NULL, [CorFundoGrd] int NULL, [CorFonteGrd] int NULL, [UsarGrade] nvarchar(1) NULL, CONSTRAINT [PK_Grupo] PRIMARY KEY ([GrupoId]));";
                    break;
                case 8: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [SubGrupo] (  [SubGrupoId] int IDENTITY (1,1) NOT NULL, [GrupoId] int NOT NULL, [DescSubGrupo] nvarchar(150) NOT NULL, CONSTRAINT [PK_SubGrupo] PRIMARY KEY ([SubGrupoId]));";
                    break;
                case 9: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Produto] (  [ProdutoId] int IDENTITY (1,1) NOT NULL, [CodRefPro] nvarchar(40) NULL, [StaProd] nvarchar(1) NULL, [DescProd] nvarchar(150) NOT NULL, [CodMarca] int NOT NULL, [CodGrupo] int NOT NULL, [CodSubGrupo] int NOT NULL, [CodUniSai] int NOT NULL, [CodUniEnt] int NOT NULL, [QntEquiv] money NOT NULL, [PrecoVenda] money NULL, [QtdMinima] money NULL, [ObsProd] nvarchar(2048) NULL, [DataCadPro] datetime NULL, [ControlaQnt] nvarchar(4000) NULL, [CustoMedPro] money NULL, [CustoRepPro] money NULL, [DataCusPro] datetime NULL, [UsaTabPre] nvarchar(4000) NULL, [ImagProd] image NULL, [NomeImgPro] nvarchar(1000) NULL, CONSTRAINT [PK_Produto] PRIMARY KEY ([ProdutoId]));";
                    break;
                case 10: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Fornecedor] (  [FornecedorId] int IDENTITY (1,1) NOT NULL, [StatusFor] nvarchar(1) NULL, [NomeForn] nvarchar(150) NOT NULL, [CpfForn] nvarchar(11) NULL, [CnpjForn] nvarchar(14) NULL, [ContatoForn] nvarchar(50) NULL, [Tel1Forn] nvarchar(20) NULL, [Tel2Forn] nvarchar(20) NULL, [EmailForn] nvarchar(150) NULL, CONSTRAINT [PK_Fornecedor] PRIMARY KEY ([FornecedorId]));";
                    break;
                case 11: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Estoque] (  [EstoqueId] int IDENTITY (1,1) NOT NULL, [DescEstoque] nvarchar(150) NOT NULL, CONSTRAINT [PK_Estoque] PRIMARY KEY ([EstoqueId]));";
                    break;
                case 12: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [SaldoEstoque] (  [SaldoEstId] int IDENTITY (1,1) NOT NULL, [CodLocalEst] int NOT NULL, [CodProEst] int NOT NULL, [QntEntradas] money NOT NULL, [QntSaidas] money NULL, [QntSaldo] money NULL, CONSTRAINT [PK_SaldoEstoque] PRIMARY KEY ([SaldoEstId]));";
                    break;
                case 13: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [Empresa] (  [EmpresaId] int IDENTITY (1,1) NOT NULL, [cnpjEmp] nvarchar(18) NULL, [statEmp] nchar(1) NULL, [tipoEmp] nchar(1) NULL, [codMatriz] int NULL, [razaoEmp] nvarchar(50) NULL, [fantEmp] nvarchar(50) NULL, [inscEstEmp] nvarchar(20) NULL, [inscMunEmp] nvarchar(20) NULL, [tel1Emp] nvarchar(20) NULL, [tel2Emp] nvarchar(20) NULL, [endEmp] nvarchar(50) NULL, [nroEndEmp] int NULL, [compEndEmp] nvarchar(60) NULL, [bairroEmp] nvarchar(50) NULL, [cidadeEmp] nvarchar(100) NULL, [dataCadEmp] datetime NULL, [CEPEmp] nvarchar(8) NULL, [UFEmp] nvarchar(2) NULL, [empPadrao] nvarchar(1) NULL, [tipoData] nvarchar(10) NULL, [versaoEmp] int NULL, [nomImglogo] nvarchar(100) NULL, [logoEmp] image NULL, [extimglogo] nvarchar(4000) NULL, CONSTRAINT [PK_Empresa] PRIMARY KEY ([EmpresaId]));";
                    break;
                case 14: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE TABLE [BarrasPro] (  [CodBarId] int IDENTITY (1,1) NOT NULL, [ProCodBar] int NOT NULL, [ForCodBar] int NULL, [Codbarras] nvarchar(15) NOT NULL, CONSTRAINT [PK_BarrasPro] PRIMARY KEY ([CodBarId]));";
                    break;
                default:
                    script = "FIM";
                    break;
            }

            return script;        
        }

        public static string CriaIndices(int codScript)
        {
            string script = "";
            switch (codScript) //Cria Referencias
            {
                case 0: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_TabPreId] ON [PrecosPro] ([TabPreId] ASC);";
                    break;
                case 1: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_GrupoId] ON [SubGrupo] ([GrupoId] ASC);";
                    break;
                case 2: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_CodGrupo] ON [Produto] ([CodGrupo] ASC);";
                    break;
                case 3: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_CodMarca] ON [Produto] ([CodMarca] ASC);";
                    break;
                case 4: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_CodSubGrupo] ON [Produto] ([CodSubGrupo] ASC);";
                    break;
                case 5: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_CodUniEnt] ON [Produto] ([CodUniEnt] ASC);";
                    break;
                case 6: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_CodUniSai] ON [Produto] ([CodUniSai] ASC)";
                    break;
                case 7: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_CodLocalEst] ON [SaldoEstoque] ([CodLocalEst] ASC)";
                    break;
                case 8: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_CodProEst] ON [SaldoEstoque] ([CodProEst] ASC);";
                    break;
                case 9: //-- Script Date: 24/03/2019 18:50
                    script = "CREATE INDEX [IX_ProCodBar] ON [BarrasPro] ([ProCodBar] ASC);";
                    break;
                default:
                    script = "FIM";
                    break;
            }

            return script;
        }

        public static string CriaReferencias(int codScript)
        {
            string script = "";
            switch (codScript) //Cria Referencias
            {
                case 0: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [PrecosPro] ADD CONSTRAINT [FK_dbo.PrecosPro_dbo.TabPreco_TabPreId] FOREIGN KEY ([TabPreId]) REFERENCES [TabPreco]([SeqTabPre]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 1: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [SubGrupo] ADD CONSTRAINT [FK_dbo.SubGrupo_dbo.Grupo_GrupoId] FOREIGN KEY ([GrupoId]) REFERENCES [Grupo]([GrupoId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 2: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [Produto] ADD CONSTRAINT [FK_dbo.Produto_dbo.Grupo_CodGrupo] FOREIGN KEY ([CodGrupo]) REFERENCES [Grupo]([GrupoId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 3: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [Produto] ADD CONSTRAINT [FK_dbo.Produto_dbo.Marca_CodMarca] FOREIGN KEY ([CodMarca]) REFERENCES [Marca]([MarcaId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 4: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [Produto] ADD CONSTRAINT [FK_dbo.Produto_dbo.SubGrupo_CodSubGrupo] FOREIGN KEY ([CodSubGrupo]) REFERENCES [SubGrupo]([SubGrupoId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 5: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [Produto] ADD CONSTRAINT [FK_dbo.Produto_dbo.Unidade_CodUniEnt] FOREIGN KEY ([CodUniEnt]) REFERENCES [Unidade]([UnidadeId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 6: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [Produto] ADD CONSTRAINT [FK_dbo.Produto_dbo.Unidade_CodUniSai] FOREIGN KEY ([CodUniSai]) REFERENCES [Unidade]([UnidadeId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 7: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [SaldoEstoque] ADD CONSTRAINT [FK_dbo.SaldoEstoque_dbo.Estoque_CodLocalEst] FOREIGN KEY ([CodLocalEst]) REFERENCES [Estoque]([EstoqueId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 8: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [SaldoEstoque] ADD CONSTRAINT [FK_dbo.SaldoEstoque_dbo.Produto_CodProEst] FOREIGN KEY ([CodProEst]) REFERENCES [Produto]([ProdutoId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;
                case 9: //-- Script Date: 24/03/2019 18:50
                    script = "ALTER TABLE [BarrasPro] ADD CONSTRAINT [FK_dbo.BarrasPro_dbo.Produto_ProCodBar] FOREIGN KEY ([ProCodBar]) REFERENCES [Produto]([ProdutoId]) ON DELETE NO ACTION ON UPDATE NO ACTION;";
                    break;                
                default:
                    script = "FIM"; 
                    break;
            }
            
            return script;
        }

    }
}
