using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Data;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsEstoque : Form
    {        
        private int Tela = 0;
        private int CodEst = 0;
        private CadVeiculo cadVeiculo;

        public ConsEstoque()
        {
            InitializeComponent();
        }
        
        public ConsEstoque(CadVeiculo cadVeiculo)
        {
            this.Tela = 1;
            this.cadVeiculo = cadVeiculo;
            InitializeComponent();
        }

        private void ConsEstoque_Load(object sender, EventArgs e)
        {            
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            EstoqueRepositorio cadEst = new EstoqueRepositorio();

            var est = cadEst.GetByDesc(tb_nome.Text);
            estoqueBindingSource.DataSource = est;
            grd_Dados.Refresh();

            cadEst.Dispose();
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
                    case 1: //Estoque
                        cadVeiculo.CodEstoque = Convert.ToInt32(cod);
                        cadVeiculo.tb_Estoque.Text = desc;
                        break;
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadEstoque est = new CadEstoque(0);
            est.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadEstoque est = new CadEstoque(codigo);
                est.ShowDialog();
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
