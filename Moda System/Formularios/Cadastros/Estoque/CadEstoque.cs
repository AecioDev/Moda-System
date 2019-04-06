using System;
using Moda_System.Classes;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadEstoque : Form
    {
        private int CodLoc = 0;
        private string msgCab = Funcoes.msgCab;
        EstoqueRepositorio cadEst;

        public CadEstoque(int _codLoc)
        {
            InitializeComponent();
            this.CodLoc = _codLoc;
        }

        private void CadLocal_Load(object sender, EventArgs e)
        {
            if (CodLoc > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadEst = new EstoqueRepositorio();

            try
            {
                var estoques = cadEst.GetById(CodLoc);
                         
                if (estoques.EstoqueId > 0)
                {
                    tb_Nome.Text = estoques.DescEstoque;                   
                }
                else
                {
                    MessageBox.Show("Cadastro não Encontrado!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cadEst.Dispose();
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadEst = new EstoqueRepositorio();
            List<ErrosDB> erros = new List<ErrosDB>();
            Estoque est = new Estoque();
            string retorno = "";
                        
            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("É necessário informar a descrição do Estoque!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            try
            {
                est.EstoqueId = CodLoc;
                est.DescEstoque = tb_Nome.Text;
                
                if (CodLoc > 0)   //Modificar
                    erros = cadEst.Update(est);
                else
                    erros = cadEst.Add(est);

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

    }
}
