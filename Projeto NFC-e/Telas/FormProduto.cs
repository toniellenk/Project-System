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
            if (ValidaCampos())
            {
                //      AdcAtua(Operacao);
                //      Close();
                MessageBox.Show("Validoooou!");
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox26_Enter(object sender, EventArgs e)
        {

        }
        
        
        #region Métodos
        /*
        public void AdcAtua(int Op){

            DadosProdutos.ProdObj ObjProduto = new DadosProdutos.ProdObj();
            
            if (RadButJur.Checked == true)         
            {
                ObjProduto.CpfCnpj = MaskCPF_CNPJ.Text;
                ObjProduto.RS = TxtBxRS.Text;
                ObjProduto.NomeFant = TxtBxNomFant.Text;

            }
            else
            {
                ObjProduto.CpfCnpj = MaskCPF_CNPJ.Text;
                ObjProduto.Nome  = TxtBxRS.Text;
            }  
            ObjProduto.Estrangeiro = ChBxEntrangeiro.Checked;
            ObjProduto.IdentEstrangeiro = TxtBoxIdentEstrang.Text;                     
            ObjProduto.Endereco = TxtBxEndereco.Text ;
            ObjProduto.Num = TxtBxNum.Text;
            ObjProduto.Cep = MaskCep.Text;
            ObjProduto.FoneRes = MaskFoneRes.Text;
            ObjProduto.FoneCom = MaskFonComer.Text;
            ObjProduto.Cel = MaskCel.Text;
            ObjProduto.OutrosCont = TxtBxOutContatos.Text;
            ObjProduto.Email = TxtBxEmail.Text; 

            if (RadButConsFinal.Checked) {
                 ObjProduto.IdentFiscal = 3;
                 ObjProduto.InscMun =  TxtBxIM.Text;
            }
            if (RadButContICMS.Checked){             
                ObjProduto.IdentFiscal = 1;
                ObjProduto.InscEst = TxtBoxIE.Text;
                ObjProduto.InscMun = TxtBxIM.Text;
            }
            else  {
                ObjProduto.IdentFiscal = 2;
                ObjProduto.InscMun = TxtBoxIE.Text;
            }



            DadosClientes ObjDadosClientes = new DadosClientes();

            if (Op == 1 && ValidaCampos()){ 
                ObjDadosClientes.inserir(ObjProduto);
                MessageBox.Show("Cliente inserido com sucesso!");
            }
            if (Op == 2) {
                ObjDadosClientes.atualizar(ObjProduto, IdCliente);
                MessageBox.Show("Cliente atualizado com sucesso!");
            }  
        
        }
        */
        /*
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
         */ 
         
         public bool ValidaCampos() { 
            bool retorno = true;
            string CapInvalid = "";


            if (string.IsNullOrEmpty(TxtNome.Text))
                        {
                retorno = false;
                CapInvalid += "* Nome \n";
                epErro.SetError(GrpNome, "O campo Nome não pode ficar em branco."); 

                        }
            if (string.IsNullOrEmpty(TxtNcm.Text))
            {
                retorno = false;
                CapInvalid += "* NCM \n";
                epErro.SetError(TxtNcm, "Preencha o código de NCM do produto.");

            }
            if (string.IsNullOrEmpty(TxtNat.Text))
            {
                retorno = false;
                CapInvalid += "* Natureza \n";
                epErro.SetError(TxtNat, "Preencha o código da Natureza do produto.");

            }
            if (string.IsNullOrEmpty(TxtGrupItens.Text))
            {
                retorno = false;
                CapInvalid += "* Grupo de Itens \n";
                epErro.SetError(TxtGrupItens, "Preencha o código de Grupo de Itens do produto.");

            }
            if (RadButContEst.Checked == true && (string.IsNullOrEmpty(TxtDep.Text)))
            {
                retorno = false;
                CapInvalid += "* Depósito \n";
                epErro.SetError(TxtDep, "Preencha o código de Depósito do produto.");

            }
            if (string.IsNullOrEmpty(TxtUnMed.Text))
            {
                retorno = false;
                CapInvalid += "* Unidade de Medida \n";
                epErro.SetError(GrpUnMed, "Preencha com a sigla da Unidade de Medida do produto.");

            }
            if (string.IsNullOrEmpty(TxtTipTribIcms.Text))
            {
                retorno = false;
                CapInvalid += "* Tipo de Tributação de ICMS \n";
                epErro.SetError(TxtTipTribIcms, "Preencha o Tipo de Tributação de ICMS do produto.");

            }
            if (string.IsNullOrEmpty(TxtTipTribIpi.Text))
            {
                retorno = false;
                CapInvalid += "* Tipo de Tributação de IPI \n";
                epErro.SetError(TxtTipTribIpi, "Preencha o Tipo de Tributação de ICMS do produto.");

            }
            if (string.IsNullOrEmpty(TxtCstCofins.Text))
            {
                retorno = false;
                CapInvalid += "* CST de COFINS \n";
                epErro.SetError(TxtCstCofins, "Preencha o CST de COFINS do produto.");

            }
            if (string.IsNullOrEmpty(TxtCstPis.Text))
            {
                retorno = false;
                CapInvalid += "* CST de PIS \n";
                epErro.SetError(TxtCstPis, "Preencha o CST de PIS do produto.");

            }
            if (string.IsNullOrEmpty(TxtAliqIcms.Text))
            {
                retorno = false;
                CapInvalid += "* Alíquota de ICMS \n";
                epErro.SetError(TxtAliqIcms, "Preencha a Alíquota de ICMS do produto.");

            }
            if (string.IsNullOrEmpty(TxtAliqIcmsSubst.Text))
            {
                retorno = false;
                CapInvalid += "* Alíquota de ICMS Substituição \n";
                epErro.SetError(TxtAliqIcmsSubst, "Preencha a  Alíquota de ICMS Substituição do produto.");

            }
            if (string.IsNullOrEmpty(TxtAliqIpi.Text))
            {
                retorno = false;
                CapInvalid += "* Alíquota de IPI \n";
                epErro.SetError(TxtAliqIpi, "Preencha a Alíquota de IPI do produto.");

            }
            if (string.IsNullOrEmpty(TxtAliqPis.Text))
            {
                retorno = false;
                CapInvalid += "* Alíquota de PIS \n";
                epErro.SetError(TxtAliqPis, "Preencha a Alíquota de PIS do produto.");

            }
            if (string.IsNullOrEmpty(TxtAliqCofins.Text))
            {
                retorno = false;
                CapInvalid += "* Alíquota de COFINS \n";
                epErro.SetError(TxtAliqCofins, "Preencha a Alíquota de COFINS do produto.");

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
        
    
        #endregion

    }
}
