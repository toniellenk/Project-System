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
    public partial class FormProduto : Form
    {

        private int Operacao;
        private string IdCliente; 
        public FormProduto()
        {
            
            InitializeComponent();


        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

         private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void FormCadClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   if (ValidaCampos()){
          //      AdcAtua(Operacao);
          //      Close();
            }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        
        /*
        #region Métodos
        
        public void AdcAtua(int Op){
            
            DadosClientes.ClientesObj ObjCliente = new DadosClientes.ClientesObj();
            
            if (RadButJur.Checked == true)         
            {
                ObjCliente.CpfCnpj = MaskCPF_CNPJ.Text;
                ObjCliente.RS = TxtBxRS.Text;
                ObjCliente.NomeFant = TxtBxNomFant.Text;

            }
            else
            {
                ObjCliente.CpfCnpj = MaskCPF_CNPJ.Text;
                ObjCliente.Nome  = TxtBxRS.Text;
            }  
            ObjCliente.Estrangeiro = ChBxEntrangeiro.Checked;
            ObjCliente.IdentEstrangeiro = TxtBoxIdentEstrang.Text;                     
            ObjCliente.Endereco = TxtBxEndereco.Text ;
            ObjCliente.Num = TxtBxNum.Text;
            ObjCliente.Cep = MaskCep.Text;
            ObjCliente.FoneRes = MaskFoneRes.Text;
            ObjCliente.FoneCom = MaskFonComer.Text;
            ObjCliente.Cel = MaskCel.Text;
            ObjCliente.OutrosCont = TxtBxOutContatos.Text;
            ObjCliente.Email = TxtBxEmail.Text; 

            if (RadButConsFinal.Checked) {
                 ObjCliente.IdentFiscal = 3;
                 ObjCliente.InscMun =  TxtBxIM.Text;
            }
            if (RadButContICMS.Checked){             
                ObjCliente.IdentFiscal = 1;
                ObjCliente.InscEst = TxtBoxIE.Text;
                ObjCliente.InscMun = TxtBxIM.Text;
            }
            else  {
                ObjCliente.IdentFiscal = 2;
                ObjCliente.InscMun = TxtBoxIE.Text;
            }



            DadosClientes ObjDadosClientes = new DadosClientes();

            if (Op == 1 && ValidaCampos()){ 
                ObjDadosClientes.inserir(ObjCliente);
                MessageBox.Show("Cliente inserido com sucesso!");
            }
            if (Op == 2) {
                ObjDadosClientes.atualizar(ObjCliente, IdCliente);
                MessageBox.Show("Cliente atualizado com sucesso!");
            }  
        
        }
        public void Alterar(string ItemSelect){

            DadosClientes objDados = new DadosClientes();
            objDados.Consulta(ItemSelect);

//            DataTable mDataTable = new DataTable();

            DataRow linha = objDados.dt.Rows[0];        
            
            
                LabNumID.Text = linha["IdCliente"].ToString();                
                MaskCPF_CNPJ.Text = linha["CpfCnpj"].ToString();
                int IdentPessoa = Convert.ToInt32(linha["Pessoa"].ToString());
                if (IdentPessoa == 1)
                {
                    RadButFis.Checked = true;
                    TxtBxRS.Text = linha["Nome"].ToString();
                }
                if (IdentPessoa == 2)
                {
                    RadButJur.Checked = true;
                    TxtBxRS.Text = linha["RS"].ToString();
                }
                if (Convert.ToBoolean(linha["Estrangeiro"].ToString()) == true)
                {
                    ChBxEntrangeiro.Checked = true;
                    TxtBoxIdentEstrang.Text = linha["IdentEstrangeiro"].ToString();
                 }                
                TxtBxNomFant.Text = linha["NomeFant"].ToString();
                TxtBxEndereco.Text = linha["Endereco"].ToString();
                TxtBxNum.Text = linha["Num"].ToString();
                MaskCep.Text = linha["Cep"].ToString();
                MaskFoneRes.Text = linha["FoneRes"].ToString();
                MaskFonComer.Text = linha["FoneCom"].ToString();
                MaskCel.Text = linha["Cel"].ToString();
                TxtBxOutContatos.Text = linha["OutrosCont"].ToString();
                TxtBxEmail.Text = linha["Email"].ToString();
                int IdentFiscal = Convert.ToInt32(linha["IdentFiscal"].ToString());
                if (IdentFiscal == 1)
                    {
                            RadButContICMS.Checked = true;
                    }
                if (IdentFiscal == 2)
                    {
                           RadButContIsento.Checked = true;
                    }
                if (IdentFiscal == 3)
                    {
                        RadButConsFinal.Checked = true;
                    }
                TxtBoxIE.Text = linha["InscEst"].ToString();
                TxtBxIM.Text = linha["InscMun"].ToString();
          
                      
        }
         public bool ValidaCampos() { 
            bool retorno = true;
            string CapInvalid = "";


            if (string.IsNullOrEmpty(MaskCPF_CNPJ.Text))
                        {
                retorno = false;
                CapInvalid += "* CPF/CNPJ \n";
                epErro.SetError(MaskCPF_CNPJ, "O campo CPF/CNPJ não pode ficar em branco."); 

                        }
            if (string.IsNullOrEmpty(TxtBxRS.Text))
            {
                retorno = false;
                CapInvalid += "* Nome/Rasão Social \n";
                epErro.SetError(TxtBxRS, "Preencha a Rasão Social.");

            }
            if (retorno == false)
            {
                MessageBox.Show("Preencha os campos: \n\n" + CapInvalid, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                retorno = true;
                epErro.Clear();
            }
            return retorno;
        }
        
        
    #endregion */

    }
}
