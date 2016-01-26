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
            ImgBloq.Visible = false;
            ImgAlert.Visible = false;
            ImgAlert.Visible = false;
        }

        public FormPdVenda()
        {
            InitializeComponent();
            ImgBloq.Visible = false;
            ImgAlert.Visible = false;
            ImgAlert.Visible = false;
        }


        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                PesqSimplClientePdVenda TelaPesquisa = new PesqSimplClientePdVenda(this);
                if (RadButIDCliente.Checked) TelaPesquisa.TipoProcura = 1;
                if (RadButNomeCliente.Checked) TelaPesquisa.TipoProcura = 2; 
                TelaPesquisa.ShowDialog();
                }
            catch (Exception ex)
            {               
                MessageBox.Show("Ao filtrar dados dados: " + ex.Message.ToString(), "Erro ao Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
          
        }

        private void TxtDeposito_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImgOk_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                PesquisaProdutoPdVenda TelaPesquisa = new PesquisaProdutoPdVenda(this);
                if (RadButIdProd.Checked) TelaPesquisa.TipoProcura = 1;
                if (RadButNomeProd.Checked) TelaPesquisa.TipoProcura = 2;
                TelaPesquisa.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ao filtrar dados dados: " + ex.Message.ToString(), "Erro ao Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
