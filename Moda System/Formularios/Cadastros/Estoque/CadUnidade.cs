using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadUnidade : Form
    {
        UnidadeRepositorio cadUni;
        private int CodUni = 0;

        public CadUnidade(int _coduni)
        {
            InitializeComponent();
            this.CodUni = _coduni;
        }

        private void CadUnidade_Load(object sender, EventArgs e)
        {
            if (CodUni > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadUni = new UnidadeRepositorio();

            var uni = cadUni.GetById(CodUni);

            tb_Nome.Text = uni.DescUnidade;
            tb_sigUni.Text = uni.SiglaUnidade;

            cadUni.Dispose();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            cadUni = new UnidadeRepositorio();
            List<ErrosDB> erros = new List<ErrosDB>();
            Unidade uni = new Unidade();

            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("É necessário informar a descrição da Unidade!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            if (tb_sigUni.Text == "")
            {
                MessageBox.Show("É necessário informar a Sigla da Unidade!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            try
            {
                uni.UnidadeId = CodUni;
                uni.DescUnidade = tb_Nome.Text;
                uni.SiglaUnidade = tb_sigUni.Text;
                
                if (CodUni > 0)   //Modificar
                    erros = cadUni.Update(uni);
                else
                    erros = cadUni.Add(uni);

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
                MessageBox.Show("Não foi possível gravar os dados, devido aos erros abaixo\n\n" + ex.InnerException.Message + "\n" + ex.Message,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
