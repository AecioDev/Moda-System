using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsVeiculo : Form
    {
        public ConsVeiculo()
        {
            InitializeComponent();
        }

        private void ConsVeiculo_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            int codMoto = 0;
            string placa = "";
            VeiculoRepositorio consVei = new VeiculoRepositorio();

            placa = tb_LPlaca.Text + tb_NPlaca.Text;
            codMoto = Convert.ToInt32(cb_Motoristas.SelectedValue);

            var Veiculos = consVei.ConsVeiculo(placa, codMoto, tb_descVeic.Text);
            if (Veiculos.Count > 0)
            {
                grd_Dados.Rows.Clear();
                foreach (Veiculo veic in Veiculos)
                {                    
                    grd_Dados.Rows.Add();
                    grd_Dados.Rows[row].Cells[0].Value = veic.VeiculoId;
                    grd_Dados.Rows[row].Cells[1].Value = veic.PlacaVeiculo;
                    grd_Dados.Rows[row].Cells[2].Value = veic.DescVeiculo;
                    grd_Dados.Rows[row].Cells[3].Value = veic.Motorista.NomeVendedor;
                    grd_Dados.Rows[row].Cells[4].Value = veic.Estoque.DescEstoque;

                    row++;
                }
            }
            else
            {
                grd_Dados.Rows.Clear();
            }

            consVei.Dispose();
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
        #endregion

        private void bt_Confirmar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadVeiculo cadVei = new CadVeiculo(0);
            cadVei.ShowDialog();
            Consulta();
            this.Show();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                this.Hide();
                CadVeiculo cadVei = new CadVeiculo(codigo);
                cadVei.ShowDialog();
                Consulta();
                this.Show();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
