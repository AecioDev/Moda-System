using System;
using System.Data.SqlServerCe;


namespace Moda_System.Classes
{
    public class DadosCadastros
    {
        public string CadUser(ModelUser user, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO USUARIOS (staUser, nomeUser, emailUser, usuario, senUser, perfilUser)  " +
                           "VALUES (@staUser, @nomeUser, @emailUser,  @usuario, @senUser, @perfilUser)";

            if (mode == 1) //UPDATE
                consulta = "UPDATE USUARIOS SET staUser = @staUser, nomeUser = @nomeUser, emailUser = @emailUser, " +
                           "usuario = @usuario, senUser = @senUser, perfilUser = @perfilUser\n " +
                           "WHERE codUser = @codUser";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (mode != 0) //UPDATE ou DELETE
                    cmd.Parameters.AddWithValue("@codUser", user.CodUser);

                cmd.Parameters.AddWithValue("@staUser", user.StaUser);
                cmd.Parameters.AddWithValue("@nomeUser", user.NomeUser);
                cmd.Parameters.AddWithValue("@emailUser", user.EmailUser);
                cmd.Parameters.AddWithValue("@usuario", user.Usuario);
                cmd.Parameters.AddWithValue("@senUser", user.Senha);
                cmd.Parameters.AddWithValue("@perfilUser", user.PerfUser);


                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadEmpresa(ModelEmpresa Emp, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO EMPRESA (cnpjEmp, statEmp, tipoEmp, codMatriz, razaoEmp, fantEmp, inscEstEmp, inscMunEmp, " +
                           "tel1Emp, tel2Emp, endEmp, nroEndEmp, compEndEmp, bairroEmp, cidadeEmp, dataCadEmp, logoEmp, CEPEmp, UFEmp, " +
                           "empPadrao, tipoData, versaoEmp, nomImglogo) \n" +
                           "VALUES (@cnpjEmp, @statEmp, @tipoEmp, @codMatriz, @razaoEmp, @fantEmp, @inscEstEmp, @inscMunEmp, @tel1Emp, " +
                           "@tel2Emp, @endEmp, @nroEndEmp, @compEndEmp, @bairroEmp, @cidadeEmp, @dataCadEmp, @logoEmp, @CEPEmp, @UFEmp, " +
                           "@empPadrao, @tipoData, @versaoEmp, @nomImglogo)";

            if (mode == 1) //UPDATE
                consulta = "UPDATE EMPRESA SET cnpjEmp = @cnpjEmp, statEmp = @statEmp, tipoEmp = @tipoEmp, codMatriz = @codMatriz, " +
                           "razaoEmp = @razaoEmp, fantEmp = @fantEmp, inscEstEmp = @inscEstEmp, inscMunEmp = @inscMunEmp, " +
                           "tel1Emp = @tel1Emp, tel2Emp = @tel2Emp, endEmp = @endEmp, nroEndEmp = @nroEndEmp, compEndEmp = @compEndEmp, " +
                           "bairroEmp = @bairroEmp, cidadeEmp = @cidadeEmp, dataCadEmp = @dataCadEmp, logoEmp = @logoEmp, " +
                           "CEPEmp = @CEPEmp, UFEmp = @UFEmp, empPadrao = @empPadrao, tipoData = @tipoData, " +
                           "versaoEmp = @versaoEmp, nomImglogo = @nomImglogo \n" +
                           "WHERE codEmp = @codEmp";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (mode > 0) //UPDATE
                    cmd.Parameters.AddWithValue("@codEmp", Emp.codEmp);

                cmd.Parameters.AddWithValue("@cnpjEmp", Emp.cnpjEmp);
                cmd.Parameters.AddWithValue("@statEmp", Emp.statEmp);
                cmd.Parameters.AddWithValue("@tipoEmp", Emp.tipoEmp);
                cmd.Parameters.AddWithValue("@codMatriz", Emp.codMatriz);
                cmd.Parameters.AddWithValue("@razaoEmp", Emp.razaoEmp);
                cmd.Parameters.AddWithValue("@fantEmp", Emp.fantEmp);
                cmd.Parameters.AddWithValue("@inscEstEmp", Emp.inscEstEmp);
                cmd.Parameters.AddWithValue("@inscMunEmp", Emp.inscMunEmp);
                cmd.Parameters.AddWithValue("@tel1Emp", Emp.tel1Emp);
                cmd.Parameters.AddWithValue("@tel2Emp", Emp.tel2Emp);
                cmd.Parameters.AddWithValue("@endEmp", Emp.endEmp);
                cmd.Parameters.AddWithValue("@nroEndEmp", Emp.nroEndEmp);
                cmd.Parameters.AddWithValue("@compEndEmp", Emp.compEndEmp);
                cmd.Parameters.AddWithValue("@bairroEmp", Emp.bairroEmp);
                cmd.Parameters.AddWithValue("@cidadeEmp", Emp.cidadeEmp);
                cmd.Parameters.AddWithValue("@dataCadEmp", Emp.dataCadEmp);
                cmd.Parameters.AddWithValue("@logoEmp", Funcoes.SetImage(Emp.logoEmp, Emp.extimglogo));
                cmd.Parameters.AddWithValue("@CEPEmp", Emp.CEPEmp);
                cmd.Parameters.AddWithValue("@UFEmp", Emp.UFEmp);
                cmd.Parameters.AddWithValue("@empPadrao", Emp.empPadrao);
                cmd.Parameters.AddWithValue("@tipoData", Emp.tipoData);
                cmd.Parameters.AddWithValue("@versaoEmp", Emp.versaoEmp);
                cmd.Parameters.AddWithValue("@nomImglogo", Emp.nomImglogo);

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadFornecedor(ModelFornecedor dados, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO FORNECEDORES (nomeForn, statusForn, cpfForn, cnpjForn, contatoForn, tel1Forn, tel2Forn, emailForn) " +
                           "VALUES (@nomeForn, @statusForn, @cpfForn,  @cnpjForn, @contatoForn, @tel1Forn, @tel2Forn, @emailForn)";

            if (mode == 1) //UPDATE
                consulta = "UPDATE FORNECEDORES SET nomeForn = @nomeForn, statusForn = @statusForn, cpfForn = @cpfForn, cnpjForn = @cnpjForn, " +
                           "contatoForn = @contatoForn, tel1Forn = @tel1Forn, tel2Forn = @tel2Forn, emailForn = @emailForn\n " +
                           "WHERE codForn = @codForn";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (mode != 0) //UPDATE ou DELETE
                    cmd.Parameters.AddWithValue("@codForn", dados.CodForn);

                cmd.Parameters.AddWithValue("@nomeForn", dados.NomeForn);
                cmd.Parameters.AddWithValue("@statusForn", dados.StatusFor);
                cmd.Parameters.AddWithValue("@cpfForn", dados.CpfForn);
                cmd.Parameters.AddWithValue("@cnpjForn", dados.CnpjForn);
                cmd.Parameters.AddWithValue("@contatoForn", dados.ContatoForn);
                cmd.Parameters.AddWithValue("@tel1Forn", dados.Tel1Forn);
                cmd.Parameters.AddWithValue("@tel2Forn", dados.Tel2Forn);
                cmd.Parameters.AddWithValue("@emailForn", dados.EmailForn);


                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadEstoque(ModelDiversos dados, int mode, int tab)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
            {
                switch(tab)
                {
                    case 1: //ESTOQUE
                        consulta = "INSERT INTO ESTOQUE (descEstoque) VALUES (@campoDesc)";
                        break;
                    case 2: //MARCA
                        consulta = "INSERT INTO MARCA (descMarca) VALUES (@campoDesc)";
                        break;
                    case 3: //UNIDADE
                        consulta = "INSERT INTO UNIDADE (descUnidade, siglaUnidade) VALUES (@campoDesc, @sigla)";
                        break;
                    case 4: //GRUPO
                        consulta = "INSERT INTO GRUPO (descGrupo) VALUES (@campoDesc)";
                        break;
                }
            }                

            if (mode == 1) //UPDATE
            {
                switch (tab)
                {
                    case 1: //ESTOQUE
                        consulta = "UPDATE ESTOQUE SET descEstoque = @campoDesc WHERE EstoqueID = @campoID";
                        break;
                    case 2: //MARCA
                        consulta = "UPDATE MARCA SET descMarca = @campoDesc WHERE codMarca = @campoID";
                        break;
                    case 3: //UNIDADE
                        consulta = "UPDATE UNIDADE SET descUnidade = @campoDesc, siglaUnidade =  @sigla WHERE codUnidade = @campoID";
                        break;
                    case 4: //GRUPO
                        consulta = "UPDATE GRUPO SET descGrupo = @campoDesc WHERE codGrupo = @campoID";
                        break;
                }
            }
               
            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (mode != 0) //UPDATE ou DELETE
                    cmd.Parameters.AddWithValue("@campoID", dados.DivID);

                cmd.Parameters.AddWithValue("@campoDesc", dados.DivDesc);

                if(tab == 3) //Unidades
                    cmd.Parameters.AddWithValue("@sigla", dados.DivSigla);

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadSubGrupo(ModelSGrupo dados, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO SUBGRUPO (codgrupo, descSubGrupo) VALUES (@codgrupo, @descsgrupo)";

            if (mode == 1) //UPDATE
                consulta = "UPDATE SUBGRUPO SET descSubGrupo = @descsgrupo \n" +
                            "WHERE codSubGrupo = @codsgrupo and codgrupo = @codgrupo";

            if (mode == 2) //DELETE
                consulta = "DELETE FROM SUBGRUPO WHERE codSubGrupo = @codsgrupo and codgrupo = @codgrupo";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros                
                if(mode > 0)
                    cmd.Parameters.AddWithValue("@codSubGrupo", dados.CodSGrupo);

                cmd.Parameters.AddWithValue("@codgrupo", dados.CodGrupo);
                cmd.Parameters.AddWithValue("@descsgrupo", dados.DescSGrupo);

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadBarras(ModelCodBar bar, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO BARRASPRO (procodbar, forcodbar, codbarras) VALUES (@procodbar, @forcodbar, @codbarras)";

            if (mode == 1) //DELETE
                consulta = "DELETE FROM BARRASPRO WHERE seqcodbar = @seqcodbar";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (mode > 0) //DELETE
                    cmd.Parameters.AddWithValue("@seqcodbar", bar.Seqcodbar);

                cmd.Parameters.AddWithValue("@procodbar", bar.Procodbar);
                cmd.Parameters.AddWithValue("@forcodbar", bar.Forcodbar);
                cmd.Parameters.AddWithValue("@codbarras", bar.Codbarras);

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadTabPreco(ModelTabPreco tab, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO TABPRECO (desctabpre, perclucro, calcprecmp) VALUES (@desctabpre, @perclucro, @calcprecmp)";

            if (mode == 1) //UPDATE
                consulta = "UPDATE TABPRECO SET desctabpre = @desctabpre, perclucro = @perclucro, " +
                            "calcprecmp = @calcprecmp WHERE seqtabpre = @seqtabpre";

            if (mode == 2) //DELETE
                consulta = "DELETE FROM TABPRECO WHERE  seqtabpre = @seqtabpre";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (mode > 0) //DELETE UPDATE
                    cmd.Parameters.AddWithValue("@seqtabpre", tab.Seqtabpre);

                cmd.Parameters.AddWithValue("@desctabpre", tab.Desctabpre);
                cmd.Parameters.AddWithValue("@perclucro", tab.Perclucro);
                cmd.Parameters.AddWithValue("@calcprecmp", tab.Calcprecmp);

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadPrecoPro(ModelPreco preco, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO PRECOSPRO VALUES (@codpropre, @codtabpre, @valproduto, @descprog, @valAntProd)";

            if (mode == 1) //UPDATE
                consulta = "UPDATE PRECOSPRO SET valproduto = @valproduto, descprog = @descprog, valAntProd = @valAntProd \n" +
                            "WHERE codpropre = @codpropre and codtabpre = @codtabpre";

            if (mode == 2) //DELETE
                consulta = "DELETE FROM PRECOSPRO WHERE codpropre = @codpropre and codtabpre = @codtabpre";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros                
                cmd.Parameters.AddWithValue("@codpropre", preco.Codpropre);
                cmd.Parameters.AddWithValue("@codtabpre", preco.Codtabpre);
                cmd.Parameters.AddWithValue("@valproduto", preco.Valproduto);
                cmd.Parameters.AddWithValue("@descprog", preco.Descprog);
                cmd.Parameters.AddWithValue("@valAntProd", preco.Valantprod);

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string CadProduto(ModelProdutos prod, int mode)
        {
            SqlCeConnection conexao = new SqlCeConnection();
            string consulta = "";
            string result = "";

            if (mode == 0) //INSERT
                consulta = "INSERT INTO [PRODUTOS](codRefPro, staProd, descProd, imagProd, codMarca, codGrupo, codSubGrupo, codUnidade, codUniEnt, " +
                            "precoVenda, qtdMinima, obsProd, dataCadPro, controlaQnt, cusreppro, datacuspro, usatabpre, nomeimgpro, cusmedpro, qntEquivPro) " +
                            "VALUES(@codRefPro, @staProd, @descProd, @imagProd, @codMarca, @codGrupo, @codSubGrupo, @codUnidade, @codUniEnt, @precoVenda, @qtdMinima, " +
                            "@obsProd, @dataCadPro, @controlaQnt, @cusreppro, @datacuspro, @usatabpre, @nomeimgpro, @cusmedpro, @qntEquivPro) ";
            
            if (mode == 1) //UPDATE
                consulta =  "UPDATE [PRODUTOS] SET codRefPro = @codRefPro, staProd = @staProd, descProd = @descProd, imagProd = @imagProd, codMarca = @codMarca " +
                            ", codGrupo = @codGrupo, codSubGrupo = @codSubGrupo ,codUnidade = @codUnidade, codUniEnt = @codUniEnt, precoVenda = @precoVenda, qtdMinima = @qtdMinima " +
                            ", obsProd = @obsProd, dataCadPro = @dataCadPro, controlaQnt = @controlaQnt, cusreppro = @cusreppro, datacuspro = @datacuspro, usatabpre = @usatabpre " +
                            ", nomeimgpro = @nomeimgpro,cusmedpro = @cusmedpro, qntEquivPro = @qntEquivPro WHERE codProd = @codProd";
            
            if (mode == 2) //UPDATE Custo
                consulta = "UPDATE [PRODUTOS] SET cusreppro = @cusreppro, cusmedpro = @cusmedpro, datacuspro = @datacuspro \n" +
                           "WHERE codProd = @codProd";

            try
            {
                conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros                

                if (mode == 2)
                {
                    cmd.Parameters.AddWithValue("@codProd", prod.CodPro);
                    cmd.Parameters.AddWithValue("@cusreppro", prod.CustoRep);
                    cmd.Parameters.AddWithValue("@cusmedpro", prod.CustoMed);
                    cmd.Parameters.AddWithValue("@datacuspro", prod.DataCusto);
                }
                else
                {
                    if (mode != 0) //Se for Update ou Delete
                        cmd.Parameters.AddWithValue("@codProd", prod.CodPro);

                    cmd.Parameters.AddWithValue("@codRefPro", prod.RefPro);
                    cmd.Parameters.AddWithValue("@staProd", prod.StaPro);
                    cmd.Parameters.AddWithValue("@descProd", prod.Descpro);
                    cmd.Parameters.AddWithValue("@imagProd", Funcoes.SetImage(prod.ImagProd, prod.Extimg));
                    cmd.Parameters.AddWithValue("@nomeimgpro", prod.Nomeimgpro);
                    cmd.Parameters.AddWithValue("@codMarca", prod.MarcaPro);
                    cmd.Parameters.AddWithValue("@codGrupo", prod.GrupoPro);
                    cmd.Parameters.AddWithValue("@codSubGrupo", prod.SGrupoPro);
                    cmd.Parameters.AddWithValue("@codUnidade", prod.CodUniS);
                    cmd.Parameters.AddWithValue("@codUniEnt", prod.CodUniE);
                    cmd.Parameters.AddWithValue("@precoVenda", prod.PrecoVenda);
                    cmd.Parameters.AddWithValue("@qtdMinima", prod.QtdMinima);
                    cmd.Parameters.AddWithValue("@obsProd", prod.ObsProd);
                    cmd.Parameters.AddWithValue("@dataCadPro", prod.DataCad);
                    cmd.Parameters.AddWithValue("@controlaQnt", prod.ControlaQnt);
                    cmd.Parameters.AddWithValue("@cusreppro", prod.CustoRep);
                    cmd.Parameters.AddWithValue("@cusmedpro", prod.CustoMed);
                    cmd.Parameters.AddWithValue("@datacuspro", prod.DataCusto);
                    cmd.Parameters.AddWithValue("@usatabpre", prod.Usatabpre);
                    cmd.Parameters.AddWithValue("@qntEquivPro", prod.QntEquiv);
                }

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
