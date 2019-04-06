using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moda_System.Formularios.Inicio
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        UsuarioRepositorio consUser;

        public int versao = Funcoes.versao;
        public string msgCab = Funcoes.msgCab;

        private void Acesso_Load(object sender, EventArgs e)
        {
            string pastaBD = "";
            string retorno = "";
            //ModelUser user = new ModelUser();

            //Primeiro Verifica se existe o Banco de Dados / Arquivo de Conexão.
            if (!File.Exists(Funcoes.PathArquivo))
            {
                //Se não existir Será Criado o Banco de Dados e as Tabelas
                if (MessageBox.Show("Não foi encontrado o banco de Dados do Sistema! Deseja Executar a criação do Banco agora??? ", msgCab,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Deseja Alterar a Pasta Padrão do Banco de Dados??? ", msgCab,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        FolderBrowserDialog pasta = new FolderBrowserDialog();
                        pasta.Description = "Selecione a Pasta para criar o Banco de Dados";
                        //pasta.RootFolder = Environment.SpecialFolder.MyComputer;
                        pasta.ShowNewFolderButton = true;
                        if (pasta.ShowDialog() == DialogResult.OK)
                        {
                            pastaBD = pasta.SelectedPath;
                        }
                    }
                    else
                        pastaBD = Funcoes.folder;

                    retorno = Funcoes.ValidaBancoDados(pastaBD);

                    if (retorno == "OK")
                    {
                        MessageBox.Show("Estrutura de Banco de Dados criada com Sucesso!!!", Funcoes.msgCab,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Depois de Criar o banco de Dados e as Tabelas Chama tela para Cadastro Básico Inicial
                        CadIni cad = new CadIni();
                        cad.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Problemas ao Criar a Estrutura de Banco de Dados!!!\n\nMais Detalhes Abaixo\n" + retorno,
                        Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.Close();
                    }                    
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                //Chama para verificar se tem alterações no banco de dados para serem implementadas.
                retorno = Funcoes.ValidaBancoDados("");

                if (retorno == "OK")
                {
                    //Mansagem na tela de Splash
                    //MessageBox.Show("Estrutura de Banco de Dados Atualizada com Sucesso!!!", Funcoes.msgCab,
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problemas ao Atualizar a Estrutura de Banco de Dados!!!\n\nMais Detalhes Abaixo\n" + retorno,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }
            }

            //Se existir o Banco de Dados verifica o Cadastro de usuários
            consUser = new UsuarioRepositorio();

            var usuarios = consUser.GetAll();

            cb_Usuarios.SelectedIndexChanged -= cb_Usuarios_SelectedIndexChanged;
            var user = usuarios.Where(u => u.StaUser == "A" && u.LoginUser != "ADMIN").ToList();

            cb_Usuarios.DataSource = user;
            cb_Usuarios.SelectedIndex = -1;
            tb_senUser.Clear();
            cb_Usuarios.Focus();

            consUser.Dispose();
            cb_Usuarios.SelectedIndexChanged += cb_Usuarios_SelectedIndexChanged;            
        }

        private void cb_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Implementação Futura Imagem
            //int linhas = 0;
            //string codUser = "";
            //string userBD = "";            
            //Image imgUser = null;

            if (cb_Usuarios.SelectedIndex >= 0)
            {
                //MessageBox.Show("User: " + cb_Usuarios.Text + "Cod: " + cb_Usuarios.SelectedValue.ToString());
                //    codUser = cb_Usuarios.SelectedValue.ToString();
                //    linhas = dtUser.Rows.Count;
                //    if (linhas > 0)
                //    {
                //        for (int i = 0; i < linhas; i++)
                //        {
                //            userBD = dtUser.Rows[i]["codUser"].ToString();
                //            if (userBD == codUser)
                //            {
                //                if (dtUser.Rows[i]["imgUser"].ToString() != "")
                //                {
                //                    byte[] foto = (byte[])dtUser.Rows[i]["imgUser"];

                //                    MemoryStream ms = new MemoryStream(foto);
                //                    imgUser = Image.FromStream(ms);
                //                }
                //                else
                //                {
                //                    Stream arquivo = this.GetType().Assembly.GetManifestResourceStream(
                //                        "GestaoModularAcesso.Resources.User_group_icon2.png");
                //                    imgUser = new Bitmap(arquivo);
                //                }
                //                break;
                //            }
                //        }
                //        pb_User.Image = imgUser;
                //    }

                //    if (codUser != "")
                //        codUserSel = Convert.ToInt32(codUser);

                //    getModulos();
            }
            #endregion
            tb_senUser.Clear();
            tb_Rodape.ForeColor = SystemColors.Control;
            tb_Rodape.Text = "Bem Vindo!!!";
            tb_senUser.Focus();
            tb_senUser.SelectAll();
        }
                
        private void bt_Acessar_Click(object sender, EventArgs e)
        {
            int CodUser = 0;
            string LoginUser = "";
            string SenHash = "";
                        
            if (cb_Usuarios.Text != "" && tb_senUser.Text != "")
            {
                try
                {
                    if (cb_Usuarios.Text == "ADMIN" && tb_senUser.Text == "BD9854") //Abre a tela para Manutenção no Banco de Dados
                    {
                        //ConexaoSQL conSql = new ConexaoSQL();
                        //conSql.ShowDialog();
                        //tb_senUser.Text = "";
                        //return;
                    }
                                        
                    LoginUser = cb_Usuarios.Text;
                    SenHash = Funcoes.GetMd5Hash(tb_senUser.Text); //Cria o hash da senha informada

                    //1 - Verifica se o usuário informado no Combo existe no BD e busca os dados dele.
                    consUser = new UsuarioRepositorio();
                    var user = consUser.BuscarPorLogin(cb_Usuarios.Text);
                    CodUser = user.UsuarioId;

                    if (CodUser > 0) //Achou o bendito
                    {
                        //2 - Verifica a Senha do bixo
                        if (Funcoes.VerifyMd5Hash(user.SenUser, SenHash)) //Retorna true ou false 
                        {
                            consUser.Dispose();
                            this.Hide();                            

                            //Abre o Menu Principal
                            Home home = new Home(CodUser);
                            home.ShowDialog();

                            //3 - Depois q fechar o Menu carrega o combobox denovo
                            cb_Usuarios.SelectedIndexChanged -= cb_Usuarios_SelectedIndexChanged;
                            consUser = new UsuarioRepositorio();
                            var usuarios = consUser.GetAll();

                            cb_Usuarios.SelectedIndexChanged -= cb_Usuarios_SelectedIndexChanged;
                            var User = usuarios.Where(u => u.StaUser == "A" && u.LoginUser != "ADMIN").ToList();

                            cb_Usuarios.DataSource = User;
                            cb_Usuarios.SelectedIndex = -1;
                            tb_senUser.Clear();
                            tb_Rodape.ForeColor = SystemColors.Control;
                            tb_Rodape.Text = "Bem Vindo!!!";

                            //pb_User.Image = pb_User.InitialImage;

                            cb_Usuarios.SelectedIndexChanged += cb_Usuarios_SelectedIndexChanged;
                            this.Show();
                        }
                        else
                        {
                            tb_Rodape.ForeColor = Color.OrangeRed;
                            tb_Rodape.Text = "Senha Incorreta!!!";
                            tb_senUser.SelectAll();
                            tb_senUser.Focus();
                        }
                    }
                    else
                    {
                        tb_Rodape.ForeColor = Color.OrangeRed;
                        tb_Rodape.Text = "Usuário NÃO Encontrado!!!";
                        tb_senUser.SelectAll();
                        tb_senUser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas ao consultar o banco de dados!!!\n" + "\nDetalhes abaixo:" + ex.Message, msgCab, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Application.Exit();                    
                }
            }
            else
            {
                if (cb_Usuarios.Text == "" && tb_senUser.Text == "")
                {
                    tb_Rodape.ForeColor = Color.OrangeRed; //LightSalmon
                    tb_Rodape.Text = "Informe Usuário e Senha!!!";
                }
                else
                {
                    if (tb_senUser.Text == "")
                    {
                        tb_Rodape.ForeColor = Color.OrangeRed;
                        tb_Rodape.Text = "Informe uma Senha!!!";
                    }

                    if (cb_Usuarios.Text == "")
                    {
                        tb_Rodape.ForeColor = Color.OrangeRed;
                        tb_Rodape.Text = "Selecione um Usuário!!!";
                    }
                }
            }

        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
