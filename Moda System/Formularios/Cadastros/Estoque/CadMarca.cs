using Moda_System.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadMarca : Form
    {
        private int CodMar = 0;
        private string msgCab = Funcoes.msgCab;
        MarcaRepositorio cadMar;

        public CadMarca(int _codmar)
        {
            CodMar = _codmar;
            InitializeComponent();
        }

        private void CadMarca_Load(object sender, EventArgs e)
        {
            if (CodMar > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadMar = new MarcaRepositorio();

            try
            {
                var marca = cadMar.GetById(CodMar);

                if (marca.MarcaId > 0)
                {
                    tb_Nome.Text = marca.DescMarca;
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

            cadMar.Dispose();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadMar = new MarcaRepositorio();
            List<ErrosDB> erros = new List<ErrosDB>();
            Marca mar = new Marca();
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
                mar.MarcaId = CodMar;
                mar.DescMarca = tb_Nome.Text;

                if (CodMar > 0)   //Modificar
                    erros = cadMar.Update(mar);
                else
                    erros = cadMar.Add(mar);

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
