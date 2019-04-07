using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class TabelaPreco : Form
    {

        private int SeqTab = 0;

        private string msgCab = Funcoes.msgCab;
        TabPrecoRepositorio cadTab;

        public TabelaPreco(int _seqTab)
        {
            InitializeComponent();
            this.SeqTab = _seqTab;
        }

        private void TabelaPreco_Load(object sender, EventArgs e)
        {
            if (SeqTab > 0)
            {
                Consulta();
            }
            else
            {
                cb_tipPreco.SelectedIndex = 2;
            }
        }

        private void Consulta()
        {
            cadTab = new TabPrecoRepositorio();

            try
            {
                var tabela = cadTab.GetById(SeqTab);
                                
                if (tabela.SeqTabPre > 0)
                {                    
                    tb_descricao.Text = tabela.DescTabPre;

                    switch(tabela.CalcPreCmp)
                    {
                        case "U"://UP - Maior
                            cb_tipPreco.SelectedIndex = 0;
                            break;
                        case "D"://Down - Menor
                            cb_tipPreco.SelectedIndex = 1;
                            break;
                        case "N":// Não Calcular
                            cb_tipPreco.SelectedIndex = 2;
                            break;
                    }

                    tb_lucro.Text = tabela.PercLucro.ToString();
                    cadTab.Dispose();
                }
                else
                {
                    MessageBox.Show("Tabela de Preço Não Encontrada!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception erro)
            {
                cadTab.Dispose();
                throw erro;
            }
        }

        private void tb_lucro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            //Grava os Dados
            cadTab = new TabPrecoRepositorio();
            TabPreco tabPre = new TabPreco();
            List<ErrosDB> erros = new List<ErrosDB>();
            string msgErro = "";
            bool erro = false;
            string retorno = "";

            if (tb_descricao.Text == "")
            {
                msgErro = "Por Favor Informe a Descrição da Tabela de Preço!\n";
                erro = true;
            }
                        
            if (cb_tipPreco.SelectedIndex != 2)
            {
                if (tb_lucro.Text == "")
                {
                    msgErro = "Por Favor Informe o Percentual de Lucro para o Preço de Venda do Produto!\n";
                    erro = true;
                }
            }

            if (erro) //Se deu erro
            {
                MessageBox.Show(msgErro, Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                tabPre.SeqTabPre = SeqTab;
                tabPre.DescTabPre = tb_descricao.Text;

                switch (cb_tipPreco.SelectedIndex)
                {
                    case 0://UP - Maior
                        tabPre.CalcPreCmp = "U";
                        break;
                    case 1://Down - Menor
                        tabPre.CalcPreCmp = "D";
                        break;
                    case 2:// Não Calcular
                        tabPre.CalcPreCmp = "N";
                        break;
                }

                if (tb_lucro.Text != "")
                    tabPre.PercLucro = Convert.ToDecimal(tb_lucro.Text);
                else
                    tabPre.PercLucro = 0;
                
                if (SeqTab > 0)   //Modificar
                    erros = cadTab.Update(tabPre);
                else
                    erros = cadTab.Add(tabPre);

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
                MessageBox.Show("Tabela de Preço Cadastrada com Sucesso!!!",
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                msgErro = "Problemas ao Cadastrar!!!\n\nMais Detalhes Abaixo\n" + retorno;
                MessageBox.Show(msgErro, Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
