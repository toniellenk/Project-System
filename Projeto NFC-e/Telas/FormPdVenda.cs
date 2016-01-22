using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public partial class FormPdVenda : Form
    {
        public FormPdVenda(int Op, string ItemSelect)
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesqSimplClientePdVenda TelaPesquisa = new PesqSimplClientePdVenda(this, "Cliente");
           TelaPesquisa.ShowDialog();
        }

        private void TxtDeposito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
