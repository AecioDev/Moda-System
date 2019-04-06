using Moda_System.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadIni : Form
    {
        UsuarioRepositorio cadUser;
        EmpresaRepositorio cadEmp;

        private DateTime datacad = DateTime.Now;
        private string msgCab = Funcoes.msgCab;
        
        public CadIni()
        {
            InitializeComponent();
        }


        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            ModelEndereco end = new ModelEndereco();
            Empresa emp = new Empresa();
            string retorno = "";

            //Verifica campos Obrigatórios
            if (tb_nomeEmp.Text == "" || tb_razaoEmp.Text == "" || tb_CepEmp.Text == "" || tb_FonEmp.Text == "")
            {
                MessageBox.Show("Favor Preencher Todos os dados da Empresa para o Cadastro!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tb_NomeUser.Text == "" || tb_LoginUser.Text == "" || tb_SenhaUser.Text == "")
            {
                MessageBox.Show("Favor Preencher Todos os dados do Usuário para o Cadastro!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(tb_LoginUser.Text == "ADMIN")
            {
                MessageBox.Show("Este nome é de uso interno! por favor escolha outro!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_LoginUser.Clear();
                tb_LoginUser.Focus();
                return;
            }
                        
            end = Funcoes.BuscaEnd(tb_CepEmp.Text);

            if (end.Resultado == 0)            
            {
                MessageBox.Show("O Endereço para o CEP não foi encontrado!!!\nFavor informar o CEP Corretamente!",
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                //Cadastra a Empresa
                #region Empresa
                cadEmp = new EmpresaRepositorio();                
                emp.cnpjEmp = "";
                emp.empPadrao = "S";
                emp.dataCadEmp = DateTime.Now;
                emp.tipoEmp = "M";
                emp.codMatriz = 0;
                emp.statEmp = "A";
                emp.razaoEmp = tb_razaoEmp.Text;
                emp.fantEmp = tb_nomeEmp.Text;
                emp.inscEstEmp = "";
                emp.inscMunEmp = "";
                emp.CEPEmp = tb_CepEmp.Text;
                emp.endEmp = end.Rua;
                emp.nroEndEmp = 0;
                emp.compEndEmp = "";
                emp.bairroEmp = end.Bairro;
                emp.cidadeEmp = end.Cidade;
                emp.UFEmp = end.Estado;
                emp.tel1Emp = tb_FonEmp.Text;
                emp.tel2Emp = "";
                emp.logoEmp = null;                
                emp.tipoData = "";
                emp.versaoEmp = Funcoes.versao;

                cadEmp.Add(emp);
                retorno = "OK";
                cadEmp.Dispose();

                #endregion

                if (retorno == "OK")
                {
                    //Cadastra o usuário
                    #region
                    cadUser = new UsuarioRepositorio();
                    user.StaUser = "A";
                    user.NomeUser = tb_NomeUser.Text;
                    user.EmailUser = "email@email.com";
                    user.LoginUser = tb_LoginUser.Text;
                    user.SenUser = Funcoes.GetMd5Hash(tb_SenhaUser.Text); //Grava a senha criptografada
                    user.PerfilUser = "A";

                    cadUser.Add(user);
                    retorno = "OK";                                        
                    #endregion                    
                }
            }
            catch (Exception ex)
            {
                retorno = "Não foi possível gravar os dados, devido aos erros abaixo\n\n" + ex.Message;
            }

            if (retorno == "OK")
            {
                MessageBox.Show("Cadastros Realizados com Sucesso!!!\n\n Bem Vindo ao Sistema de Gestão Moda Sytem!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Problemas ao realizar o cadastro!!!\n\nMais Detalhes Abaixo\n" + retorno,
                Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void bt_verSenha_MouseEnter(object sender, EventArgs e)
        {
            tb_SenhaUser.UseSystemPasswordChar = false;
        }

        private void bt_verSenha_MouseLeave(object sender, EventArgs e)
        {
            tb_SenhaUser.UseSystemPasswordChar = true;
        }
    }
}
