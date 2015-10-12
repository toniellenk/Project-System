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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            LsVyPrinc.Visible = false;
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void nFeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nFeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNfe NFE = new FormNfe();
            NFE.ShowDialog();
        }

        private void MenuInicial_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saldoProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarListView(); 

        }

        private void BuNvCliente_Click(object sender, EventArgs e)
        {
            FormNvCliente NovoCliente = new FormNvCliente();
            NovoCliente.Show();

        }

        private void ListViewPinc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Métodos
         private void CarregarListView() 
        {
            DadosClientes objDados = new DadosClientes();
            objDados.Consulta();

            DataTable mDataTable = new DataTable();

            DataColumn mDataColumn;
            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "ID";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Nome";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "CPF / CNPJ";
            mDataTable.Columns.Add(mDataColumn);


            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Telefone";
            mDataTable.Columns.Add(mDataColumn);


            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Celular";
            mDataTable.Columns.Add(mDataColumn);


            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "e-mail";
            mDataTable.Columns.Add(mDataColumn);



            DataRow linha;
            

            foreach (DataRow dr in objDados.dt.Rows)
            {
                linha = mDataTable.NewRow();
                linha["ID"] = dr["IdCliente"].ToString(); 
                linha["Nome"] =  dr["Nome"].ToString();
                linha["CPF / CNPJ"] =  dr["CpfCnpj"].ToString();
                linha["Telefone"] = dr["FoneRes"].ToString();
                linha["Celular"] = dr["Cel"].ToString();
                linha["e-mail"] = dr["Email"].ToString();
                mDataTable.Rows.Add(linha);
            }

            
         //   LsVyPrinc.View = View.Details;
            LsVyPrinc.DataSource = mDataTable;
            LsVyPrinc.Visible = true;

        }
        #endregion

         private void LsVyPrinc_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
         {

         }

         private void LsVyPrinc_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

    }
}
