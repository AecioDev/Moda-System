using System;
using System.Data;
using System.Data.SqlServerCe;

namespace Moda_System.Classes
{
    public class DadosConsultas
    {
        //Variáveis de Conexão
        SqlCeConnection conexao = null;
        SqlCeCommand cmd = null;
        SqlCeDataReader reader = null;
        SqlCeDataAdapter daDados = null;
        DataTable dtDados = null;

        public string erroExecSQL = "";

        public DataTable Usuarios(ModelUser User)
        {            
            string sql = "";
            string P1 = ""; string P2 = ""; string P3 = ""; string P4 = ""; string P5 = "";
            erroExecSQL = "";

            if (User.CodUser > 0)
                P1 = " AND codUser = " + User.CodUser;

            if (User.Usuario != "" && User.Usuario != null)
                P2 = " AND usuario LIKE '" + User.Usuario + "%'";

            if (User.NomeUser != "" && User.NomeUser != null)
                P3 = " AND nomeUser LIKE '" + User.NomeUser + "%'";

            if (User.StaUser != "" && User.StaUser != null)
                P4 = " AND staUser = '" + User.StaUser + "'";

            if (User.PerfUser != "" && User.PerfUser != null)
                P5 = " AND perfilUser = '" + User.PerfUser + "'";

            sql = String.Format("SELECT * FROM USUARIOS WHERE usuario <> 'ADMIN' {0}{1}{2}{3}{4}", P1, P2, P3, P4, P5);
            
            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);                
                return dtDados;
            }
            catch (Exception ex)
            {
                erroExecSQL = ex.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }   //Usuários

        public ModelUser ValidaUsuario(ModelUser User)
        {
            ModelUser user = new ModelUser();
            string senHash = "";
            erroExecSQL = "";

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());

                string conSql = "SELECT codUser, usuario, senUser, perfilUser, staUser FROM USUARIOS " +
                                "WHERE (usuario = @user)";

                cmd = new SqlCeCommand(conSql, conexao);
                cmd.Parameters.AddWithValue("@user", User.Usuario);

                conexao.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user.CodUser = reader.GetInt32(0);
                    user.Usuario = reader.GetString(1);
                    senHash = reader.GetString(2);
                    user.PerfUser = reader.GetString(3);
                    user.StaUser = reader.GetString(4);
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                erroExecSQL = ex.Message;
                return null;
            }

            if (user.CodUser > 0)
            {
                if (Funcoes.VerifyMd5Hash(User.Senha, senHash))
                    return user;
                else
                {
                    user.CodUser = 0;
                    return user;
                }
            }
            
            return user;

        }   //ValidaUsuario

        public DataTable Empresa(ModelEmpresa Emp)
        {
            string P0 = ""; string P1 = ""; string P2 = ""; string P3 = "";
            string P4 = ""; //string P5 = "";

            if (Emp.codEmp > 0)
                P0 = " AND codEmp = " + Emp.codEmp;

            if (Emp.cnpjEmp != "" && Emp.cnpjEmp != null)
                P1 = " AND cnpjEmp LIKE '" + Emp.cnpjEmp + "%'";

            if (Emp.fantEmp != "" && Emp.fantEmp != null)
                P2 = " AND fantEmp LIKE '" + Emp.fantEmp + "%'";

            if (Emp.razaoEmp != "" && Emp.razaoEmp != null)
                P3 = " AND razaoEmp LIKE '" + Emp.razaoEmp + "%'";

            if (Emp.empPadrao != "" && Emp.empPadrao != null)
                P4 = " AND empPadrao = '" + Emp.empPadrao + "'";

            //if (Emp.nomeEmp != "" && Emp.nomeEmp != null)
            //    P5 = " AND (fantEmp LIKE '" + Emp.nomeEmp + "%' OR razaoEmp LIKE '" + Emp.nomeEmp + "%')";

            string sql = String.Format("SELECT * FROM EMPRESA WHERE codEmp > 0 {0}{1}{2}{3}{4}", P0, P1, P2, P3, P4);

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }   //Empresa

        public DataTable Fornecedor(ModelFornecedor filtro)
        {
            string P0 = ""; string P1 = ""; string P2 = ""; string P3 = "";
            string P4 = ""; string P5 = "";

            if (filtro.CodForn > 0)
                P0 = " AND codForn = " + filtro.CodForn;

            if (filtro.CnpjForn != "" && filtro.CnpjForn != null)
                P1 = " AND cnpjForn LIKE '" + filtro.CnpjForn + "%'";

            if (filtro.CpfForn != "" && filtro.CpfForn != null)
                P2 = " AND cpfForn LIKE '" + filtro.CpfForn + "%'";

            if (filtro.DocForn != "" && filtro.DocForn != null)
                P3 = " AND (cpfForn LIKE '" + filtro.DocForn + "%' OR cnpjForn LIKE '" + filtro.DocForn + "%')";

            if (filtro.NomeForn != "" && filtro.NomeForn != null)
                P4 = " AND nomeForn LIKE '" + filtro.NomeForn + "%'";

            if (filtro.StatusFor != "" && filtro.StatusFor != null)
                P5 = " AND statusForn = '" + filtro.StatusFor + "'";


            string sql = String.Format("SELECT * FROM FORNECEDORES WHERE codForn > 0 {0}{1}{2}{3}{4}{5}", P0, P1, P2, P3, P4, P5);

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }   //Fornercedor

        public DataTable Diversos(ModelDiversos filtro, int tab) //1 - Estoque, 2 - Marca, 3 - Unidades, 4 - Grupo
        {
            string P0 = ""; string P1 = ""; string P2 = ""; string sql = ""; string chave = "";

            switch (tab)
            {
                case 1: //ESTOQUE
                    if (filtro.DivID > 0)
                        P0 = " AND EstoqueID = " + filtro.DivID;
                    if (filtro.DivDesc != "" && filtro.DivDesc != null)
                        P1 = " AND descEstoque LIKE '" + filtro.DivDesc + "%'";
                    chave = "EstoqueID";
                    break;

                case 2: //MARCA
                    if (filtro.DivID > 0)
                        P0 = " AND codMarca = " + filtro.DivID;
                    if (filtro.DivDesc != "" && filtro.DivDesc != null)
                        P1 = " AND descMarca LIKE '" + filtro.DivDesc + "%'";
                    chave = "codMarca";
                    break;

                case 3: //UNIDADES
                    if (filtro.DivID > 0)
                        P0 = " AND codUnidade = " + filtro.DivID;
                    if (filtro.DivDesc != "" && filtro.DivDesc != null)
                        P1 = " AND descUnidade LIKE '" + filtro.DivDesc + "%'";
                    if (filtro.DivSigla != "" && filtro.DivSigla != null)
                        P2 = " AND siglaUnidade LIKE '" + filtro.DivSigla + "%'";
                    chave = "codUnidade";
                    break;

                case 4: //GRUPO
                    if (filtro.DivID > 0)
                        P0 = " AND codGrupo = " + filtro.DivID;
                    if (filtro.DivDesc != "" && filtro.DivDesc != null)
                        P1 = " AND descGrupo LIKE '" + filtro.DivDesc + "%'";
                    chave = "codGrupo";
                    break;

                case 5: //SUBGRUPO
                    if (filtro.DivID > 0)
                        P0 = " AND codSubGrupo = " + filtro.DivID;
                    if (filtro.DivDesc != "" && filtro.DivDesc != null)
                        P1 = " AND descSubGrupo LIKE '" + filtro.DivDesc + "%'";
                    chave = "SubGID";
                    break;
            }

            switch (tab)
            {
                case 1: //ESTOQUE
                    sql = String.Format("SELECT * FROM ESTOQUE WHERE " + chave +" > 0 {0}{1}", P0, P1);
                    break;
                case 2: //MARCA
                    sql = String.Format("SELECT * FROM MARCA WHERE " + chave + " > 0 {0}{1}", P0, P1);
                    break;
                case 3: //UNIDADES
                    sql = String.Format("SELECT * FROM UNIDADE WHERE " + chave + " > 0 {0}{1}", P0, P1);
                    break;
                case 4: //GRUPO
                    sql = String.Format("SELECT * FROM GRUPO WHERE " + chave + " > 0 {0}{1}", P0, P1);
                    break;
                case 5: //SUBGRUPO
                    sql = String.Format("SELECT * FROM SUBGRUPO WHERE " + chave + " > 0 {0}{1}", P0, P1);
                    break;
            }
           
            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }   //Estoque, Marca, Unidades, Grupo

        public DataTable SubGrupo(ModelSGrupo filtro)
        {
            string P0 = ""; string P1 = ""; string P2 = "";

            if (filtro.CodGrupo > 0)
                P0 = " AND codGrupo = " + filtro.CodGrupo;

            if (filtro.CodSGrupo > 0)
                P1 = " AND codSubGrupo = " + filtro.CodSGrupo;

            if (filtro.DescSGrupo != "" && filtro.DescSGrupo != null)
                P2 = " AND descSubGrupo LIKE '" + filtro.DescSGrupo + "%'";

            string sql = String.Format("SELECT * FROM SUBGRUPO WHERE codSubGrupo > 0 {0}{1}{2}", P0, P1, P2);

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable Produto(ModelProdutos filtro, int tipo)
        {
            string P1 = ""; string P2 = ""; string P3 = "";
            string P4 = ""; string sql = "";

            if (filtro.CodPro > 0)
                P1 = " AND P.codProd = " + filtro.CodPro;

            if (filtro.StaPro != "" && filtro.StaPro != null)
                P2 = " AND P.staProd LIKE '" + filtro.StaPro + "%'";

            if (filtro.Descpro != "" && filtro.Descpro != null)
                P3 = " AND P.descProd LIKE '" + filtro.Descpro + "%'";

            if (filtro.RefPro != "" && filtro.RefPro != null)
                P4 = " AND P.codRefPro LIKE '" + filtro.RefPro + "%'";

            //if (filtro.MarcaPro != "" && filtro.MarcaPro != null)
            //    P5 = " AND P.codMarca = " + prod.MarcaPro;

            //if (filtro.GrupoPro != "" && filtro.GrupoPro != null)
            //    P6 = " AND P.codGrupo = " + filtro.GrupoPro;

            //if (filtro.SGrupoPro != "" && filtro.SGrupoPro != null)
            //    P7 = " AND P.codSubGrupo = " + prod.SGrupoPro;

            if (tipo == 0)
            {
                sql = String.Format("SELECT * FROM PRODUTOS P WHERE codProd > 0 {0}{1}{2}{3}",
                    P1, P2, P3, P4);
            }
            else
            {
                sql = String.Format("SELECT P.*, G.descGrupo, M.descMarca, SG.descSubGrupo,  \n" +
                                    "US.descUnidade AS descUniS, US.siglaUnidade AS siglaUniS,  \n" +
                                    "UE.descUnidade AS descUniE, UE.siglaUnidade AS siglaUniE  \n" +
                                    "FROM PRODUTOS AS P \n" +
                                    "INNER JOIN GRUPO AS G ON G.codGrupo = P.codGrupo \n" +
                                    "INNER JOIN MARCA AS M ON M.codMarca = P.codMarca \n" +
                                    "INNER JOIN SUBGRUPO AS SG ON SG.codSubGrupo = P.codSubGrupo \n" +
                                    "INNER JOIN UNIDADE AS US ON US.codUnidade = P.codUnidade \n" +
                                    "INNER JOIN UNIDADE AS UE ON UE.codUnidade = P.codUniEnt \n" + 
                                    "WHERE codProd > 0 {0}{1}{2}{3}", P1, P2, P3, P4);
               
            }

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }   //Produtos

        public DataTable Barras(ModelCodBar filtro)
        {
            string P0 = ""; string P1 = ""; string P2 = ""; string P3 = "";

            if (filtro.Seqcodbar > 0)
                P0 = " AND seqcodbar = " + filtro.Seqcodbar;

            if (filtro.Procodbar > 0)
                P1 = " AND procodbar = " + filtro.Procodbar;

            if (filtro.Forcodbar > 0)
                P2 = " AND forcodbar = " + filtro.Forcodbar;

            if (filtro.Codbarras != "" && filtro.Codbarras != null)
                P3 = " AND codbarras = '" + filtro.Codbarras + "'";

            string sql = String.Format("SELECT * FROM BARRASPRO WHERE seqcodbar > 0 {0}{1}{2}{3}",
                P0, P1, P2, P3);

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }   //consulta Código de Barras

        public DataTable TabPreco(ModelTabPreco filtro)
        {
            string P0 = "";

            if (filtro.Seqtabpre > 0)
                P0 = " AND seqtabpre = " + filtro.Seqtabpre;
                       
            string sql = String.Format("SELECT * FROM TABPRECO WHERE seqtabpre > 0 {0}", P0);

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }   

        public DataTable PrecoPro(ModelPreco filtro)
        {
            string P0 = ""; string P1 = "";

            if (filtro.Codpropre > 0)
                P0 = " AND codpropre = " + filtro.Codpropre;

            if (filtro.Codtabpre > 0)
                P1 = " AND codtabpre = " + filtro.Codtabpre;

            string sql = String.Format("SELECT * FROM PRECOSPRO P INNER JOIN TABPRECO T on T.seqtabpre = P.codtabpre " +
                                       "WHERE codtabpre > 0 {0}{1}", P0, P1);

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable SaldoEstoque(ModelSaldoEst filtro)
        {
            string P0 = ""; string P1 = "";

            if (filtro.CodLocal > 0)
                P0 = " AND codLocalEst = " + filtro.CodLocal;

            if (filtro.CodPro > 0)
                P1 = " AND codProEst = " + filtro.CodPro;

            string sql = String.Format("SELECT * FROM SALDOESTOQUE S " +
                                       "INNER JOIN ESTOQUE E on E.EstoqueID = S.codLocalEst " +
                                       "WHERE idSaldoEst > 0 {0}{1}", P0, P1);

            try
            {
                conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                cmd = new SqlCeCommand(sql, conexao);
                daDados = new SqlCeDataAdapter(cmd);

                dtDados = new DataTable();
                daDados.Fill(dtDados);
                return dtDados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        
    }
}
