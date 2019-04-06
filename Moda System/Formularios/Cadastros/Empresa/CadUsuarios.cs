using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadUsuarios : Form
    {
        private int codUser = 0;
        private string senBack = "";
        private string msgCab = Funcoes.msgCab;
        UsuarioRepositorio userCad;

        public CadUsuarios(int _codUser)
        {
            InitializeComponent();
            this.codUser = _codUser;
        }

        private void CadUsuarios_Load(object sender, EventArgs e)
        {
            if (codUser == 0) //Cadastro novo
            {
                //Campos Padrões
                cb_Status.SelectedIndex = 0;
                cb_PerfilUser.SelectedIndex = 1;
                bt_trcSenha.Visible = false;
                bt_verificar.Visible = false;                
                //tb_SenhaUser.Enabled = true;
                //tb_ConfSenha.Visible = true;
                //lb_ConfSenha.Visible = true;
            }
            else
            {
                //Modificar o Cadastro
                consulta();

                bt_trcSenha.Visible = true;
                tb_SenhaUser.Enabled = false;
                tb_ConfSenha.Visible = false;
                lb_ConfSenha.Visible = false;
                bt_verificar.Visible = false;
                bt_verSenha.Visible = false;
                bt_verConfSenha.Visible = false;
            }
        }

        private void consulta()
        {
            userCad = new UsuarioRepositorio();

            try
            {
                var user = userCad.GetById(codUser);

                if (user != null)
                {
                    if (user.StaUser == "A")
                        cb_Status.SelectedIndex = 0; //Ativo
                    else
                        cb_Status.SelectedIndex = 1; //Inativo

                    tb_NomeUser.Text = user.NomeUser;
                    tb_EmailUser.Text = user.EmailUser;
                    tb_LoginUser.Text = user.LoginUser;
                    tb_SenhaUser.Text = user.SenUser;

                    switch (user.PerfilUser)
                    {
                        case "A": //Administrador
                            cb_PerfilUser.SelectedIndex = 0;
                            break;
                        case "U": //Usuário
                            cb_PerfilUser.SelectedIndex = 1;
                            break;
                        case "O": //Operador
                            cb_PerfilUser.SelectedIndex = 2;
                            break;
                        case "V": //Vendedor
                            cb_PerfilUser.SelectedIndex = 3;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário Não Encontrado!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                userCad.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            UsuarioRepositorio cadUser = new UsuarioRepositorio();
            Usuario user = new Usuario();
            List<ErrosDB> erros = new List<ErrosDB>();
            //FileInfo fileInfo = null;
            string retorno = "";
            string status = "";
            string perfil = "";

            //Verificar os automáticos Primeiro.
            if (cb_Status.Text == "" || cb_Status.SelectedIndex == 0)
                status = "A"; //Ativo
            else
                status = "I"; //Inativo

            switch (cb_PerfilUser.SelectedIndex)
            {
                case 0:
                    perfil = "A"; //Administrador
                    break;
                case 1:
                    perfil = "U"; //Usuário   
                    break;
                case 2:
                    perfil = "O"; //Operador
                    break;
                case 3:
                    perfil = "V"; //Vendedor
                    break;
            }

            //Verifica campos Obrigatórios
            if (tb_LoginUser.Text == "")
            {
                MessageBox.Show("É necessário informar o Login do Usuário!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_LoginUser.Focus();
                return;
            }

            if ((tb_SenhaUser.Text == "" || tb_ConfSenha.Text == "") && tb_SenhaUser.Enabled == true)
            {
                MessageBox.Show("É necessário informar a Senha e a Confirmação de Senha!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Verifica se a senha confere
            if (tb_SenhaUser.Text != tb_ConfSenha.Text && tb_SenhaUser.Enabled == true)
            {
                MessageBox.Show("Os Campos Senha e Confirmar Senha devem ser iguais!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_ConfSenha.Focus();
                tb_ConfSenha.SelectAll();
                return;
            }

            if (tb_LoginUser.Text == "ADMIN")
            {
                MessageBox.Show("Este Login é de uso interno! por favor escolha outro!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_LoginUser.Clear();
                tb_LoginUser.Focus();
                return;
            }
             
            try
            {
                //Cadastra o usuário                
                user.UsuarioId = codUser;
                user.StaUser = status;
                user.NomeUser = tb_NomeUser.Text;
                user.EmailUser = tb_EmailUser.Text;
                user.LoginUser = tb_LoginUser.Text;
                
                if (codUser == 0 || senBack != "") //Cadastro ou troca de senha
                    user.SenUser = Funcoes.GetMd5Hash(tb_SenhaUser.Text);
                else
                    user.SenUser = tb_SenhaUser.Text;

                user.PerfilUser = perfil;

                if (codUser > 0)   //Modificar
                    erros = cadUser.Update(user);
                else
                    erros = cadUser.Add(user);

                if (erros.Count > 0)
                {
                    foreach (ErrosDB erro in erros)
                    {
                        retorno += "Erro em: " + erro.PropertyName + " - " + erro.ErrorMessage + "\n";
                    }
                }
                else
                    retorno = "OK";

            }
            catch (Exception ex)
            {
                retorno = "Não foi possível gravar os dados, devido aos erros abaixo\n\n" + ex.Message;
            }

            if (retorno == "OK")
            {
                MessageBox.Show("Cadastro realizado com Sucesso!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Problemas ao realizar o cadastro!!!\n\nMais Detalhes Abaixo\n" + retorno,
                Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Animação Botões
        private void bt_trcSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a Senha Atual e Verifique!",
                Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);

            lb_ConfSenha.Text = "Senha Atual: ";
            lb_ConfSenha.Visible = true;
            tb_ConfSenha.Clear();
            tb_ConfSenha.Visible = true;
            bt_verConfSenha.Visible = true;
            bt_verificar.Visible = true;
            bt_trcSenha.Visible = false;
        }

        private void bt_verificar_Click(object sender, EventArgs e)
        {
            string SenHash = "";
            string senha = "";

            if (tb_ConfSenha.Text != "")
                senha = tb_ConfSenha.Text;
            
            SenHash = Funcoes.GetMd5Hash(senha); //Cria o hash da senha informada

            //1 - Verifica se o usuário informado no Combo existe no BD e busca os dados dele.
            userCad = new UsuarioRepositorio();
            var user = userCad.BuscarPorLogin(tb_LoginUser.Text);
            codUser = user.UsuarioId;

            if (Funcoes.VerifyMd5Hash(user.SenUser, SenHash))
            {
                //Pode Alterar
                senBack = tb_SenhaUser.Text;
                tb_SenhaUser.Text = "";
                tb_SenhaUser.Enabled = true;
                lb_ConfSenha.Text = "Confirma Senha";
                bt_verificar.Visible = false;
                tb_ConfSenha.Clear();
                tb_SenhaUser.Focus();
                bt_trcSenha.Visible = false;
                bt_verSenha.Visible = true;
                bt_verConfSenha.Visible = true;
            }
            else
            {
                MessageBox.Show("A senha Digitada NÃO confere com a senha Atual!",
                Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_trcSenha.Visible = true;
                tb_SenhaUser.Enabled = false;
                tb_ConfSenha.Visible = false;
                lb_ConfSenha.Visible = false;
                bt_verConfSenha.Visible = false;
                bt_verificar.Visible = false;
                bt_Gravar.Focus();
                bt_trcSenha.Visible = true;
            }
            userCad.Dispose();
        }

        private void bt_verSenha_MouseEnter(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;

            switch (btNome)
            {
                case "bt_verSenha":
                    tb_SenhaUser.UseSystemPasswordChar = false;
                    break;
                case "bt_verConfSenha":
                    tb_ConfSenha.UseSystemPasswordChar = false;
                    break;
            }            
        }

        private void bt_verSenha_MouseLeave(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;

            switch (btNome)
            {
                case "bt_verSenha":
                    tb_SenhaUser.UseSystemPasswordChar = true;
                    break;
                case "bt_verConfSenha":
                    tb_ConfSenha.UseSystemPasswordChar = true;
                    break;
            }
        }
        #endregion

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
