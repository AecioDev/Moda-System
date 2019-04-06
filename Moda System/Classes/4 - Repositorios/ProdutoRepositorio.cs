
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;

namespace Moda_System.Classes
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produto.Where(p => p.DescProd == nome);
        }

        public List<Produto> ConsultaPro(Produto filtro)
        {
            var pro = Db.Produto.AsQueryable();

            //Descrição
            if (!string.IsNullOrEmpty(filtro.DescProd))
                pro = pro.Where(p => p.DescProd.Contains(filtro.DescProd));

            //CodBarras
            if (!string.IsNullOrEmpty(filtro.CodBarras))
            {
                var codbarras = Db.Barras.Where(b => b.Codbarras == filtro.CodBarras).FirstOrDefault();
                pro = pro.Where(p => p.ProdutoId == codbarras.ProCodBar);
            }
                
            //Referencia
            if (!string.IsNullOrEmpty(filtro.CodRefPro))
                pro = pro.Where(p => p.CodRefPro.Contains(filtro.CodRefPro));

            //Status
            if (!string.IsNullOrEmpty(filtro.StaProd))
                pro = pro.Where(p => p.StaProd == filtro.StaProd);

            //Marca
            if (filtro.CodMarca > 0)
                pro = pro.Where(p => p.CodMarca == filtro.CodMarca);

            //Grupo
            if (filtro.CodGrupo > 0)
                pro = pro.Where(p => p.CodGrupo == filtro.CodGrupo);

            //SubGrupo
            if (filtro.CodSubGrupo > 0)
                pro = pro.Where(p => p.CodSubGrupo == filtro.CodSubGrupo);

            return pro.ToList();
        }

        public Image GetImagePro(int codPro)
        {
            string sql = "";
            Image Imagem = null;
            try
            {
                sql = "SELECT ImagProd FROM PRODUTO where ProdutoId = " + codPro;
                SqlCeConnection conexao = new SqlCeConnection(Funcoes.Busca_Conexao());
                SqlCeCommand cmd = new SqlCeCommand(sql, conexao);
                conexao.Open();
                SqlCeDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (!string.IsNullOrEmpty(rd.GetValue(0).ToString()))
                    {
                        Imagem = Funcoes.GetImage((byte[])rd.GetValue(0));
                    }
                }

                conexao.Close();

                return Imagem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Add_and_Update(Produto pro)
        {
            string consulta = "";
            string result = "";


            if (pro.ProdutoId > 0) //UPDATE
            {
                consulta = "UPDATE PRODUTO SET CodRefPro = @CodRefPro, StaProd = @StaProd, DescProd = @DescProd, CodMarca = @CodMarca, " +
                           "CodGrupo = @CodGrupo, CodSubGrupo = @CodSubGrupo, CodUniSai = @CodUniSai, CodUniEnt = @CodUniEnt, " +
                           "QntEquiv = @QntEquiv, PrecoVenda = @PrecoVenda, QtdMinima = @QtdMinima, ObsProd = @ObsProd, " +
                           "DataCadPro = @DataCadPro, ControlaQnt = @ControlaQnt, CustoMedPro = @CustoMedPro, CustoRepPro = @CustoRepPro, " +
                           "DataCusPro = @DataCusPro, UsaTabPre = @UsaTabPre, ImagProd = @ImagProd, NomeImgPro = @NomeImgPro " +
                           "WHERE ProdutoId = @ProdutoId";
            }
            else //INSERT
            {
                consulta = "INSERT INTO Produto(CodRefPro, StaProd, DescProd, CodMarca, CodGrupo, CodSubGrupo, CodUniSai, CodUniEnt, " +
                    "QntEquiv, PrecoVenda, QtdMinima, ObsProd, DataCadPro, ControlaQnt, CustoMedPro, CustoRepPro, " +
                    "DataCusPro, UsaTabPre, ImagProd, NomeImgPro) VALUES (@CodRefPro, @StaProd, @DescProd, @CodMarca, " +
                    "@CodGrupo, @CodSubGrupo, @CodUniSai, @CodUniEnt, @QntEquiv, @PrecoVenda, @QtdMinima, @ObsProd, " +
                    "@DataCadPro, @ControlaQnt, @CustoMedPro, @CustoRepPro, @DataCusPro, @UsaTabPre, @ImagProd, @NomeImgPro)";
            }
            
            try
            {
                SqlCeConnection conexao = Funcoes.CriaConexao();
                SqlCeCommand cmd = new SqlCeCommand(consulta, conexao);

                //Parâmetros
                if (pro.ProdutoId > 0) //UPDATE
                    cmd.Parameters.AddWithValue("@ProdutoId", pro.ProdutoId);

                cmd.Parameters.AddWithValue("@CodRefPro", pro.CodRefPro);
                cmd.Parameters.AddWithValue("@StaProd", pro.StaProd);
                cmd.Parameters.AddWithValue("@DescProd", pro.DescProd);
                cmd.Parameters.AddWithValue("@CodMarca", pro.CodMarca);
                cmd.Parameters.AddWithValue("@CodGrupo", pro.CodGrupo);
                cmd.Parameters.AddWithValue("@CodSubGrupo", pro.CodSubGrupo);
                cmd.Parameters.AddWithValue("@CodUniSai", pro.CodUniSai);
                cmd.Parameters.AddWithValue("@CodUniEnt", pro.CodUniEnt);
                cmd.Parameters.AddWithValue("@QntEquiv", pro.QntEquiv);
                cmd.Parameters.AddWithValue("@PrecoVenda", pro.PrecoVenda);
                cmd.Parameters.AddWithValue("@QtdMinima", pro.QtdMinima);
                cmd.Parameters.AddWithValue("@ObsProd", pro.ObsProd);
                cmd.Parameters.AddWithValue("@DataCadPro", pro.DataCadPro);
                cmd.Parameters.AddWithValue("@ControlaQnt", pro.ControlaQnt);
                cmd.Parameters.AddWithValue("@CustoMedPro", pro.CustoMedPro);
                cmd.Parameters.AddWithValue("@CustoRepPro", pro.CustoRepPro);
                cmd.Parameters.AddWithValue("@DataCusPro", pro.DataCusPro);
                cmd.Parameters.AddWithValue("@UsaTabPre", pro.UsaTabPre);
                cmd.Parameters.AddWithValue("@ImagProd", pro.ImagProd);
                cmd.Parameters.AddWithValue("@NomeImgPro", pro.NomeImgPro);

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

    }
}
