using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using Moda_System.Classes;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadGrupo : Form
    {
        private int CodGrupo = 0;
        private string msgCab = Funcoes.msgCab;
        GrupoRepositorio cadGrupo;

        public CadGrupo(int _codGrupo)
        {
            this.CodGrupo = _codGrupo;
            InitializeComponent();
        }

        private void CadGrupo_Load(object sender, EventArgs e)
        {
            if (CodGrupo > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadGrupo = new GrupoRepositorio();
            try
            {
                var grupos = cadGrupo.GetById(CodGrupo);

                if (grupos.GrupoId > 0)
                {
                    tb_Nome.Text = grupos.DescGrupo;
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
        }
                
        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadGrupo = new GrupoRepositorio();
            List<ErrosDB> erros = new List<ErrosDB>();
            Grupo grp = new Grupo();
            string retorno = "";

            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("É necessário informar a descrição do Grupo!!!", Funcoes.msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            try
            {
                grp.GrupoId = CodGrupo;
                grp.DescGrupo = tb_Nome.Text;
                grp.CorFonteGrd = 0;
                grp.CorFundoGrd = 0;
                grp.UsarGrade = "";

                if (CodGrupo > 0)   //Modificar
                    erros = cadGrupo.Update(grp);
                else
                    erros = cadGrupo.Add(grp);

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
