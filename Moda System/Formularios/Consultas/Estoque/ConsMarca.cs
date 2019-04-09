using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsMarca : Form
    {
        private int Tela = 0;
        private int CodMar = 0;
        private CadProduto cadProduto;

        public ConsMarca()
        {
            InitializeComponent();
        }

        public ConsMarca(CadProduto cadProduto)
        {
            this.cadProduto = cadProduto;
            this.Tela = 1;
            InitializeComponent();
        }

        private void ConsMarca_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            MarcaRepositorio cadMar = new MarcaRepositorio();

            var marca = cadMar.GetByDesc(tb_nome.Text);
            grd_Dados.DataSource = marca;
            grd_Dados.Refresh();

            cadMar.Dispose();
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
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
            int id_linha = 0;
            string cod = "";
            string desc = "";

            if (grd_Dados.Rows.Count > 0)
            {
                id_linha = grd_Dados.CurrentRow.Index; //Pega o índice da linha selecionada            

                cod = grd_Dados.Rows[id_linha].Cells[0].Value.ToString(); //Pega o valor da linha e coluna selecionda
                desc = grd_Dados.Rows[id_linha].Cells[1].Value.ToString();

                switch (Tela)
                {
                    case 1: //Produto
                        cadProduto.CodMarca = Convert.ToInt32(cod);
                        cadProduto.tb_Marca.Text = desc;
                        break;
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadMarca mar = new CadMarca(0);
            mar.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadMarca mar = new CadMarca(codigo);
                mar.ShowDialog();
                Consulta();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
