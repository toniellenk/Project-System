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
    public partial class FormNvCliente : Form
    {
        public FormNvCliente()
        {
            
            InitializeComponent();
            label3.Visible = false;
            label11.Visible = false;
            textBox2.Visible = false;
            MaskCNPJ.Visible = false;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = false;
            MaskCNPJ.Visible = false;
            MaskCPF.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            textBox4.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = true;
            MaskCPF.Visible = false;
            MaskCNPJ.Visible = true;
            label4.Visible = false;
            label5.Visible = true;
            textBox4.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                label11.Visible = true;
                textBox2.Visible = true;
                MaskCNPJ.Enabled = false;
                MaskCPF.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                label11.Visible = false;
                textBox2.Visible = false;
                MaskCNPJ.Enabled = true;
                MaskCPF.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormCadClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
