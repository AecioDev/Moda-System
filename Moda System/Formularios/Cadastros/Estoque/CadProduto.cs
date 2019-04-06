using Moda_System.Classes;
using Moda_System.Formularios.Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadProduto : Form
    {
        ProdutoRepositorio cadPro;
        BarrasProRepositorio consBarras;
        PrecosProRepositorio cadPreco;
        List<ErrosDB> erros;

        private int CodPro = 0;
        private int CodUniSai = 0;
        private int CodUniEnt = 0;
        private string msgCab = Funcoes.msgCab;
        private string arqimgpro = "";
        private DateTime datacadastro;
        private decimal cusreppro = 0;
        private decimal cusmedpro = 0;

        //Códigos Consultados
        public int CodMarca = 0;
        public int CodGrupo = 0;
        public int CodSubGrupo = 0;
        public int CodUni = 0;
        public string DescUni = "";
        public string SiglaUni = "";

        public CadProduto(int _codPro)
        {
            InitializeComponent();
            this.CodPro = _codPro;
        }
               
        private void CadProduto_Load(object sender, EventArgs e)
        {
            if (CodPro > 0) //Modificar o cadastro
            {
                Consulta();
                GetCodBarras();
                GetPrecos();
                GetSaldoPro();
                AjustaCampos();

                if (ck_TabPreco.Checked)    //(ck_TabPreco.Checked && perfUser == "A")
                {
                    tb_precoVenda.Enabled = false;
                    bt_AddPreco.Enabled = true;
                    bt_editPreco.Enabled = true;
                    bt_RemvPreco.Enabled = true;
                }
                else
                {
                    tb_precoVenda.Enabled = true;
                    bt_AddPreco.Enabled = false;
                    bt_editPreco.Enabled = false;
                    bt_RemvPreco.Enabled = false;
                }

                //if (perfUser != "A")
                //    ck_TabPreco.Enabled = false;
            }
            else
            {
                //Cadastro
                cb_status.SelectedIndex = 0;
                datacadastro = DateTime.Now;
                dt_DataCusto.Value = DateTime.Now;
                tb_precoVenda.Enabled = true;
                bt_AddPreco.Enabled = false;
                bt_editPreco.Enabled = false;
                bt_RemvPreco.Enabled = false;
            }
        }

        #region ************** Tratando Valores da Aba Dados ****************
        private void Consulta()
        {
            try
            {
                cadPro = new ProdutoRepositorio();
                var pro = cadPro.GetById(CodPro);

                if (pro.ProdutoId > 0)
                {
                    //Aba Dados
                    tb_codRef.Text = pro.CodRefPro;
                    
                    if (pro.StaProd == "A")
                        cb_status.SelectedIndex = 0;

                    if (pro.StaProd == "I")
                        cb_status.SelectedIndex = 1;

                    tb_descricao.Text = pro.DescProd;

                    CodMarca = pro.CodMarca;
                    tb_Marca.Text = pro.Marca.DescMarca;

                    CodGrupo = pro.CodGrupo;
                    tb_Grupo.Text = pro.Grupo.DescGrupo;

                    CodSubGrupo = pro.CodSubGrupo;
                    tb_sGrupo.Text = pro.SubGrupo.DescSubGrupo;

                    tb_obsPro.Text = pro.ObsProd;
                    datacadastro = pro.DataCadPro;

                    //Aba Imagens
                    pb_imgPro.Image = pb_imgPro.InitialImage;
                    pb_imgPro.Image = cadPro.GetImagePro(CodPro);

                    //Aba Preços
                    cusreppro = pro.CustoRepPro;
                    tb_cusRep.Text = cusreppro.ToString();

                    cusmedpro = pro.CustoMedPro;
                    tb_cusMed.Text = cusmedpro.ToString();

                    tb_datCusto.Text = pro.DataCusPro.ToShortDateString();
                    if (tb_datCusto.Text.Contains("1753"))
                        tb_datCusto.Clear();
                    else
                        tb_datCusto.Text = tb_datCusto.Text.Substring(0, 10);
                                        
                    if (pro.UsaTabPre == "S")
                        ck_TabPreco.Checked = true;
                    else
                        ck_TabPreco.Checked = false;

                    tb_precoVenda.Text = pro.PrecoVenda.ToString();

                    //Aba Estoque
                    if (pro.ControlaQnt == "S")
                        ck_estoqueOk.Checked = true;
                    else
                        ck_estoqueOk.Checked = false;

                    CodUniSai = pro.CodUniSai;
                    tb_desUniS.Text = pro.UniSai.DescUnidade;
                    tb_SiglaS.Text = pro.UniSai.SiglaUnidade;

                    CodUniEnt = pro.CodUniEnt;
                    tb_desUniE.Text = pro.UniEnt.DescUnidade;
                    tb_SiglaE.Text = pro.UniEnt.SiglaUnidade;

                    tb_qntMin.Text = pro.QtdMinima.ToString();
                    arqimgpro = pro.NomeImgPro;

                    tb_qntEquiv.Text = pro.QntEquiv.ToString();
                }
                else
                {
                    MessageBox.Show("Produto Não Encontrado!!!", Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void AjustaCampos()
        {
            try
            {
                if (tb_precoVenda.Text != "")
                {
                    if (tb_precoVenda.Text[0] == 'R')
                        tb_precoVenda.Text = tb_precoVenda.Text.Substring(2);

                    tb_precoVenda.Text = Convert.ToDecimal(tb_precoVenda.Text).ToString("C");
                }

                if (tb_cusRep.Text != "")
                {
                    if (tb_cusRep.Text[0] == 'R')
                        tb_cusRep.Text = tb_cusRep.Text.Substring(2);
                                        
                    tb_cusRep.Text = Convert.ToDecimal(tb_cusRep.Text).ToString("C");
                }

                if (tb_cusMed.Text != "")
                {
                    if (tb_cusMed.Text[0] == 'R')
                        tb_cusMed.Text = tb_cusMed.Text.Substring(2);
                                        
                    tb_cusMed.Text = Convert.ToDecimal(tb_cusMed.Text).ToString("C");
                }

                AjustaEquiv();
                                
                //if (perfUser != "A")
                //{
                //    tb_cusRep.UseSystemPasswordChar = true;
                //    tb_cusRep.Enabled = false;
                //    tb_precoVenda.Enabled = false;
                //}
                //else
                //{
                //    tb_cusRep.UseSystemPasswordChar = false;
                //    tb_cusRep.Enabled = true;
                //    tb_precoVenda.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor informe um valor válido!!!\nMaiores Detalhes:" + ex.Message,
                    msgCab, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void bt_imgProd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Filter = "Images (*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF;|" + "All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                arqimgpro = openFile.FileName;
                pb_imgPro.Image = Image.FromFile(arqimgpro);
            }
        }

        private void bt_limparImg_Click(object sender, EventArgs e)
        {
            pb_imgPro.Image = null;
            arqimgpro = "";
        }

        private void bt_Marca_Click(object sender, EventArgs e)
        {
            ConsMarca cMarca = new ConsMarca(this);
            cMarca.ShowDialog();
        }

        private void bt_Grupo_Click(object sender, EventArgs e)
        {
            ConsGrupo grp = new ConsGrupo(this);
            grp.ShowDialog();
        }

        private void bt_sGrupo_Click(object sender, EventArgs e)
        {
            if (CodGrupo > 0)
            {
                ConsSGrupo ConsSG = new ConsSGrupo(CodGrupo, tb_Grupo.Text, this);
                ConsSG.ShowDialog();
            }
            else
                MessageBox.Show("Informe o Grupo!!!", Funcoes.msgCab,
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region ************** Tratando Valores Informados nos campos ****************
        private void tb_cusRep__KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void tb_cusMed__KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void tb_precoVenda__KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void Campo_Money(object sender, EventArgs e)
        {
            decimal cusmed = 0;
            decimal cusrep = 0;

            AjustaCampos();

            if (tb_cusRep.Text != "")
            {
                if (tb_cusRep.Text[0] == 'R')
                    tb_cusRep.Text = tb_cusRep.Text.Substring(2);

                cusrep = Convert.ToDecimal(tb_cusRep.Text);
            }

            if (tb_cusMed.Text != "")
            {
                if (tb_cusMed.Text[0] == 'R')
                    tb_cusMed.Text = tb_cusMed.Text.Substring(2);

                cusmed = Convert.ToDecimal(tb_cusMed.Text);
            }            

            if ((cusmedpro > 0 && cusmedpro != cusmed) || (cusreppro > 0 && cusreppro != cusrep))
            {
                dt_DataCusto.Value = DateTime.Now;
                tb_datCusto.Text = dt_DataCusto.Value.ToShortDateString();
            }
        }

        private void dt_DataCusto_ValueChanged(object sender, EventArgs e)
        {
            tb_datCusto.Text = dt_DataCusto.Value.ToShortDateString();
        }
        #endregion

        #region ************** Tratamento de Código de Barras ******************
        private void GetCodBarras()
        {
            consBarras = new BarrasProRepositorio();
            if (CodPro > 0)
            {
                var codBarras = consBarras.GetByPro(CodPro);
                cb_codbar.DataSource = codBarras;
            }
            consBarras.Dispose();
        }

        private void bt_cadCodBar_Click(object sender, EventArgs e)
        {
            if (CodPro > 0)
            {
                CadBarras(0);
                GetCodBarras();
            }
            else
            {
                MessageBox.Show("O Código de Barras só poderá ser cadastrado após gravar os dados do Produto!!!",
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void bt_remvCodBar_Click(object sender, EventArgs e)
        {
            if (CodPro > 0)
            {
                CadBarras(1);
                GetCodBarras();
            }
        }

        private void CadBarras(int mode)
        {
            consBarras = new BarrasProRepositorio();
            BarrasPro barPro = new BarrasPro();
            erros = new List<ErrosDB>();
            bool deuErro = false;
            string msgErro = "";
            string retorno = "";

            try
            {
                if (cb_codbar.Text == "")
                {
                    if (mode == 0) //Cadastro
                        msgErro = "É necessário informar um Código de Barras para ser Cadastrado!\n";
                    else
                        msgErro = "É necessário informar um Código de Barras para ser Removido!\n";

                    deuErro = true;
                }
                else
                {
                    //Verifica se o Cód de Barras já Existe...
                    barPro = consBarras.GetByCod(CodPro, cb_codbar.Text);
                                        
                    if (barPro.CodBarId > 0)
                    {
                        if (mode == 0) //Cadastro
                        {
                            msgErro = "O código de Barras - " + cb_codbar.Text + " - Já está cadastrado para este Produto!\n";
                            deuErro = true;
                        }
                    }
                    else
                    {
                        if (mode == 1) //Deletar
                        {
                            msgErro = "O código de Barras - " + cb_codbar.Text + " - NÃO está cadastrado para este Produto!\n";
                            deuErro = true;
                        }

                        barPro.CodBarId = 0;
                        barPro.Codbarras = cb_codbar.Text;
                        barPro.ForCodBar = 0;
                        barPro.ProCodBar = CodPro;                        
                    }
                }

                if (deuErro) //Se deu erro
                {
                    MessageBox.Show(msgErro, Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mode == 0) //Cadastrar
                    erros = consBarras.Add(barPro);
                else
                    erros = consBarras.Remove(barPro);

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
                MessageBox.Show("Não foi possível efetuar a gravação das alterações devido ao erro abaixo\n\n" + ex.Message,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (retorno == "OK")
            {
                if (mode == 0)
                    msgErro = "Código de Barras - " + cb_codbar.Text + " - Cadastrado com Sucesso!!!\n";
                else
                    msgErro = "Código de Barras - " + cb_codbar.Text + " - Removido com Sucesso!!!\n";

                MessageBox.Show(msgErro, Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Problemas ao Cadastrar/Remover!!!\n\nMais Detalhes Abaixo\n" + retorno,
                Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ********************* Tratamento dos Preços **************************/
        private void ck_TabPreco_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TabPreco.Checked)
            {
                tb_precoVenda.Enabled = false;
                bt_AddPreco.Enabled = true;
                bt_editPreco.Enabled = true;
                bt_RemvPreco.Enabled = true;
            }
            else
            {
                tb_precoVenda.Enabled = true;
                bt_AddPreco.Enabled = false;
                bt_editPreco.Enabled = false;
                bt_RemvPreco.Enabled = false;
            }
        }

        private void bt_AddPreco_Click(object sender, EventArgs e)
        {
            if (CodPro > 0)
            {
                Precos cadPreco = new Precos(CodPro, tb_descricao.Text, 0);                
                cadPreco.ShowDialog();
                GetPrecos();
            }
            else
            {
                MessageBox.Show("A Tabela de Preço só poderá ser cadastrada após gravar os dados do Produto!!!",
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_editPreco_Click(object sender, EventArgs e)
        {
            int ln = 0;
            int codTab = 0;

            if (CodPro > 0)
            {
                ln = grid_Precos.CurrentRow.Index;
                codTab = Convert.ToInt32(grid_Precos.Rows[ln].Cells[0].Value.ToString());

                Precos cadPreco = new Precos(CodPro, tb_descricao.Text, codTab);
                cadPreco.ShowDialog();

                GetPrecos();
            }
        }

        private void bt_RemvPreco_Click(object sender, EventArgs e)
        {
            PrecosPro prePro = new PrecosPro();
            erros = new List<ErrosDB>();
            string retorno = "";
            int ln = 0;
            int codTab = 0;

            if (CodPro > 0)
            {
                ln = grid_Precos.CurrentRow.Index;
                codTab = Convert.ToInt32(grid_Precos.Rows[ln].Cells[0].Value.ToString());

                if (MessageBox.Show("Deseja Realmente eliminar a tabela de Preço selecionada???",
                   Funcoes.msgCab, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        prePro.PrecoProId = codTab;
                        prePro.ProdutoId = CodPro;
                        prePro.ValProduto = 0;

                        erros = cadPreco.Remove(prePro);

                        if (erros.Count > 0)
                        {
                            foreach (ErrosDB er in erros)
                            {
                                retorno += "Erro em: " + er.PropertyName + " - " + er.ErrorMessage + "\n";
                            }
                        }
                        else
                            retorno = "OK";
                        
                        GetPrecos();
                    }
                    catch (Exception ex)
                    {
                        retorno = "Não foi possível gravar os dados, devido aos erros abaixo\n\n" + ex.Message;
                    }

                    if (retorno == "OK")
                    {
                        MessageBox.Show("Tabela de Preço Eliminada com Sucesso!!!",
                            Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Problemas ao Eliminar!!!\n\nMais Detalhes Abaixo\n" + retorno,
                            Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GetPrecos()
        {
            cadPreco = new PrecosProRepositorio();
            var Precos = cadPreco.GetByPro(CodPro, 0);

            precosProBindingSource.DataSource = Precos;
            grid_Precos.Refresh();
        }

        #endregion

        #region ********************* Tratamento do Estoque **************************/
        private void bt_Uni_Click(object sender, EventArgs e)
        {            
            ConsUnidade ConsUniS = new ConsUnidade(this);
            ConsUniS.ShowDialog();
            tb_desUniS.Text = DescUni;
            tb_SiglaS.Text = SiglaUni;
            CodUniSai = CodUni;
        }

        private void bt_uniEnt_Click(object sender, EventArgs e)
        {
            ConsUnidade ConsUniE = new ConsUnidade(this);
            ConsUniE.ShowDialog();
            tb_desUniE.Text = DescUni;
            tb_SiglaE.Text = SiglaUni;
            CodUniEnt = CodUni;
            AjustaEquiv();
        }
        
        private void AjustaEquiv()
        {
            lb_Convert.Text = "1 " + tb_SiglaE.Text + " Equivale a: ";
            lb_UniConv.Text = tb_SiglaS.Text + ".";
            if (CodUniEnt == CodUniSai)
            {
                tb_qntEquiv.Text = "1";
                tb_qntEquiv.Enabled = false;
            }
        }

        private void tb_SiglaS_TextChanged(object sender, EventArgs e)
        {
            tb_unMin.Text = tb_SiglaS.Text;
            lb_UniConv.Text = tb_SiglaS.Text + ".";
        }
        
        private void GetSaldoPro()
        {
            SaldoEstoqueRepositorio consSaldo = new SaldoEstoqueRepositorio();
            int row = 0;

            var saldos = consSaldo.GetByPro(CodPro);
                        
            if (saldos.Count > 0)
            {
                //gridModulos
                grid_Estoque.Rows.Clear();
                foreach (SaldoEstoque saldo in saldos)
                {
                    //Adiciona o PDV na Grid
                    grid_Estoque.Rows.Add();
                    grid_Estoque.Rows[row].Cells[0].Value = saldo.CodLocalEst;
                    grid_Estoque.Rows[row].Cells[1].Value = saldo.Estoque.DescEstoque;
                    grid_Estoque.Rows[row].Cells[2].Value = saldo.QntSaldo;
                    grid_Estoque.Rows[row].Cells[3].Value = tb_SiglaS.Text;

                    row++;
                }
            }
            else
            {
                grid_Estoque.Rows.Clear();
            }
        }

        #endregion

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadPro = new ProdutoRepositorio();
            Produto prod = new Produto();
            erros = new List<ErrosDB>();
            bool erro = false;
            string msgErro = "";
            string status = "";
            string estOk = "";
            string usaTP = "";
            string retorno = "";

            //Campos Automáticos
            if (ck_estoqueOk.Checked) //Controla Estoque
                estOk = "S";
            else
                estOk = "N";

            if (cb_status.Text == "") //Status do Produto
                status = "A";
            else
            {
                if (cb_status.SelectedIndex == 0)
                    status = "A";

                if (cb_status.SelectedIndex == 1)
                    status = "I";
            }

            if (ck_TabPreco.Checked) //Tipo de Preço
                usaTP = "S";
            else
                usaTP = "N";

            if (CodUniEnt <= 0) //Unidade de Entrada.
                CodUniEnt = CodUniSai;

            //Verifica campos Obrigatórios (Marca, Grupo, SubGrupo e Unidades)
            if (CodUniSai <= 0) //Unidade de Saída
            {
                msgErro += "Por Favor Informe a Unidade Padrão do Produto!\n";
                erro = true;
            }

            if (CodMarca <= 0) //Marca
            {
                msgErro += "Por Favor Informe uma Marca para o Produto!\n";
                erro = true;
            }

            if (CodGrupo <= 0) //Grupo
            {
                msgErro += "Por Favor Informe um Grupo para o Produto!\n";
                erro = true;
            }

            if (CodSubGrupo <= 0) //SubGrupo
            {
                msgErro += "Por Favor Informe um Sub Grupo para o Produto!\n";
                erro = true;
            }

            if (tb_descricao.Text == "")
            {
                msgErro += "Por Favor Informe a Descrição do Produto!\n";
                erro = true;
            }

            if (tb_precoVenda.Text == "" && ck_TabPreco.Checked == false)
            {
                msgErro += "Por Favor Informe o Preço de Venda do Produto!\n";
                erro = true;
            }
            
            if (erro) //Se deu erro
            {
                MessageBox.Show(msgErro, Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                prod.ProdutoId = CodPro;
                prod.CodRefPro = tb_codRef.Text;
                prod.StaProd = status;
                prod.DescProd = tb_descricao.Text;
                                
                prod.CodMarca = CodMarca;
                prod.CodGrupo = CodGrupo;
                prod.CodSubGrupo = CodSubGrupo;
                prod.CodUniSai = CodUniSai;
                prod.CodUniEnt = CodUniEnt;
                
                if (tb_precoVenda.Text != "")
                {
                    if (tb_precoVenda.Text[0] == 'R')
                        tb_precoVenda.Text = tb_precoVenda.Text.Substring(2);

                    prod.PrecoVenda = Convert.ToDecimal(tb_precoVenda.Text);
                }
                else
                    prod.PrecoVenda = 0;

                if (tb_qntMin.Text != "")
                    prod.QtdMinima = Convert.ToDecimal(tb_qntMin.Text);
                else
                    prod.QtdMinima = 5;

                prod.ObsProd = tb_obsPro.Text;
                prod.ControlaQnt = estOk;

                if (tb_qntMin.Text != "")
                    prod.QntEquiv = Convert.ToInt32(tb_qntEquiv.Text);
                else
                    prod.QntEquiv = 1;
                                
                if (tb_cusRep.Text != "")
                {
                    if (tb_cusRep.Text[0] == 'R')
                        tb_cusRep.Text = tb_cusRep.Text.Substring(2);

                    prod.CustoRepPro = Convert.ToDecimal(tb_cusRep.Text);
                }
                else
                    prod.CustoRepPro = 0;

                if (tb_cusMed.Text != "")
                {
                    if (tb_cusMed.Text[0] == 'R')
                        tb_cusMed.Text = tb_cusMed.Text.Substring(2);

                    prod.CustoMedPro = Convert.ToDecimal(tb_cusMed.Text);
                }
                else
                    prod.CustoMedPro = 0;
                                
                if (tb_datCusto.Text != "")
                    prod.DataCusPro = Convert.ToDateTime(tb_datCusto.Text);
                else
                    prod.DataCusPro = Convert.ToDateTime("1753-01-01");

                prod.UsaTabPre = usaTP;
                prod.DataCadPro = datacadastro;

                if (arqimgpro != "")
                {
                    FileInfo fileInfo = new FileInfo(arqimgpro);
                    prod.extimgpro = fileInfo.Extension;
                }

                if (pb_imgPro.Image != null)
                {
                    prod.ImagProd = Funcoes.SetImage(pb_imgPro.Image, prod.extimgpro);
                    prod.NomeImgPro = arqimgpro;
                }
                else
                {
                    prod.extimgpro = ".png";
                    prod.ImagProd = Funcoes.SetImage(pb_imgPro.InitialImage, prod.extimgpro);
                    prod.NomeImgPro = "Logo Gerstão Modular.png";
                    arqimgpro = prod.NomeImgPro;
                }
                
               retorno = cadPro.Add_and_Update(prod);

                if (retorno == "OK")
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso!!!", Funcoes.msgCab,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas ao Cadastrar!!!\n\nMais Detalhes Abaixo\n" + retorno,
                    Funcoes.msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cadPro.Dispose();
            }
            catch (Exception ex)
            {
                retorno = "Não foi possível efetuar a gravação das alterações devido ao erro abaixo\n\n" + ex.Message + "\n" + ex.InnerException;
            }

        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
