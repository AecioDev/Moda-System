using Moda_System.Classes;
using Moda_System.Formularios.Cadastros;
using System;
using System.Windows.Forms;

namespace Moda_System.Formularios.Consultas
{
    public partial class ConsVendedor : Form
    {
        private int Tela = 0;
        private CadVeiculo cadVeiculo;

        public ConsVendedor()
        {
            InitializeComponent();
        }

        public ConsVendedor(CadVeiculo cadVeiculo)
        {
            this.Tela = 1;
            this.cadVeiculo = cadVeiculo;
            InitializeComponent();
        }

        private void ConsVendedor_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            string status = "";
            VendedorRepositorio consVen = new VendedorRepositorio();

            switch (cb_Status.SelectedIndex)
            {
                case 1:
                    status = "A";
                    break;
                case 2:
                    status = "I";
                    break;
            }

            var Vendedores = consVen.ConsultaVen(status, tb_Doc.Text, tb_nome.Text);
            if (Vendedores.Count > 0)
            {
                grd_Dados.Rows.Clear();
                foreach (Vendedor vend in Vendedores)
                {
                    //Adiciona o PDV na Grid                   
                    grd_Dados.Rows.Add();
                    grd_Dados.Rows[row].Cells[0].Value = vend.VendedorId;
                    grd_Dados.Rows[row].Cells[1].Value = vend.NomeVendedor;

                    if (vend.CnpjVend.Length > 0)
                    {
                        grd_Dados.Rows[row].Cells[2].Value = vend.CnpjVend;
                    }

                    if (vend.CpfVend.Length > 0)
                    {
                        grd_Dados.Rows[row].Cells[2].Value = vend.CpfVend;
                    }

                    grd_Dados.Rows[row].Cells[3].Value = vend.Tel1Vend;
                    grd_Dados.Rows[row].Cells[4].Value = vend.Tel2Vend;

                    switch (vend.StatusVend)
                    {
                        case "A":
                            grd_Dados.Rows[row].Cells[5].Value = "Ativo";
                            break;
                        case "I":
                            grd_Dados.Rows[row].Cells[5].Value = "Inativo";
                            break;
                    }

                    row++;
                }
            }
            else
            {
                grd_Dados.Rows.Clear();
            }

            consVen.Dispose();
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_Doc_TextChanged(object sender, EventArgs e)
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
            int id_linha = 0;
            string cod = "";
            string desc = "";

            if (grd_Dados.Rows.Count > 0)
            {
                id_linha = grd_Dados.CurrentRow.Index; //Pega o índice da linha selecionada            

                cod = grd_Dados.Rows[id_linha].Cells[0].Value.ToString(); //Pega o valor da linha e coluna selecionda
                desc = grd_Dados.Rows[id_linha].Cells[1].Value.ToString();

                switch (Tela)
                {
                    case 1: //Veiculo
                        cadVeiculo.CodMotorista = Convert.ToInt32(cod);
                        cadVeiculo.tb_Motorista.Text = desc;
                        break;
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadVendedor cadVen = new CadVendedor(0);
            cadVen.ShowDialog();
            Consulta();         
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());
                                
                CadVendedor cadVen = new CadVendedor(codigo);
                cadVen.ShowDialog();
                Consulta();                
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
