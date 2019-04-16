using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moda_System.Formularios.Cadastros
{
    public partial class CadEntradas : Form
    {
        private int CodNota = 0;

        public CadEntradas(int _codnf)
        {
            CodNota = _codnf;
            InitializeComponent();
        }

        private void CadEntradas_Load(object sender, EventArgs e)
        {
            if(CodNota > 0) //Vamos Editar a Nota feita anteriormente.
            {

            }
            else
            {               //Digitação de uma Nova Nota.

            }
        }



        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
