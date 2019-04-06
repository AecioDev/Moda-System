using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsUsuarios : Form
    {

        public string msgCab = Funcoes.msgCab;

        public ConsUsuarios()
        {
            InitializeComponent();
        }

        private void ConsUsuarios_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        private void Consulta()
        {
            string status = "";
            UsuarioRepositorio consUser = new UsuarioRepositorio();

            usuarioBindingSource.Clear();
            switch (cb_Status.SelectedIndex)
            {
                case 1:
                    status = "A";
                    break;
                case 2:
                    status = "I";
                    break;
            }

            var usuarios = consUser.ConsultaUser(tb_Login.Text, status, tb_nome.Text);
            usuarioBindingSource.DataSource = usuarios;
            grd_Dados.Refresh();

            consUser.Dispose();

        }

        private void grd_Dados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int ln = e.RowIndex;
            int cl = e.ColumnIndex;
            string status = "";
            string perfil = "";

            if (cl == 4)
            {
                status = grd_Dados.Rows[ln].Cells[4].Value.ToString();
                switch (status)
                {
                    case "A":
                        grd_Dados.Rows[ln].Cells[4].Value = "Ativo";
                        break;
                    case "I":
                        grd_Dados.Rows[ln].Cells[4].Value = "Inativo";
                        break;
                }
            }

            if (cl == 3)
            {
                perfil = grd_Dados.Rows[ln].Cells[3].Value.ToString();
                switch (perfil)
                {
                    case "A": //Administrador
                        grd_Dados.Rows[ln].Cells[3].Value = "Administrador";
                        break;
                    case "U":  //Usuário
                        grd_Dados.Rows[ln].Cells[3].Value = "Usuário";
                        break;
                }
            }
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_Login_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadUsuarios cadUser = new CadUsuarios(0);
            cadUser.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadUsuarios cadUser = new CadUsuarios(codigo);
                cadUser.ShowDialog();
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
