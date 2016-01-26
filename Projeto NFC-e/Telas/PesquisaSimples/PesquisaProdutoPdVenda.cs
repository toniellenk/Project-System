using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public partial class PesquisaProdutoPdVenda : Projeto_NFC_e.FormPesquisaSimples
    {
        public PesquisaProdutoPdVenda(FormPdVenda Form)
            : base(Form)
        {
            CampoId = "t0025.IdProd";
            CampoDesc = "t0025.Nome";
            Tipo = "Produto";
            Procura = SecaoFormPdVenda.TxtBoxProduto.Text;
        }


        public override void CarregarFormBase()
        {
            DataTable mDataTable = new DataTable();

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
            mDataColumn.ColumnName = "Un. Med.";
            mDataTable.Columns.Add(mDataColumn);


            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Aliq. ICMS";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Aliq. IPI";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Aliq. PIS";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "Aliq. COFINS";
            mDataTable.Columns.Add(mDataColumn);

            DataRow linha;


            string colunas = "t0025.IdProd, t0025.Nome as NomeProduto, t0025.UnMed, t0025.AliqIcms, t0025.AliqIpi, t0025.AliqPis, t0025.AliqCofins";
            DadosProdutos Produto = new DadosProdutos();
            Produto.Consulta(colunas, "where t0025.IdProd = " + LsVyPrinc.CurrentRow.Cells[0].Value.ToString());
            foreach (DataRow dr in Produto.dt.Rows)
            {

                linha = mDataTable.NewRow();

                linha["ID"] = dr["IdProd"].ToString();
                linha["Descrição"] = dr["NomeProduto"].ToString();
                linha["Un. Med."] = dr["UnMed"].ToString();
                linha["Aliq. ICMS"] = dr["AliqIcms"].ToString();
                linha["Aliq. IPI"] = dr["AliqIpi"].ToString();
                linha["Aliq. PIS"] = dr["AliqPis"].ToString();
                linha["Aliq. COFINS"] = dr["AliqCofins"].ToString();

                mDataTable.Rows.Add(linha);


            }

            SecaoFormPdVenda.LsVyPdVenda.DataSource = mDataTable;
            SecaoFormPdVenda.LsVyPdVenda.Columns[0].Width = 30;
            SecaoFormPdVenda.LsVyPdVenda.Columns[1].Width = 200;
            SecaoFormPdVenda.LsVyPdVenda.Columns[2].Width = 35;

        }
    }
}
