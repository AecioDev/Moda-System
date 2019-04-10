using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Data;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsFornecedor : Form
    {
        public ConsFornecedor()
        {
            InitializeComponent();
        }

        private void ConsFornecedor_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            string status = "";
            FornecedorRepositorio consFor = new FornecedorRepositorio();

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
                        grd_Dados.Rows[row].Cells[2].Value = forn.CnpjForn;                                            }

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

        private void bt_Confirmar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadFornecedor cadFor = new CadFornecedor(0);
            cadFor.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadFornecedor cadFor = new CadFornecedor(codigo);
                cadFor.ShowDialog();
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
