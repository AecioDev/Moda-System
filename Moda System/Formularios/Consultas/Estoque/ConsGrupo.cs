using System;
using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsGrupo : Form
    {
        private int Tela = 0;
        private CadProduto CadPro;

        public ConsGrupo(CadProduto _cadPro)
        {
            InitializeComponent();
            this.CadPro = _cadPro;
            this.Tela = 0;
        }

        public ConsGrupo()
        {
            InitializeComponent();
        }

        private void ConsGrupo_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            GrupoRepositorio consGrupo = new GrupoRepositorio();

            var grupos = consGrupo.GetAll();
            grd_Dados.DataSource = grupos;
            grd_Dados.Refresh();

            consGrupo.Dispose();
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
                    case 0: //Produto
                        CadPro.CodGrupo = Convert.ToInt32(cod);
                        CadPro.tb_Grupo.Text = desc;
                        break;
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadGrupo cadGrp = new CadGrupo(0);
            cadGrp.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadGrupo cadGrp = new CadGrupo(codigo);
                cadGrp.ShowDialog();
                Consulta();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
