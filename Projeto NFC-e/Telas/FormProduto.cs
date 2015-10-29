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
        private string IdProduto; 
        
        public FormProduto(int Op, string ItemSelect)
        {
            
            InitializeComponent();
            IdProduto = ItemSelect;
            Operacao = Op;
            if (Op == 2)
            {
                Alterar(ItemSelect);
            }


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
                AdcAtua();
                Close();
               // MessageBox.Show("Validoooou!");
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
        
        public void AdcAtua(){

            DadosProdutos.ProdObj ObjProduto = new DadosProdutos.ProdObj();
            
            ObjProduto.Nome = TxtNome.Text;
            ObjProduto.DescDet = TxtDescDet.Text;
            ObjProduto.CodBarras = TxtCodBarras.Text;
            ObjProduto.Ncm = TxtNcm.Text;
            ObjProduto.UnMed = TxtUnMed.Text;
            ObjProduto.TipTribIcms = TxtTipTribIcms.Text;
            ObjProduto.AliqIcms = TxtAliqIcms.Text;
            ObjProduto.AliqIcmsSubst = TxtAliqIcmsSubst.Text;
            ObjProduto.TipTribIpi = TxtTipTribIpi.Text;
            ObjProduto.AliqIpi = TxtAliqIpit.Text;
            ObjProduto.CstPis = TxtCstPis.Text;
            ObjProduto.AliqPis = TxtAliqPis.Text;
            ObjProduto.CstCofins = TxtCstCofins.Text;
            ObjProduto.AliqCofins = TxtAliqCofins.Text;
            ObjProduto.Deposito = TxtDeposito.Text;
            ObjProduto.LocDepos = TxtLocDepos.Text;
            ObjProduto.SubLocDepos = TxtSubLocDepos.Text;
            ObjProduto.Fornecedor = TxtFornecedor.Text;
            ObjProduto.GrupItens = TxtGrupItens.Text;
            ObjProduto.Natureza = TxtNatureza.Text;
            ObjProduto.CustoCompra = TxtCustoCompra.Text;
            ObjProduto.CustoMedio = TxtCustoMedio.Text;
            ObjProduto.CustoPersonalizado = TxtCustoPersonalizado.Text;
            ObjProduto.CompSusp = RadButVendSusp.Checked;
            ObjProduto.VendSusp = RadButVendSusp.Checked;
            ObjProduto.ControlEstoq = RadButContEst.Checked;

            DadosProdutos ObjDadosProdutos = new DadosProdutos();

            if (Operacao == 1){ 
                ObjDadosProdutos.inserir(ObjProduto);
                MessageBox.Show("Produto inserido com sucesso!");
            }
            if (Operacao == 2) {
                ObjDadosProdutos.atualizar(ObjProduto, IdProduto);
                MessageBox.Show("O Produto "+ItemSelect+" foi atualizado com sucesso!");
            }  
        
        }
     
        
        public void Alterar(string ItemSelect){

            DadosProdutos objDados = new DadosProdutos();
            objDados.Consulta(ItemSelect);

            DataRow linha = objDados.dt.Rows[0];
           
            TxtNome.Text = linha["Nome"].ToString();
            TxtDescDet.Text = linha["DescDet"].ToString();
            TxtCodBarras.Text = linha["CodBarras"].ToString();
            TxtNcm.Text = linha["Ncm"].ToString();
            TxtUnMed.Text = linha["UnMed"].ToString();
            TxtTipTribIcms.Text = linha["TipTribIcms"].ToString();
            TxtAliqIcms.Text = linha["AliqIcms"].ToString();
            TxtAliqIcmsSubst.Text = linha["AliqIcmsSubst"].ToString();
            TxtTipTribIpi.Text = linha["TipTribIpi"].ToString();
            TxtAliqIpi.Text = linha["AliqIpi"].ToString();
            TxtCstPis.Text = linha["CstPis"].ToString();
            TxtAliqPis.Text = linha["AliqPis"].ToString();
            TxtCstCofins.Text = linha["CstCofins"].ToString();
            TxtAliqCofins.Text = linha["AliqCofins"].ToString();
            TxtDeposito.Text = linha["Deposito"].ToString();
            TxtLocDepos.Text = linha["LocDepos"].ToString();
            TxtSubLocDepos.Text = linha["SubLocDepos"].ToString();
            TxtFornecedor.Text = linha["Fornecedor"].ToString();
            TxtGrupItens.Text = linha["GrupItens"].ToString();
            TxtNatureza.Text = linha["Natureza"].ToString();
            TxtCustoCompra.Text = linha["CustoCompra"].ToString();
            TxtCustoMedio.Text = linha["CustoMedio"].ToString();
            TxtCustoPersonalizado.Text = linha["CustoPersonalizado"].ToString();
            RadButCompSusp.Checked = Convert.ToBoolean(linha["CompSusp"].ToString());
            RadButVendSusp.Checked = Convert.ToBoolean(linha["VendSusp"].ToString());
            RadButControlEstoq.Checked = Convert.ToBoolean(linha["ControlEstoq"].ToString());
                      
        }
  
         
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
