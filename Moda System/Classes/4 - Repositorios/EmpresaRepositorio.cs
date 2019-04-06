using System;
using System.Data.SqlServerCe;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Moda_System.Classes
{
    public class EmpresaRepositorio : RepositorioBase<Empresa>, IEmpresaRepositorio
    {

        public string Add_and_Update(Empresa Emp)
        {
            string consulta = "";
            string result = "";

            if (Emp.EmpresaId == 0) //INSERT
                consulta = "INSERT INTO EMPRESA (cnpjEmp, statEmp, tipoEmp, codMatriz, razaoEmp, fantEmp, inscEstEmp, inscMunEmp, " +
                           "tel1Emp, tel2Emp, endEmp, nroEndEmp, compEndEmp, bairroEmp, cidadeEmp, dataCadEmp, CEPEmp, UFEmp, " +
                           "empPadrao, tipoData, versaoEmp, logoEmp, nomImglogo) \n" +
                           "VALUES (@cnpjEmp, @statEmp, @tipoEmp, @codMatriz, @razaoEmp, @fantEmp, @inscEstEmp, @inscMunEmp, @tel1Emp, " +
                           "@tel2Emp, @endEmp, @nroEndEmp, @compEndEmp, @bairroEmp, @cidadeEmp, @dataCadEmp, @CEPEmp, @UFEmp, " +
                           "@empPadrao, @tipoData, @versaoEmp, @logoEmp, @nomImglogo)";

            if (Emp.EmpresaId == 1) //UPDATE
                consulta = "UPDATE EMPRESA SET cnpjEmp = @cnpjEmp, statEmp = @statEmp, tipoEmp = @tipoEmp, codMatriz = @codMatriz, " +
                           "razaoEmp = @razaoEmp, fantEmp = @fantEmp, inscEstEmp = @inscEstEmp, inscMunEmp = @inscMunEmp, " +
                           "tel1Emp = @tel1Emp, tel2Emp = @tel2Emp, endEmp = @endEmp, nroEndEmp = @nroEndEmp, compEndEmp = @compEndEmp, " +
                           "bairroEmp = @bairroEmp, cidadeEmp = @cidadeEmp, dataCadEmp = @dataCadEmp, logoEmp = @logoEmp, " +
                           "CEPEmp = @CEPEmp, UFEmp = @UFEmp, empPadrao = @empPadrao, tipoData = @tipoData, " +
                           "versaoEmp = @versaoEmp, nomImglogo = @nomImglogo \n" +
                           "WHERE EmpresaId = @codEmp";

            try
            {
                SqlCeConnection conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (Emp.EmpresaId > 0) //UPDATE
                    cmd.Parameters.AddWithValue("@codEmp", Emp.EmpresaId);

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
                //cmd.Parameters.AddWithValue("@logoEmp", Funcoes.SetImage(Emp.logoEmp, Emp.extimglogo));
                cmd.Parameters.AddWithValue("@logoEmp",Emp.logoEmp);
                cmd.Parameters.AddWithValue("@CEPEmp", Emp.CEPEmp);
                cmd.Parameters.AddWithValue("@UFEmp", Emp.UFEmp);
                cmd.Parameters.AddWithValue("@empPadrao", Emp.empPadrao);
                cmd.Parameters.AddWithValue("@tipoData", Emp.tipoData);
                cmd.Parameters.AddWithValue("@versaoEmp", Emp.versaoEmp);
                cmd.Parameters.AddWithValue("@nomImglogo", Emp.nomImglogo);

                conexao.Open();
                cmd.ExecuteNonQuery();
                result = "OK";
                conexao.Close();

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }

        public Empresa GetPadrao()
        {
            return Db.Empresa.Where(e => e.empPadrao == "S").FirstOrDefault();
        }

        public Image GetLogo(int codEmp)
        {
            string sql = "";
            Image LogoEmp = null;
            try
            {
                sql = "SELECT logoEmp FROM EMPRESA where EmpresaId = " + codEmp;
                SqlCeConnection conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                SqlCeCommand cmd = new SqlCeCommand(sql, conexao);
                conexao.Open();
                SqlCeDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (!string.IsNullOrEmpty(rd.GetValue(0).ToString()))
                    {
                        LogoEmp = Funcoes.GetImage((byte[])rd.GetValue(0));
                    }
                }

                conexao.Close();

                return LogoEmp;
            }
            catch (Exception ex)
            {
                throw ex;                
            }                        
        }

        //public List<Empresa> ConsEmpresa(Empresa Emp)
        //{
        //    Empresa empRd = new Empresa();
        //    List<Empresa> empRet = new List<Empresa>();
        //    string P0 = ""; string P1 = ""; string P2 = ""; string P3 = "";
        //    string P4 = ""; //string P5 = "";

        //    if (Emp.codEmp > 0)
        //        P0 = " AND codEmp = " + Emp.codEmp;

        //    if (Emp.cnpjEmp != "" && Emp.cnpjEmp != null)
        //        P1 = " AND cnpjEmp LIKE '" + Emp.cnpjEmp + "%'";

        //    if (Emp.fantEmp != "" && Emp.fantEmp != null)
        //        P2 = " AND fantEmp LIKE '" + Emp.fantEmp + "%'";

        //    if (Emp.razaoEmp != "" && Emp.razaoEmp != null)
        //        P3 = " AND razaoEmp LIKE '" + Emp.razaoEmp + "%'";

        //    if (Emp.empPadrao != "" && Emp.empPadrao != null)
        //        P4 = " AND empPadrao = '" + Emp.empPadrao + "'";

        //    //if (Emp.nomeEmp != "" && Emp.nomeEmp != null)
        //    //    P5 = " AND (fantEmp LIKE '" + Emp.nomeEmp + "%' OR razaoEmp LIKE '" + Emp.nomeEmp + "%')";

        //    string sql = String.Format("SELECT * FROM EMPRESA WHERE codEmp > 0 {0}{1}{2}{3}{4}", P0, P1, P2, P3, P4);

        //    try
        //    {
        //        conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
        //        cmd = new SqlCeCommand(sql, conexao);
        //        conexao.Open();
        //        rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            empRd.codEmp       = rd.GetInt32(0);
        //            empRd.cnpjEmp      = rd.GetString(1);
        //            empRd.statEmp      = rd.GetString(2);
        //            empRd.tipoEmp      = rd.GetString(3);
        //            empRd.codMatriz    = rd.GetInt32(4);
        //            empRd.razaoEmp     = rd.GetString(5);
        //            empRd.fantEmp      = rd.GetString(6);
        //            empRd.inscEstEmp   = rd.GetString(7);
        //            empRd.inscMunEmp   = rd.GetString(8);
        //            empRd.tel1Emp      = rd.GetString(9);
        //            empRd.tel2Emp      = rd.GetString(10);
        //            empRd.endEmp       = rd.GetString(11);
        //            empRd.nroEndEmp    = rd.GetInt32(12);
        //            empRd.compEndEmp   = rd.GetString(13);
        //            empRd.bairroEmp    = rd.GetString(14);
        //            empRd.cidadeEmp    = rd.GetString(15);
        //            empRd.dataCadEmp   = rd.GetDateTime(16);
        //            empRd.logoEmp      = Funcoes.GetImage((byte[])rd.GetValue(17));
        //            empRd.CEPEmp       = rd.GetString(18);
        //            empRd.UFEmp        = rd.GetString(19);
        //            empRd.empPadrao    = rd.GetString(20);
        //            empRd.tipoData     = rd.GetString(21);
        //            empRd.versaoEmp    = rd.GetInt32(22);
        //            empRd.nomImglogo   = rd.GetString(23);

        //            empRet.Add(empRd);
        //        }

        //        conexao.Close();

        //        return empRet;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
