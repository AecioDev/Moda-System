using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class Precos : Form
    {
        private string msgCab = Funcoes.msgCab;
        private int CodPre = 0; 
        private int CodPro = 0;
        private string Produto = "";
        private string CustoRep = "";

        private decimal custopro = 0;
        private decimal valantpro = 0;
        private decimal valorpro = 0;
        private decimal descmax = 0;
        private decimal margem = 0;

        PrecosProRepositorio cadPre;
        TabPrecoRepositorio cadTab;

        public Precos(int _codPro, string _desPro, string _cusrep, int _codPre)
        {
            this.CodPro = _codPro;
            this.Produto = _desPro;
            this.CodPre = _codPre;
            this.CustoRep = _cusrep;
            
            InitializeComponent();
        }

        private void Precos_Load(object sender, EventArgs e)
        {
            if (CodPre > 0)  //Modificar ou Deletar
                Consulta();
            else
            {
                GetTabPrecos();
                cb_tabPre.SelectedIndex = -1;
            }

            tb_despro.Text = Produto;

            if (!string.IsNullOrEmpty(CustoRep))
            {
                if (CustoRep[0] == 'R')
                    CustoRep = CustoRep.Substring(2);

                custopro = Convert.ToDecimal(CustoRep);
                tb_cuspro.Text = custopro.ToString("C");
            }
        }

        private void Consulta()
        {
            cadPre = new PrecosProRepositorio();
            string valant = "";

            try
            {
                var preco = cadPre.GetByPro(CodPro, CodPre).FirstOrDefault();

                if (preco.PrecoProId > 0)
                {
                    GetTabPrecos();
                    if (preco.TabPreId > 0)
                        cb_tabPre.SelectedValue = preco.TabPreId;
                    else
                        cb_tabPre.SelectedIndex = -1;
                    
                    tb_valPro.Text = preco.ValProduto.ToString();
                    tb_descProg.Text = preco.DescProg.ToString();

                    valant = preco.ValAntPro.ToString();
                    valantpro = preco.ValAntPro;

                    if (tb_valPro.Text != "")
                    {
                        if (tb_valPro.Text[0] == 'R')
                            tb_valPro.Text = tb_valPro.Text.Substring(2);

                        valorpro = Convert.ToDecimal(tb_valPro.Text);
                        tb_valPro.Text = valorpro.ToString("C");
                    }

                    if (tb_descProg.Text != "") //Desconto máximo
                    {
                        if (tb_descProg.Text[0] == 'R')
                            tb_descProg.Text = tb_descProg.Text.Substring(2);

                        descmax = Convert.ToDecimal(tb_descProg.Text);
                        tb_descProg.Text = descmax.ToString("C");
                    }
                                        
                }
                else
                {
                    MessageBox.Show("Tabela de Preço Não Encontrado!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                cadPre.Dispose();

                bt_Gravar.Focus();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            //Grava os Dados
            cadPre = new PrecosProRepositorio();
            PrecosPro prePro = new PrecosPro();
            List<ErrosDB> erros = new List<ErrosDB>();

            string msgErro = "";
            bool erro = false;
            string retorno = "";

            if (cb_tabPre.SelectedIndex < 0)
            {
                msgErro = "Por Favor Selecione uma Tabela de Preço!\n";
                erro = true;
            }

            if (tb_valPro.Text == "")
            {
                msgErro = "Por Favor Informe o Preço de Venda para o Produto!\n";
                erro = true;
            }

            if (ExisteTab() > 0 && CodPre == 0)
            {
                msgErro = "A tabela de Preço Selecionada já está vinculada no Produto, selecione ou cadastre outra tabela!!!\n";
                erro = true;
            }

            try
            {
                if (cb_tabPre.SelectedIndex >= 0)
                    prePro.TabPreId = Convert.ToInt32(cb_tabPre.SelectedValue);

                prePro.ProdutoId = CodPro;
                prePro.ValAntPro = valantpro;

                if (tb_valPro.Text != "")
                {
                    if (tb_valPro.Text[0] == 'R')
                        tb_valPro.Text = tb_valPro.Text.Substring(2);

                    prePro.ValProduto = Convert.ToDecimal(tb_valPro.Text);
                }

                if (tb_descProg.Text != "")
                {
                    if (tb_descProg.Text[0] == 'R')
                        tb_descProg.Text = tb_descProg.Text.Substring(2);

                    prePro.DescProg = Convert.ToDecimal(tb_descProg.Text);
                }

                if (prePro.DescProg >= prePro.ValProduto)
                {
                    msgErro = "O Desconto Programado deve ser MENOR que o valor do produto!!!\n";
                    erro = true;
                }

                if (erro) //Se deu erro
                {
                    MessageBox.Show(msgErro, Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (CodPre > 0)   //Modificar
                    erros = cadPre.Update(prePro);
                else
                    erros = cadPre.Add(prePro);

                if (erros.Count > 0)
                {
                    foreach (ErrosDB er in erros)
                    {
                        retorno += "Erro em: " + er.PropertyName + " - " + er.ErrorMessage + "\n";
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

        private void tb_valPro_Leave(object sender, EventArgs e)
        {
            if (tb_valPro.Text != "")
            {
                if (tb_valPro.Text[0] == 'R')
                    tb_valPro.Text = tb_valPro.Text.Substring(2);

                valorpro = Convert.ToDecimal(tb_valPro.Text);
                tb_valPro.Text = valorpro.ToString("C");
            }

            if (tb_descProg.Text != "")
            {
                if (tb_descProg.Text[0] == 'R')
                    tb_descProg.Text = tb_descProg.Text.Substring(2);

                descmax = Convert.ToDecimal(tb_descProg.Text);
                tb_descProg.Text = descmax.ToString("C");
            }
        }

        private void tb_valPro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_descProg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_margem_Leave(object sender, EventArgs e)
        {
            if (tb_margem.Text != "")
            {
                if (tb_margem.Text[0] == 'R')
                    tb_margem.Text = tb_margem.Text.Substring(2);

                margem = Convert.ToDecimal(tb_margem.Text);
                tb_margem.Text = margem.ToString("C");

                CalculaValor(0);
            }
        }

        private void CalculaValor(int tipo)
        {
            //Valor = custo * (margem / 100)

            if (tipo == 0) //Alterou a Margem calcula o valor
            {
                //Custo dividido por (cem - margem) * cem
                if(margem < 100)
                    valorpro = custopro / (100 - margem) * 100;

                tb_valPro.Leave -= tb_valPro_Leave;
                tb_valPro.Text = valorpro.ToString("C");
                tb_valPro.Leave += tb_valPro_Leave;
            }

            if(tipo == 1)
            {
                
            }

        }

        #region ************** Tratamento da Tabela de Preços ******************
        private int ExisteTab() //Verifica se a tabela já foi cadastrada para o produto.
        {
            cadPre = new PrecosProRepositorio();
            int Codtabpre = 0;
            int codpreco = 0;

            try
            {
                if (cb_tabPre.SelectedIndex >= 0)
                    Codtabpre = Convert.ToInt32(cb_tabPre.SelectedValue);
                else
                {
                    cadPre.Dispose();
                    return 0;
                }

                var precotab = cadPre.GetByPro(CodPro, Codtabpre).FirstOrDefault(); ;
                codpreco = precotab.PrecoProId;
                cadPre.Dispose();

                if (codpreco > 0)
                    return codpreco;
                else
                    return 0; 
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void GetTabPrecos()
        {
            cadTab = new TabPrecoRepositorio();
            if (CodPro > 0)
            {
                var tabpre = cadTab.GetAll();
                cb_tabPre.DataSource = tabpre;           
            }
            cadTab.Dispose();
        }

        private void bt_cadTabPre_Click(object sender, EventArgs e)
        {
            TabPrecos(0);
            GetTabPrecos();
        }

        private void bt_AltTabPre_Click(object sender, EventArgs e)
        {
            if(cb_tabPre.SelectedIndex >= 0)
            {
                int tab = Convert.ToInt32(cb_tabPre.SelectedValue);
                TabPrecos(tab);
                GetTabPrecos();
                cb_tabPre.SelectedValue = tab;
            }
        }

        private void TabPrecos(int mode)
        {
            this.Hide();
            TabelaPreco tab = new TabelaPreco(mode);
            tab.ShowDialog();
            this.Show();
        }
        
        #endregion

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
