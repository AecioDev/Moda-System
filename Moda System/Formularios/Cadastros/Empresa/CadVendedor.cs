using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadVendedor : Form
    {
        private int CodVen = 0;
        private string msgCab = Funcoes.msgCab;
        VendedorRepositorio repDados;

        public CadVendedor(int _codven)
        {
            CodVen = _codven;
            InitializeComponent();
        }

        private void CadVendedor_Load(object sender, EventArgs e)
        {
            if (CodVen == 0)   //Cadastro
            {
                cb_Status.SelectedIndex = 0;
            }
            else
                Consulta();
        }

        private void Consulta()
        {
            repDados = new VendedorRepositorio();

            try
            {
                var vend = repDados.GetById(CodVen);

                if (vend.VendedorId > 0)
                {
                    if (vend.StatusVend == "A")
                        cb_Status.SelectedIndex = 0; //Ativo
                    else
                        cb_Status.SelectedIndex = 1; //Inativo

                    tb_Nome.Text = vend.NomeVendedor;
                    tb_Email.Text = vend.EmailVend;
                    tb_CPF.Text = vend.CpfVend;
                    tb_CNPJ.Text = vend.CnpjVend;
                    tb_Tel1.Text = vend.Tel1Vend;
                    tb_Tel2.Text = vend.Tel2Vend;
                    tb_perCom.Text = vend.PerComissao.ToString();
                }
                else
                {
                    MessageBox.Show("Vendedor não foi Encontrado!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                repDados.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                repDados.Dispose();
            }
        }

        #region ************** Tratando Valores Informados nos campos ****************
        private void tb_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb_perCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }
        #endregion

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            repDados = new VendedorRepositorio();
            Vendedor mod = new Vendedor();
            List<ErrosDB> erros = new List<ErrosDB>();
            string retorno = "";
            string status = "";
            
            //Verificar os automáticos Primeiro.
            if (cb_Status.Text == "" || cb_Status.SelectedIndex == 0)
                status = "A"; //Ativo
            else
                status = "I"; //Inativo

            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("É necessário informar o nome do Fornecedor!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            try
            {
                //Cadastra o Fornecedor                
                mod.VendedorId = CodVen;
                mod.StatusVend = status;
                mod.CpfVend = tb_CPF.Text;
                mod.CnpjVend = tb_CNPJ.Text;
                mod.NomeVendedor = tb_Nome.Text;
                mod.EmailVend = tb_Email.Text;
                mod.Tel1Vend = tb_Tel1.Text;
                mod.Tel2Vend = tb_Tel2.Text;

                if (tb_perCom.Text != "")
                    mod.PerComissao = Convert.ToDecimal(tb_perCom.Text);
                else
                    mod.PerComissao = 0;
                
                if (CodVen > 0)   //Modificar
                    erros = repDados.Update(mod);
                else
                    erros = repDados.Add(mod);

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

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
