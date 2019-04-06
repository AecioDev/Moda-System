using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using Moda_System.Formularios.Consultas;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Moda_System.Formularios.Inicio
{
    public partial class Home : Form
    {
        DataTable dtDados = new DataTable();
        DadosConsultas dados = new DadosConsultas();
        private string msgCab = Funcoes.msgCab;
        private int CodEmp = 0;
        private int CodUser = 0;
        private string Usuario = "";
        private string PerfUser = "";
        private bool mostrarMenu = false;

        public Home()
        {
            InitializeComponent();
        }

        public Home(int codUser)
        {
            InitializeComponent();
            this.CodUser = codUser;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            EmpresaRepositorio consEmp = new EmpresaRepositorio();
            UsuarioRepositorio consUser = new UsuarioRepositorio();
            int linhas = 0;

            var emp = consEmp.GetPadrao();
            
            if (emp.EmpresaId > 0)
            {
                CodEmp = emp.EmpresaId;
                tb_fantEmp.Text = emp.fantEmp;
                tb_Versao.Text = "Versão - " + emp.versaoEmp.ToString();
            }

            var user = consUser.GetById(CodUser);
            
            if (user.UsuarioId > 0)
            {
                Usuario = user.LoginUser;
                PerfUser = user.PerfilUser;
            }
            dtDados.Clear();

            linhas = DateTime.Now.Hour;
            if (linhas >= 0 && linhas < 6) //Madrugada
                lb_BoaVinda.Text = "Bem Vindo(a) " + Usuario + ", Boa Madrugada!!!";
            else if (linhas >= 6 && linhas < 12) //Manhã
                lb_BoaVinda.Text = "Bem Vindo(a) " + Usuario + ", Bom Dia!!!";
            else if (linhas >= 12 && linhas < 18) //Tarde
                lb_BoaVinda.Text = "Bem Vindo(a) " + Usuario + ", Boa Tarde!!!";
            else  //Noite
                lb_BoaVinda.Text = "Bem Vindo(a) " + Usuario + ", Boa Noite!!!";
                        
        }

        private void Relogio_Tick(object sender, EventArgs e)
        {
            lb_dataHora.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        #region Animação Menu
        private void bt_Menu_Click(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;
            mostrarMenu = !mostrarMenu;

            Pnl_DadosGerais.Visible = false;
            Pnl_Estoque.Visible = false;
            pnl_Movimentacao.Visible = false;

            switch (btNome)
            {
                case "bt_Menu01":
                    Pnl_DadosGerais.Visible = mostrarMenu;
                    break;
                case "bt_Menu02":
                    Pnl_Estoque.Visible = mostrarMenu;
                    break;
                case "bt_Menu03":
                    pnl_Movimentacao.Visible = mostrarMenu;
                    break;
            }
        }

        private void bt_Menu01_Enter(object sender, EventArgs e)
        {
            Pnl_DadosGerais.Visible = true;
            Pnl_Estoque.Visible = false;
            pnl_Movimentacao.Visible = false;
            mostrarMenu = true;
        }

        private void bt_Menu02_Enter(object sender, EventArgs e)
        {
            Pnl_DadosGerais.Visible = false;
            Pnl_Estoque.Visible = true;
            pnl_Movimentacao.Visible = false;
            mostrarMenu = true;
        }

        private void bt_Menu03_Enter(object sender, EventArgs e)
        {
            Pnl_DadosGerais.Visible = false;
            Pnl_Estoque.Visible = false;
            pnl_Movimentacao.Visible = true;
            mostrarMenu = true;
        }
        #endregion

        #region Botões Rodapé
        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ev_Conexao_Click(object sender, EventArgs e)
        {
            //if (perfiluser == "A")
            //{
            //    ConexaoSQL conSql = new ConexaoSQL();
            //    conSql.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Acesso Negado!!!\nSeu Perfil não permite acesso a esse cadastro!!!",
            //        Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void Ev_Usuarios_Click(object sender, EventArgs e)
        {
            //Funcoes.atualizaCon();
            if (PerfUser == "A")
            {
                ConsUsuarios telaUser = new ConsUsuarios();
                telaUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso Negado!!!\nSeu Perfil não permite acesso a esse cadastro!!!",
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Botões Dados Gerais
        private void bt_cadEmp_Click(object sender, EventArgs e)
        {
            Pnl_DadosGerais.Visible = false;
            if (PerfUser == "A")
            {
                CadEmpresa cadEmp = new CadEmpresa(CodEmp);
                cadEmp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso Negado!!!\nSeu Perfil não permite acesso a esse cadastro!!!",
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void bt_CadFor_Click(object sender, EventArgs e)
        {
            Pnl_DadosGerais.Visible = false;
            ConsFornecedor consFor = new ConsFornecedor();
            consFor.ShowDialog();
        }

        private void bt_cadVen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Teste.");
        }
        #endregion

        #region Botões Estoque
        private void bt_cadLocal_Click(object sender, EventArgs e)
        {
            Pnl_Estoque.Visible = false;
            if (PerfUser == "A")
            {
                ConsEstoque ConsEst = new ConsEstoque(1);
                ConsEst.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso Negado!!!\nSeu Perfil não permite acesso a esse cadastro!!!",
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_cadPro_Click(object sender, EventArgs e)
        {
            Pnl_Estoque.Visible = false;
            ConsProduto ConsPro = new ConsProduto();
            ConsPro.ShowDialog();
        }
        #endregion

        
    }
}
