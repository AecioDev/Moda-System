using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Data;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas.Estoque
{
    public partial class ConsMovEstoque : Form
    {
        public ConsMovEstoque()
        {
            InitializeComponent();
        }

        private void ConsMovEstoque_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            string status = "";
            MovEstoqueRepositorio consMov = new MovEstoqueRepositorio();

            switch (cb_Status.SelectedIndex)
            {
                case 1:
                    status = "A";
                    break;
                case 2:
                    status = "I";
                    break;
            }

            var fornecedor = consFor.ConsultaFor(status, tb_Doc.Text, tb_nome.Text);
            if (fornecedor.Count > 0)
            {
                grd_Dados.Rows.Clear();
                foreach (Fornecedor forn in fornecedor)
                {
                    //Adiciona o PDV na Grid                   
                    grd_Dados.Rows.Add();
                    grd_Dados.Rows[row].Cells[0].Value = forn.FornecedorId;
                    grd_Dados.Rows[row].Cells[1].Value = forn.NomeForn;

                    if (forn.CnpjForn.Length > 0)
                    {
                        grd_Dados.Rows[row].Cells[2].Value = forn.CnpjForn;
                    }

                    if (forn.CpfForn.Length > 0)
                    {
                        grd_Dados.Rows[row].Cells[2].Value = forn.CpfForn;
                    }

                    grd_Dados.Rows[row].Cells[3].Value = forn.Tel1Forn;
                    grd_Dados.Rows[row].Cells[4].Value = forn.Tel2Forn;

                    switch (forn.StatusFor)
                    {
                        case "A":
                            grd_Dados.Rows[row].Cells[5].Value = "Ativo";
                            break;
                        case "I":
                            grd_Dados.Rows[row].Cells[5].Value = "Inativo";
                            break;
                    }

                    row++;
                }
            }
            else
            {
                grd_Dados.Rows.Clear();
            }

            consFor.Dispose();
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_Doc_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
        #endregion

    }
}
