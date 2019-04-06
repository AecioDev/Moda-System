using System;
using System.Data;
using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsSGrupo : Form
    {
        private int Tela = 0;
        private int CodGrupo = 0;
        private string Grupo = "";
        private CadProduto cadProduto;
        
        public ConsSGrupo(int _codGrupo, string _grupo)
        {
            InitializeComponent();
            this.CodGrupo = _codGrupo;
            this.Grupo = _grupo;
        }

        public ConsSGrupo(int _codGrupo, string _grupo, CadProduto cadProduto)
        {
            InitializeComponent();
            this.Tela = 1; //Produto
            this.cadProduto = cadProduto;
            this.CodGrupo = _codGrupo;
            this.Grupo = _grupo;
        }

        private void SubGrupos_Load(object sender, EventArgs e)
        {
            lb_Grupo.Text = Grupo;
            Consulta();
        }

        #region Consultas

        private void Consulta()
        {
            SubGrupoRepositorio consSgr = new SubGrupoRepositorio();

            var subGrupos = consSgr.GetByGrupo(CodGrupo);
            subGrupoBindingSource.DataSource = subGrupos;
            grd_Dados.Refresh();

            consSgr.Dispose();
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
                        cadProduto.CodSubGrupo = Convert.ToInt32(cod);
                        cadProduto.tb_sGrupo.Text = desc;
                        break;                    
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadSGrupo CadSGrp = new CadSGrupo(CodGrupo, lb_Grupo.Text, 0);
            CadSGrp.ShowDialog();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                CadSGrupo CadSGrp = new CadSGrupo(CodGrupo, lb_Grupo.Text, codigo);
                CadSGrp.ShowDialog();
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
