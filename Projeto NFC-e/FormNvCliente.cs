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
             if BuNvCliente {
                 AdcAtua(1);
             }
             else BuAtCliente {
                 AdcAtua(2)
             }
        }
        
        region Métodos
        
        public void AdcAtua(int Op){
            
            DadosClientes objDados = new DadosClientes();
            objDados.ClientesObj.Nome = ;
123         objDados.ClientesObj.CpfCnpj = ;
124         objDados.ClientesObj.Pessoa = ;
125         objDados.ClientesObj.Estrangeiro = ;
126         objDados.ClientesObj.IdentEstrangeiro = ;
127         objDados.ClientesObj.RS = ;
128         objDados.ClientesObj.NomeFant = ;
129         objDados.ClientesObj.Endereco = ;
130         objDados.ClientesObj.Num = ;
131         objDados.ClientesObj.Cep = ;
132         objDados.ClientesObj.FoneRes = ;
133         objDados.ClientesObj.FoneCom = ;
134         objDados.ClientesObj.Cel = ;
135         objDados.ClientesObj.OutrosCont = ;
136         objDados.ClientesObj.Email =; 
137         objDados.ClientesObj.IdentFiscal = ;
138         objDados.ClientesObj.InscEst = ;
139         objDados.ClientesObj.InscMun = ;

            if op == 1 { 
                objDados.inserir(objDados.ClientesObj());
                MessageBox.Show("Cliente inserido com sucesso!");
            }
            else op == 2 {
                objDados.atualizar(objDados.ClientesObj())
                MessageBox.Show("Cliente atualizado com sucesso!");
            }
            else MessageBox.Show("Ops... Operação inválida.");
        }
        
        public void Alterar(){
            
        }
        
        public void remover(){
            
            
        }
        
        
        endrergion

        
    }
}
