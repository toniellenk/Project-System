using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace Projeto_NFC_e
{
    public class Controles
    {
        public class BotaoNv
        {
            public static int NvCliente
            {
                get { return 1; }
            } 
            
            public static int NvProduto
            {
                get { return 2; }
            } 

        };

        public class BotaoFiltro
        {
            public static int FiltCliente
            {
                get { return 1; }
            }

            public static int FiltProduto
            {
                get { return 2; }
            } 

        };
        

        public class BotaoAlt
        {
            public static int AltCliente()
            {
                return 1;
            }
            
            public static int AltProduto()
            {
                return 2;
            }

        };

        public class BotaoDel
        {
            public static int DelCliente()
            {
                return 1;
            }
            
            public static int DelProd()
            {
                return 2;
            }

        };

    /*    public Dictionary<string, string> FiltrosGrade()
        {
            Filtros = new string[] { "ID", "NOME", "CPF / CNPJ", "TELEFONE", "E - MAIL" };
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            for (int i = 0; i < Filtros.Length; i++)
            {
                comboSource.Add(Convert.ToString(i), Convert.ToString(Filtros[i]));
            }
            return comboSource;
        }
    */

        public static void Novo(int Botao)
        {
            switch (Botao){
                case 1:
                    {
                        FormCliente NovoCliente = new FormCliente(1, "1");
                        NovoCliente.Show();  
                        break;
                    }
                case 2:
                    {
                        FormProduto NovoProduto = new FormProduto(1, "1");
                        NovoProduto.Show();  
                        break;
                    } 
            }

        }

        public static void Alterar(int Botao, string ItemSelect)
        {

            switch (Botao){
                case 1:
                    {
                        FormCliente ALterarCliente = new FormCliente(2, ItemSelect);
                        ALterarCliente.Show();
                        break;
                    }
                case 2:
                    {
                        FormProduto AlterarProduto = new FormProduto(2, ItemSelect);
                        AlterarProduto.Show(); 
                        break;
                    } 
            }
        }

        public static void Remover(int Botao, string ItemSelect)
        {

            switch (Botao){
                case 1:
                    {
                        DadosClientes DelCliente = new DadosClientes();
                        DelCliente.remover(ItemSelect);
                        break;
                    } 
                case 2:
                    {
                        DadosProdutos DelProduto = new DadosProdutos();
                        DelProduto.remover(ItemSelect);
                        break;
                    }
                    
            }
        }

        public static DataTable CarregarGradeClientes(string Condicoes)
        {

                        DataTable mDataTable = new DataTable();

                        DadosClientes objDados = new DadosClientes();
                        objDados.Consulta(Condicoes);
                                               

                        DataColumn mDataColumn;
                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "ID";
                        mDataTable.Columns.Add(mDataColumn);

                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "NOME";
                        mDataTable.Columns.Add(mDataColumn);

 
                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "CPF / CNPJ";
                        mDataTable.Columns.Add(mDataColumn);


                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "TELEFONE";
                        mDataTable.Columns.Add(mDataColumn);


                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "CELULAR";
                        mDataTable.Columns.Add(mDataColumn);


                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "E-MAIL";
                        mDataTable.Columns.Add(mDataColumn);
                      

                        DataRow linha;



                        foreach (DataRow dr in objDados.dt.Rows)
                        {
                            string CpfCnpj = dr["CpfCnpj"].ToString();

                            CpfCnpj = CpfCnpj.Trim();

                            if (CpfCnpj.Length == 14)
                            {
                                CpfCnpj = CpfCnpj.Substring(0, 2) + "." + CpfCnpj.Substring(2, 3) + "." + CpfCnpj.Substring(5, 3) + "/" + CpfCnpj.Substring(8, 4) + "-" + CpfCnpj.Substring(12, 2);
                            }
                            if (CpfCnpj.Length == 11)
                            {
                                CpfCnpj = CpfCnpj.Substring(0, 3) + "." + CpfCnpj.Substring(3, 3) + "." + CpfCnpj.Substring(6, 3) + "-" + CpfCnpj.Substring(9, 2);
                            }

                            

                            linha = mDataTable.NewRow();
                            linha["ID"] = dr["IdCliente"].ToString();
                            linha["NOME"] = dr["Nome"].ToString();
                            linha["CPF / CNPJ"] = CpfCnpj;
                            linha["TELEFONE"] = dr["FoneRes"].ToString();
                            linha["CELULAR"] = dr["Cel"].ToString();
                            linha["E-MAIL"] = dr["Email"].ToString();                      

                            mDataTable.Rows.Add(linha);
                        }


                        return mDataTable;   

        }

        public static DataTable CarregarGradeRapida(string Condicoes, string Tabela)
        {

            DataTable mDataTable = new DataTable();         
            


            DataColumn mDataColumn;
            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "ID";
            mDataTable.Columns.Add(mDataColumn);

            mDataColumn = new DataColumn();
            mDataColumn.DataType = Type.GetType("System.String");
            mDataColumn.ColumnName = "DESCRIÇÃO";
            mDataTable.Columns.Add(mDataColumn);

            DataRow linha;

            switch (Tabela)
            {
                case "Cidade":
                    {
                        DadosCidadesBairros objDados = new DadosCidadesBairros();

                        objDados.ConsultaCidade(Condicoes);

                        foreach (DataRow dr in objDados.dt.Rows)
                        {

                            linha = mDataTable.NewRow();

                            linha["ID"] = dr["IdCidade"].ToString().Trim();
                            linha["DESCRIÇÃO"] = dr["Nome"].ToString();

                            mDataTable.Rows.Add(linha);
                        }

                        break;
                    }
                case "Bairro":
                    {
                        DadosCidadesBairros objDados = new DadosCidadesBairros();

                        objDados.ConsultaBairro(Condicoes);

                        foreach (DataRow dr in objDados.dt.Rows)
                        {

                            linha = mDataTable.NewRow();

                            linha["ID"] = dr["IdBairro"].ToString().Trim();
                            linha["DESCRIÇÃO"] = dr["Nome"].ToString();

                            mDataTable.Rows.Add(linha);
                        }

                        break;
                    }
            }


            





            return mDataTable;

        }

        public static DataTable CarregarGradeProdutos(string Condicoes)
                {

                        DataTable mDataTable = new DataTable();


                        DadosProdutos objDados = new DadosProdutos();
                        objDados.Consulta(Condicoes);
                                               

                        DataColumn mDataColumn;
                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "ID";
                        mDataTable.Columns.Add(mDataColumn);

                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "NOME";
                        mDataTable.Columns.Add(mDataColumn);

                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "DESCRIÇÃO DETALHADA";
                        mDataTable.Columns.Add(mDataColumn);


                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "GRUPO DE ITENS";
                        mDataTable.Columns.Add(mDataColumn);


                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "UN. MEDIDA";
                        mDataTable.Columns.Add(mDataColumn);


                        mDataColumn = new DataColumn();
                        mDataColumn.DataType = Type.GetType("System.String");
                        mDataColumn.ColumnName = "NATUREZA";
                        mDataTable.Columns.Add(mDataColumn);

                        DataRow linha;



                        foreach (DataRow dr in objDados.dt.Rows)
                        {
                            linha = mDataTable.NewRow();
                            linha["ID"] = dr["IdProd"].ToString();
                            linha["NOME"] = dr["Nome"].ToString();
                            linha["DESCRIÇÃO DETALHADA"] = dr["DescDet"].ToString();
                            linha["GRUPO DE ITENS"] = dr["GrupItens"].ToString();
                            linha["UN. MEDIDA"] = dr["UnMed"].ToString();
                            linha["NATUREZA"] = dr["Natureza"].ToString();

                        //    Filtros = new string[] { "ID", "NOME", "DESCRIÇÃO DETALHADA", "GRUPO DE ITENS", "UN. MEDIDA", "NATUREZA" };

                            mDataTable.Rows.Add(linha);
                        }


                        return mDataTable;   

                }


    }
}
