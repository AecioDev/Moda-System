using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsUnidade : Form
    {

        private int Tela = 0;
        private CadProduto CadPro;

        public ConsUnidade(CadProduto _cadPro)
        {
            InitializeComponent();
            this.CadPro = _cadPro;
            this.Tela = 0;
        }

        public ConsUnidade()
        {
            InitializeComponent();
        }

        private void ConsUnidade_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            UnidadeRepositorio consUni = new UnidadeRepositorio();

            var unidades = consUni.GetAll();
            unidadeBindingSource.DataSource = unidades;
            grd_Dados.Refresh();

            consUni.Dispose();
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
            string sigla = "";

            if (grd_Dados.Rows.Count > 0)
            {
                id_linha = grd_Dados.CurrentRow.Index; //Pega o índice da linha selecionada            

                cod = grd_Dados.Rows[id_linha].Cells[0].Value.ToString(); //Pega o valor da linha e coluna selecionda
                desc = grd_Dados.Rows[id_linha].Cells[1].Value.ToString();
                sigla = grd_Dados.Rows[id_linha].Cells[2].Value.ToString();

                switch (Tela)
                {                    
                    case 0: //Produto
                        CadPro.CodUni = Convert.ToInt32(cod);
                        CadPro.DescUni = desc;
                        CadPro.SiglaUni = sigla;
                        break;
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadUnidade cadUni = new CadUnidade(0);
            cadUni.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadUnidade cadUni = new CadUnidade(codigo);
                cadUni.ShowDialog();
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
