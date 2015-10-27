using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public class DadosProdutos
    {
       public class ProdObj 
       {
        public string Nome;
        public string Desc;
        public string CodBarras;
        public string Ncm;
        public string  UnMed;
        public string CstIcms;
        public string TipTribIcms;
        public string AliqIcms;
        public string CstIpi;
        public string AliqIpi;
        public string CstPis;
        public string AliqPis;
        public string CstCofins;
        public string AliqCofins;
        public string Deposito;
        public string LocDepos;
        public string SubLocDepos;
        public string Fornecedor;
        public string Vendedor;
        public string GrupItens;
        public string Natureza;
       }
        
        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public DataTable Consulta() { 
            
                string SqlSelect = "select * from t0025";
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


        public DataTable Consulta(string Condicoes)
        {

            /*Query SQL*/
                string SqlSelect = "select * from t0025" + Condicoes;
               
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);
                                
                ObjConn.Open();   
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }
        
        public void inserir(ProdObj Prod)
            {
                string SqlInsert = "insert into t0025 values(Nome@, @DescDet, @CodBarras, @Ncm, @UnMed, ";
                SqlInsert += "@CstIcms, TipTribIcms, @AliqIcms, @CstIpi, @AliqIpi, @CstPis, @AliqPis, @CstCofins, @AliqCofins, ";
                SqlInsert += "@Deposito, @LocDepos, @SubLocDepos, @Fornecedor, @Vendedor, @GrupItens, @Natureza)";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

                ObjCmd.Parameters.AddWithValue("Nome@", Prod.Nome);
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
                ObjCmd.Parameters.AddWithValue("Natureza", Prod.Natureza);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }

        public void atualizar(ProdObj Prod, string IdProd)
            {
                string SqlUpdate = "update t0025 set ";
                
                SqlUpdate += "Nome = @Nome, ";
                SqlUpdate += "Nome = @Desc, ";
                SqlUpdate += "CpfCnpj = @CodBarras, ";
                SqlUpdate += "Pessoa = @Pessoa, "; 
                SqlUpdate += "Estrangeiro = @Ncm, ";
                SqlUpdate += "RS = @UnMed, ";
                SqlUpdate += "NomeFant = CstIcms,"; 
                SqlUpdate += "Endereco = @TipTribIcms, ";
                SqlUpdate += "Num = @AliqIcms, ";
                SqlUpdate += "Cep = @CstIpi, ";
                SqlUpdate += "FoneRes = @AliqIpi, ";
                SqlUpdate += "FoneCom = @CstPis, ";
                SqlUpdate += "Cel = @AliqPis, ";
                SqlUpdate += "OutrosCont = @CstCofins, ";
                SqlUpdate += "Email = @AliqCofins, ";
                SqlUpdate += "IdentFiscal = @Deposito, ";
                SqlUpdate += "InscEst = @LocDepos, ";
                SqlUpdate += "Fornecedor = @Fornecedor, "; 
                SqlUpdate += "Vendedor = @Vendedor, "; 
                SqlUpdate += "GrupItens = @GrupItens, "; 
                SqlUpdate += "Natureza = @Natureza "; 
                
                SqlUpdate += "where IdProd = @IdProd";
                
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

                ObjCmd.Parameters.AddWithValue("@Nome", Prod.Nome);
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
                ObjCmd.Parameters.AddWithValue("Natureza", Prod.Natureza);
                ObjCmd.Parameters.AddWithValue("IdProd@", IdProd);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }

        public void remover(string IdProd)
        {
            try
            {
                string SqlRemov = "delete t0025 where IdProd = @IdProd";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlRemov, ObjConn);

                ObjCmd.Parameters.AddWithValue("@IdProd", IdProd);

                ObjConn.Open();

                ObjCmd.ExecuteNonQuery();

                ObjConn.Close();

                MessageBox.Show("O Produto " + IdProd + " foi excluído com sucesso.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ao tentar excluir: " + ex.Message.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
