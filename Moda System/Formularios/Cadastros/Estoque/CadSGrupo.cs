using System;
using System.Data;
using Moda_System.Classes;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadSGrupo : Form
    {
        SubGrupoRepositorio cadSgr;               
        private int CodGrupo = 0;
        private int CodSGrupo = 0;
        private string DesGrupo = "";
        private string msgCab = Funcoes.msgCab;
        
        public CadSGrupo(int _codGrupo, string _desGrupo, int _codSGrupo)
        {
            InitializeComponent();
            this.CodGrupo = _codGrupo;
            this.DesGrupo = _desGrupo;
            this.CodSGrupo = _codSGrupo;
        }

        private void CadSGrupo_Load(object sender, EventArgs e)
        {
            lb_Grupo.Text = DesGrupo;

            if (CodSGrupo > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadSgr = new SubGrupoRepositorio();
            
            try
            {
                var sgrupos = cadSgr.GetSubById(CodGrupo, CodSGrupo);
                                
                if (sgrupos.SubGrupoId > 0)
                {
                    tb_Nome.Text = sgrupos.DescSubGrupo;
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

            cadSgr.Dispose();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            SubGrupo mod = new SubGrupo();
            List<ErrosDB> erros = new List<ErrosDB>();
            cadSgr = new SubGrupoRepositorio();
            string retorno = "";

            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("É necessário informar a descrição do Sub Grupo!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            try
            {
                mod.GrupoId = CodGrupo;
                mod.SubGrupoId = CodSGrupo;
                mod.DescSubGrupo = tb_Nome.Text;

                if (CodSGrupo > 0)   //Modificar
                    erros = cadSgr.Update(mod);
                else
                    erros = cadSgr.Add(mod);

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
