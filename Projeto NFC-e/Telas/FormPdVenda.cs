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
        public DataTable mDataTable = new DataTable();
        public DataRow linha;
        private int Operacao;

        public FormPdVenda(int Op, string ItemSelect)
        {
            InitializeComponent();
            ImgBloq.Visible = false;
            ImgAlert.Visible = false;
            ImgAlert.Visible = false;
            Operacao = Op;
            if (Op == 2)
            {
                 CarregarDadosAlterar(ItemSelect);
            }
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

        private void LabSalvarProduto_Click(object sender, EventArgs e)
        {

        }

        private void RadButIDCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormPdVenda_Load(object sender, EventArgs e)
        {
            LsVyPdVenda.DataSource = MontarGrade();
            LsVyPdVenda.Columns[0].Width = 30;
            LsVyPdVenda.Columns[1].Width = 200;
          //  LsVyPdVenda.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            LsVyPdVenda.Columns[2].Width = 35;
            linha = mDataTable.NewRow();


        }

        private DataTable MontarGrade()
        {
            
            DataColumn mDataColumn;
            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "ID";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Descrição";
            mDataTable.Columns.Add(mDataColumn);


            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Unid.";
            mDataTable.Columns.Add(mDataColumn);


            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Quant.";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Valor Unit.";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "% Desc.";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Val. Desc.";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Valor Total";
            mDataTable.Columns.Add(mDataColumn);

            return mDataTable;
        }

        private void LabSaldEst_Click(object sender, EventArgs e)
        {

        }

        private void AddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                linha[3] = TxtBoxQuantUnit.Text;
                linha[4] = TxtBoxPreco.Text;
                linha[5] = Convert.ToString(Convert.ToDouble(TxtBoxDescontoUnit.Text) / (Convert.ToDouble(TxtBoxQuantUnit.Text) * Convert.ToDouble(TxtBoxPreco.Text)) * 100) + " %";
                linha[6] = TxtBoxDescontoUnit.Text;
                linha[7] = (Convert.ToDouble(TxtBoxQuantUnit.Text) * Convert.ToDouble(TxtBoxPreco.Text)) - Convert.ToDouble(TxtBoxDescontoUnit.Text);
                
                foreach (DataGridViewRow Dr in LsVyPdVenda.Rows)
                {
                    if (Dr.Cells[0].Value.ToString() == TxtBoxProduto.Text.Trim())
                    {
                        MessageBox.Show("O produto " + TxtBoxProduto.Text.Trim() + " já está na grade.", "Item em Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        mDataTable.Rows.Add(linha);
                        LsVyPdVenda.DataSource = mDataTable;
                        linha = mDataTable.NewRow();
                    }
                } 
                  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir este produto na grade: " + ex.Message.ToString(), "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ButDelProd_Click(object sender, EventArgs e)
        {
            //LsVyPdVenda.Rows.RemoveAt(LsVyPdVenda.CurrentRow.Cells[0].ToString);

            foreach (DataGridViewRow r in LsVyPdVenda.SelectedRows)
               if (MessageBox.Show("Tem certeza que vai exluir o produto? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   LsVyPdVenda.Rows.Remove(r);
        }
        
        public void CarregarDadosAlterar(string ItemSelect){
                    
            try {
                PesqSimplClientePdVenda TelaPesquisa = new PesqSimplClientePdVenda(this);
                if (RadButIDCliente.Checked) TelaPesquisa.TipoProcura = 1;
                if (RadButNomeCliente.Checked) TelaPesquisa.TipoProcura = 2; 
                PesqSimplClientePdVenda.CarregarFormBase(ItemSelect);
                }
            catch (Exception ex)
            {               
                MessageBox.Show("Ao filtrar dados dados: " + ex.Message.ToString(), "Erro ao Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
        }
        
    }
}
