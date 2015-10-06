using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_NFC_e
{
    public class DadosProdutos
    {
       public class ProdObj 
       {
        public string Desc;
        public string CodBarras;
        public int Ncm;
        public int  UnMed;
        public char CstIcms;
        public string TipTribIcms;
        public char AliqIcms;
        public string CstIpi;
        public char AliqIpi;
        public string CstPis;
        public char AliqPis;
        public string CstCofins;
        public char AliqCofins;
        public string Deposito;
        public string LocDepos;
        public string SubLocDepos;
        public string Fornecedor;
        public string Vendedor;
        public string GrupItens;
       }
        
        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public DataTable Consulta() { 
            
                string SqlSelect = "select * from t0040";
                /*Cria o objeto de conexão com o banco */
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                /*Cria o objeto de execução do comando */
                SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);
                ObjConn.Open();   
                /*Executa o comando*/
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                /*Abre a conexão */
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }


        public DataTable Consulta(int IdProd)
        { 
                    
                /*Query SQL*/    
                string SqlSelect = "select * from t0040 where IdProd = @IdProd";
               
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);
                
                /*Definição de parãmetros da Query */
                ObjCmd.Parameters.AddWithValue("@IdProd", IdProd);
                
                ObjConn.Open();   
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }
        
        public void inserir(ProdObj Prod)
            {
                string SqlInsert = "insert into t0040 values(@Desc, @CodBarras, @Ncm, @UnMed, ";
                SqlInsert += "@CstIcms, TipTribIcms, @AliqIcms, @CstIpi, @AliqIpi, @CstPis, @AliqPis, @CstCofins, @AliqCofins, ";
                SqlInsert += "@Deposito, @LocDepos, @SubLocDepos, @Fornecedor, @Vendedor, @GrupItens)";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

                ObjCmd.Parameters.AddWithValue("@Desc", Prod.Desc);
                ObjCmd.Parameters.AddWithValue("@CodBarras", Prod.CodBarras);
                ObjCmd.Parameters.AddWithValue("@Ncm", Prod.Ncm);
                ObjCmd.Parameters.AddWithValue("@UnMed", Prod.UnMed);
                ObjCmd.Parameters.AddWithValue("@CstIcms", Prod.CstIcms);
                ObjCmd.Parameters.AddWithValue("@TipTribIcms", Prod.TipTribIcms);
                ObjCmd.Parameters.AddWithValue("@AliqIcms", Prod.AliqIcms);
                ObjCmd.Parameters.AddWithValue("@CstIpi", Prod.CstIpi);
                ObjCmd.Parameters.AddWithValue("@AliqIpi", Prod.AliqIpi);
                ObjCmd.Parameters.AddWithValue("@CstPis", Prod.CstPis);
                ObjCmd.Parameters.AddWithValue("@AliqPis", Prod.AliqPis);
                ObjCmd.Parameters.AddWithValue("@CstCofins", Prod.CstCofins);
                ObjCmd.Parameters.AddWithValue("@AliqCofins", Prod.AliqCofins);
                ObjCmd.Parameters.AddWithValue("@Deposito", Prod.Deposito);
                ObjCmd.Parameters.AddWithValue("@LocDepos", Prod.LocDepos);
                ObjCmd.Parameters.AddWithValue("@SubLocDepos", Prod.SubLocDepos);
                ObjCmd.Parameters.AddWithValue("@Fornecedor", Prod.Fornecedor);
                ObjCmd.Parameters.AddWithValue("@Vendedor", Prod.Vendedor);
                ObjCmd.Parameters.AddWithValue("@GrupItens", Prod.GrupItens);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }
        
         public void atualizar(ClientesObj clientes)
            {
                string SqlInsert = "update t0050 set Nome = @Nome, CpfCnpj = @CpfCnpj, Pessoa = @Pessoa, @Estrangeiro, ";
                SqlInsert += "@IdentEstrangeiro, @RS, @NomeFant, @Endereco, ";
                SqlInsert += "@Num, @Cep, @FoneRes, @FoneCom, ";
                SqlInsert += "@Cel, @OutrosCont, @Email, @IdentFiscal, ";
                SqlInsert += "@InscEst, @InscMun)";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

                ObjCmd.Parameters.AddWithValue("@Nome", clientes.Nome);
                ObjCmd.Parameters.AddWithValue("@CpfCnpj", clientes.CpfCnpj);
                ObjCmd.Parameters.AddWithValue("@Pessoa", clientes.Pessoa);
                ObjCmd.Parameters.AddWithValue("@Estrangeiro", clientes.Estrangeiro);
                ObjCmd.Parameters.AddWithValue("@IdentEstrangeiro", clientes.IdentEstrangeiro);
                ObjCmd.Parameters.AddWithValue("@RS", clientes.RS);
                ObjCmd.Parameters.AddWithValue("@NomeFant", clientes.NomeFant);
                ObjCmd.Parameters.AddWithValue("@Endereco", clientes.Endereco);
                ObjCmd.Parameters.AddWithValue("@Num", clientes.Num);
                ObjCmd.Parameters.AddWithValue("@Cep", clientes.Cep);
                ObjCmd.Parameters.AddWithValue("@FoneRes", clientes.FoneRes);
                ObjCmd.Parameters.AddWithValue("@FoneCom", clientes.FoneCom);
                ObjCmd.Parameters.AddWithValue("@Cel", clientes.Cel);
                ObjCmd.Parameters.AddWithValue("@OutrosCont", clientes.OutrosCont);
                ObjCmd.Parameters.AddWithValue("@Email", clientes.Email);
                ObjCmd.Parameters.AddWithValue("@IdentFiscal", clientes.IdentFiscal);
                ObjCmd.Parameters.AddWithValue("@InscEst", clientes.InscEst);
                ObjCmd.Parameters.AddWithValue("@InscMun", clientes.InscMun);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }
        
        public string nome {
            get { return SrtCon; }
        }
    }
}
