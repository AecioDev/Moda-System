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
        private decimal valantpro = 0;

        PrecosProRepositorio cadPre;
        TabPrecoRepositorio cadTab;

        public Precos(int _codPro, string _desPro, int _codPre)
        {
            InitializeComponent();
            this.CodPro = _codPro;
            this.Produto = _desPro;
            this.CodPre = _codPre;
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

                        tb_valPro.Text = Convert.ToDecimal(tb_valPro.Text).ToString("C");
                    }

                    if (tb_descProg.Text != "")
                    {
                        if (tb_descProg.Text[0] == 'R')
                            tb_descProg.Text = tb_descProg.Text.Substring(2);

                        tb_descProg.Text = Convert.ToDecimal(tb_descProg.Text).ToString("C");
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

                tb_valPro.Text = Convert.ToDecimal(tb_valPro.Text).ToString("C");
            }

            if (tb_descProg.Text != "")
            {
                if (tb_descProg.Text[0] == 'R')
                    tb_descProg.Text = tb_descProg.Text.Substring(2);

                tb_descProg.Text = Convert.ToDecimal(tb_descProg.Text).ToString("C");
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
            TabelaPreco tab = new TabelaPreco(mode);
            tab.ShowDialog();
        }
        
        #endregion

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
