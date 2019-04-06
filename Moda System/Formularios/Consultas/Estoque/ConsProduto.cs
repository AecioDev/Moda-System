using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsProduto : Form
    {
        //Continuação:         

        ProdutoRepositorio consProd;

        public ConsProduto()
        {
            InitializeComponent();
        }

        private void ConsProduto_Load(object sender, EventArgs e)
        {
            cb_Status.SelectedIndex = 2;
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            Produto filtro = new Produto();
            consProd = new ProdutoRepositorio();

            switch (cb_Status.SelectedIndex)
            {
                case 0:
                    filtro.StaProd = "A";
                    break;
                case 1:
                    filtro.StaProd = "I";
                    break;
            }
            filtro.DescProd = tb_nome.Text;
            filtro.CodBarras = tb_codBarras.Text;
            filtro.CodRefPro = tb_referencia.Text;
            filtro.CodMarca = Convert.ToInt32(cb_Marcas.SelectedValue);
            filtro.CodGrupo = Convert.ToInt32(cb_Grupo.SelectedValue);
            filtro.CodSubGrupo = Convert.ToInt32(cb_SGrupo.SelectedValue);

            var produtos = consProd.ConsultaPro(filtro);
            if (produtos.Count > 0)
            {
                grd_Dados.Rows.Clear();
                foreach (Produto prod in produtos)
                {
                    //Adiciona na Grid
                    grd_Dados.Rows.Add();
                    grd_Dados.Rows[row].Cells[0].Value = prod.ProdutoId;
                    grd_Dados.Rows[row].Cells[1].Value = prod.CodRefPro;
                    grd_Dados.Rows[row].Cells[2].Value = prod.DescProd;
                    grd_Dados.Rows[row].Cells[3].Value = prod.UniSai.SiglaUnidade;
                    grd_Dados.Rows[row].Cells[4].Value = prod.Marca.DescMarca;

                    row++;
                }
            }
            else
            {
                grd_Dados.Rows.Clear();
            }

            consProd.Dispose();

            pb_imgPro.Image = pb_imgPro.InitialImage;
        }

        private void grd_Dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            consProd = new ProdutoRepositorio();

            pb_imgPro.Image = pb_imgPro.InitialImage;
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codPro = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                pb_imgPro.Image = consProd.GetImagePro(codPro);
                if (pb_imgPro.Image == null)
                {
                    pb_imgPro.Image = pb_imgPro.InitialImage;
                }
            }
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_refPro_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
        #endregion

        private void bt_Confirmar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadProduto cadPro = new CadProduto(0);
            cadPro.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadProduto cadPro = new CadProduto(codigo);
                cadPro.ShowDialog();
                Consulta();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Animação Botões
        private void bt_Enter(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;

            switch (btNome)
            {
                case "bt_Confirmar":
                    bt_Confirmar.Size = new System.Drawing.Size(108, 47);
                    break;
                case "bt_Cadastrar":
                    bt_Cadastrar.Size = new System.Drawing.Size(108, 47);
                    break;
                case "bt_Modificar":
                    bt_Modificar.Size = new System.Drawing.Size(108, 47);
                    break;
                case "bt_Atualizar":
                    bt_Atualizar.Size = new System.Drawing.Size(108, 47);
                    break;
            }
        }

        private void bt_Leave(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;

            switch (btNome)
            {
                case "bt_Confirmar":
                    bt_Confirmar.Size = new System.Drawing.Size(105, 44);
                    break;
                case "bt_Cadastrar":
                    bt_Cadastrar.Size = new System.Drawing.Size(105, 44);
                    break;
                case "bt_Modificar":
                    bt_Modificar.Size = new System.Drawing.Size(105, 44);
                    break;
                case "bt_Atualizar":
                    bt_Atualizar.Size = new System.Drawing.Size(105, 44);
                    break;
            }
        }




        #endregion

        
    }
}
