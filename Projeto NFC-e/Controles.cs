﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Projeto_NFC_e
{
    public class Controles
    {
        
        public class BotaoNv{
            public static int NvCliente()
            {
                return 1;
            } 

        };

        public class BotaoAlt
        {
            public static int AltCliente()
            {
                return 1;
            }

        };

        public class BotaoDel
        {
            public static int DelCliente()
            {
                return 1;
            }

        };

        public class FiltrosGradeCliente
        {
            public bool CodCliente;
            public bool Nome;
            public bool Cnpj;

        };


        public static void Novo(int Botao)
        {
            if (Botao == 1)
            {
                    FormNvCliente NovoCliente = new FormNvCliente(1, 1);
                    NovoCliente.Show();  
                }

        }

        public static void Alterar(int Botao, int ItemSelect)
        {

            if (Botao == 1)
            {               
                FormNvCliente ALterarCliente = new FormNvCliente(2, ItemSelect);
                ALterarCliente.Show();
            }

        }

        public static void Remover(int Botao, int ItemSelect)
        {

            switch (Botao){
                case 1:
                    {
                        DadosClientes DelCliente = new DadosClientes();
                        DelCliente.remover(ItemSelect);
                        break;
                    }              
                    
            }
        }

        public static DataTable CarregarGradeClientes()
        {

            DataTable mDataTable = new DataTable();

        //    switch (Filtros.Nome)
       //     {

           //     case true:
            //        {
                        DadosClientes objDados = new DadosClientes();
                        objDados.Consulta();
                                               

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
                            string CpfCnpj = dr["CpfCnpj"].ToString();

                            if (CpfCnpj.Length >= 14)
                            {
                                CpfCnpj = CpfCnpj.Substring(1, 2) + "." + CpfCnpj.Substring(3, 3) + "." + CpfCnpj.Substring(6, 3) + "/" + CpfCnpj.Substring(9, 4) + "-" + CpfCnpj.Substring(13, 2);
                            }
                            if (CpfCnpj.Length <= 11)
                            {
                                CpfCnpj = CpfCnpj.Substring(1, 3) + "." + CpfCnpj.Substring(4, 3) + "." + CpfCnpj.Substring(7, 3) + "-" + CpfCnpj.Substring(10, 2);
                            }

                            linha = mDataTable.NewRow();
                            linha["ID"] = dr["IdCliente"].ToString();
                            linha["Nome"] = dr["Nome"].ToString();
                            linha["CPF / CNPJ"] = CpfCnpj;
                            linha["Telefone"] = dr["FoneRes"].ToString();
                            linha["Celular"] = dr["Cel"].ToString();
                            linha["e-mail"] = dr["Email"].ToString();
                            mDataTable.Rows.Add(linha);
                        }


                        return mDataTable;   
                        
                  //  }
              //  default: {
              //      return mDataTable;
                    
            //    }
          //  }
        }


    }
}