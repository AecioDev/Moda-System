using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadFornecedor : Form
    {
        private int codForn = 0;
        private string msgCab = Funcoes.msgCab;
        FornecedorRepositorio cadFor;

        public CadFornecedor(int _codForn)
        {
            InitializeComponent();
            this.codForn = _codForn;
        }

        private void CadFornecedor_Load(object sender, EventArgs e)
        {
            if (codForn == 0)   //Cadastro
            {
                cb_Status.SelectedIndex = 0;
            }
            else
                Consulta();
        }

        private void Consulta()
        {
            cadFor = new FornecedorRepositorio();
            
            try
            {
                var forn = cadFor.GetById(codForn);
                                
                if (forn.FornecedorId > 0)
                {                    
                    if (forn.StatusFor == "A")
                        cb_Status.SelectedIndex = 0; //Ativo
                    else
                        cb_Status.SelectedIndex = 1; //Inativo

                    tb_Nome.Text = forn.NomeForn;
                    tb_Email.Text = forn.EmailForn;
                    tb_CPF.Text = forn.CpfForn;
                    tb_CNPJ.Text = forn.CnpjForn;
                    tb_Tel1.Text = forn.Tel1Forn;
                    tb_Tel2.Text = forn.Tel2Forn;
                    tb_Contato.Text = forn.ContatoForn;
                }
                else
                {
                    MessageBox.Show("Fornecedor não Encontrado!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                cadFor.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cadFor.Dispose();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadFor = new FornecedorRepositorio();
            Fornecedor mod = new Fornecedor();
            List<ErrosDB> erros = new List<ErrosDB>();
            string retorno = "";
            string status = "";
            int mode = 0;

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
                mod.FornecedorId = codForn;
                mod.StatusFor = status;
                mod.CpfForn = tb_CPF.Text;
                mod.CnpjForn = tb_CNPJ.Text;
                mod.NomeForn = tb_Nome.Text;
                mod.EmailForn = tb_Email.Text;
                mod.Tel1Forn = tb_Tel1.Text;
                mod.Tel2Forn = tb_Tel2.Text;
                mod.ContatoForn = tb_Contato.Text;

                if (codForn > 0)   //Modificar
                    erros = cadFor.Update(mod);
                else
                    erros = cadFor.Add(mod);

                if (erros.Count > 0)
                {
                    foreach(ErrosDB erro in erros)
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
    }
}
