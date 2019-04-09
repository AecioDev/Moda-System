using Moda_System.Classes;
using Moda_System.Formularios.Consultas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadVeiculo : Form
    {
        private int CodVeic = 0;
        private string msgCab = Funcoes.msgCab;
        VeiculoRepositorio repDados;

        //Códigos Consultados
        public int CodMotorista = 0;
        public int CodEstoque = 0;

        public CadVeiculo(int _codVeic)
        {
            CodVeic = _codVeic;
            InitializeComponent();
        }

        private void CadVeiculo_Load(object sender, EventArgs e)
        {
            if (CodVeic > 0) //Modificar o cadastro
                Consulta();
        }

        private void Consulta()
        {
            repDados = new VeiculoRepositorio();

            try
            {
                var veic = repDados.GetById(CodVeic);

                if (veic.VeiculoId > 0)
                {
                    tb_LPlaca.Text = veic.PlacaVeiculo.Substring(0, 3);
                    tb_NPlaca.Text = veic.PlacaVeiculo.Substring(3);
                    tb_DescVeic.Text = veic.DescVeiculo;

                    CodMotorista = veic.CodMotorista;
                    tb_Motorista.Text = veic.Motorista.NomeVendedor;

                    CodEstoque = veic.CodLocal;
                    tb_Estoque.Text = veic.Estoque.DescEstoque;
                }
                else
                {
                    MessageBox.Show("O Veículo não foi Encontrado!!!", Funcoes.msgCab,
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

        private void bt_Motorista_Click(object sender, EventArgs e)
        {
            ConsVendedor cVen = new ConsVendedor(this);
            cVen.ShowDialog();
        }

        private void bt_Estoque_Click(object sender, EventArgs e)
        {
            ConsEstoque cEst = new ConsEstoque(this);
            cEst.ShowDialog();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            repDados = new VeiculoRepositorio();
            Veiculo mod = new Veiculo();
            List<ErrosDB> erros = new List<ErrosDB>();
            string retorno = "";
                        
            //Verifica campos Obrigatórios
            if (tb_LPlaca.Text == "" || tb_NPlaca.Text == "")
            {
                MessageBox.Show("É necessário informar a Placa Corretamente \"XXX-0000\" !!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_LPlaca.Focus();
                return;
            }

            if(tb_DescVeic.Text == "")
            {
                MessageBox.Show("É necessário informar a Descrição do Veículo!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_DescVeic.Focus();
                return;
            }

            if(CodMotorista == 0)
            {
                MessageBox.Show("É necessário informar o Motorista do Veículo!!!", Funcoes.msgCab,

                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_Motorista.Focus();
                return;
            }

            if (CodEstoque == 0)
            {
                MessageBox.Show("É necessário informar o Local de Estoque vinculado ao Veículo!!!", Funcoes.msgCab,

                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_Motorista.Focus();
                return;
            }

            try
            {
                //Cadastra o Fornecedor                
                mod.VeiculoId = CodVeic;
                mod.PlacaVeiculo = tb_LPlaca.Text + tb_NPlaca.Text;
                mod.DescVeiculo = tb_DescVeic.Text;
                mod.CodMotorista = CodMotorista;
                mod.CodLocal = CodEstoque;
                                
                if (CodVeic > 0)   //Modificar
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
