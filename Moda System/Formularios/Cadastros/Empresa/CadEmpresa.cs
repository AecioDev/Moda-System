using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadEmpresa : Form
    {

        EmpresaRepositorio cadEmp;
        List<ErrosDB> erros;
        private int codEmp = 0;
        private string arqimglogo = "";
        private string msgCab = Funcoes.msgCab;

        //Dados de Backup
        private DateTime datacad = DateTime.Now;
        private string empPad = "";
        private string empTipo = "";
        private string empStatus = "";


        public CadEmpresa(int _codEmp)
        {
            InitializeComponent();
            this.codEmp = _codEmp;
        }

        private void CadEmpresa_Load(object sender, EventArgs e)
        {
            if (codEmp > 0) //Modificar
                Consulta();
        }

        private void Consulta()
        {
            try
            {
                cadEmp = new EmpresaRepositorio();

                var emp = cadEmp.GetById(codEmp);

                if (emp != null)
                {
                    tb_cnpjEmp.Text = emp.cnpjEmp;
                    datacad = emp.dataCadEmp;

                    empPad = emp.empPadrao;
                    empTipo = emp.tipoEmp;
                    empStatus = emp.statEmp;

                    tb_razaoEmp.Text = emp.razaoEmp;
                    tb_fantEmp.Text = emp.fantEmp;
                    tb_ieEmp.Text = emp.inscEstEmp;
                    tb_imEmp.Text = emp.inscMunEmp;
                    tb_CepEmp.Text = emp.CEPEmp;
                    tb_nomeRua.Text = emp.endEmp;
                    tb_numEnd.Text = emp.nroEndEmp.ToString();
                    tb_complEnd.Text = emp.compEndEmp;
                    tb_bairroEnd.Text = emp.bairroEmp;
                    tb_cidadeEnd.Text = emp.cidadeEmp;
                    cb_ufEnd.Text = emp.UFEmp;
                    tb_tel1Emp.Text = emp.tel1Emp;
                    tb_tel2Emp.Text = emp.tel2Emp;
                    pb_LogoEmp.Image = cadEmp.GetLogo(codEmp);
                    
                }
                else
                {
                    MessageBox.Show("Empresa Não Encontrada!!!", Funcoes.msgCab,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Problemas ao carregar os dados da Empresa!!!\n\n" + erro.InnerException + "\n" +erro.Message, Funcoes.msgCab,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cadEmp.Dispose();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            erros = new List<ErrosDB>();
            FileInfo fileInfo = null;
            string retorno = "";

            //Verifica campos Obrigatórios
            if (tb_cnpjEmp.Text == "" || tb_razaoEmp.Text == "" || tb_cidadeEnd.Text == "" || cb_ufEnd.Text == "" || (tb_tel1Emp.Text == "" && tb_tel2Emp.Text == ""))
            {
                MessageBox.Show("Os Campos em Vermelho são obrigatórios", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Muda Cor das Labels Obrigatórias
                lb_cnpj.ForeColor = Color.Red;
                lb_Razao.ForeColor = Color.Red;
                lb_Cidade.ForeColor = Color.Red;
                lb_UF.ForeColor = Color.Red;
                lb_Telefone.ForeColor = Color.Red;
                return;
            }

            try
            {
                //Cadastra a Empresa                
                cadEmp = new EmpresaRepositorio();
                emp.EmpresaId = codEmp;
                emp.cnpjEmp = tb_cnpjEmp.Text;
                emp.empPadrao = empPad;
                emp.dataCadEmp = DateTime.Now;
                emp.tipoEmp = empTipo;
                emp.codMatriz = 0;
                emp.statEmp = empStatus;
                emp.razaoEmp = tb_razaoEmp.Text;
                emp.fantEmp = tb_fantEmp.Text;
                emp.inscEstEmp = tb_ieEmp.Text;
                emp.inscMunEmp = tb_imEmp.Text;
                emp.CEPEmp = tb_CepEmp.Text;
                emp.endEmp = tb_nomeRua.Text;
                if (tb_numEnd.Text != "")
                    emp.nroEndEmp = Convert.ToInt32(tb_numEnd.Text);
                else
                    emp.nroEndEmp = 0;
                emp.compEndEmp = tb_complEnd.Text;
                emp.bairroEmp = tb_bairroEnd.Text;
                emp.cidadeEmp = tb_cidadeEnd.Text;
                emp.UFEmp = cb_ufEnd.Text;
                emp.tel1Emp = tb_tel1Emp.Text;
                emp.tel2Emp = tb_tel2Emp.Text;

                if (arqimglogo != "")
                {
                    fileInfo = new FileInfo(arqimglogo);
                    emp.extimglogo = fileInfo.Extension;
                }

                //Logotipo
                if (pb_LogoEmp.Image != null)
                {
                    //emp.logoEmp = pb_LogoEmp.Image;
                    emp.logoEmp = Funcoes.SetImage(pb_LogoEmp.Image, emp.extimglogo);
                    emp.nomImglogo = arqimglogo;
                }
                else
                {
                    //emp.logoEmp = pb_LogoEmp.InitialImage;
                    emp.extimglogo = ".png";
                    emp.logoEmp = Funcoes.SetImage(pb_LogoEmp.InitialImage, emp.extimglogo);
                    emp.nomImglogo = "Logo Gerstão Modular.png";
                    arqimglogo = emp.nomImglogo;
                }
                
                emp.tipoData = "";
                emp.versaoEmp = Funcoes.versao;

                retorno = cadEmp.Add_and_Update(emp);

                if (retorno == "OK")
                {
                    MessageBox.Show("Empresa Cadastrada com Sucesso!!!",
                        Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas ao Cadastrar!!!\n\nMais Detalhes Abaixo\n\n" + retorno,
                        Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cadEmp.Dispose();                                
            }
            catch (Exception ex)
            {
                retorno = "Não foi possível gravar os dados, devido aos erros abaixo\n\n" + ex.Message;
            }            
        }
                        
        #region Eventos Botões
        private void tb_numEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb_CepEmp_Leave(object sender, EventArgs e)
        {
            if (tb_CepEmp.Text != "")
            {
                ModelEndereco end = new ModelEndereco();
                end = Funcoes.BuscaEnd(tb_CepEmp.Text);

                if (end.Resultado > 0)
                {
                    tb_nomeRua.Text = end.Rua;
                    tb_complEnd.Text = end.Complemento;
                    tb_bairroEnd.Text = end.Bairro;
                    tb_cidadeEnd.Text = end.Cidade;
                    cb_ufEnd.Text = end.Estado;
                    tb_numEnd.Focus();
                }
                else
                {
                    MessageBox.Show("O Endereço para este CEP não foi encontrado!!!\nFavor informar manualmente...",
                        Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Imagem Logotipo
        
        private void bt_logotipo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Filter = "Images (*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF;|" + "All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                arqimglogo = openFile.FileName;
                pb_LogoEmp.Image = Image.FromFile(arqimglogo);
            }
        }

        private void bt_limpaLogo_Click(object sender, EventArgs e)
        {
            pb_LogoEmp.Image = null;
            arqimglogo = "";
        }


        #endregion

        
    }
}
