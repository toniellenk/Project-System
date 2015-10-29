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
        public string Nome = "";
        public string DescDet = "";
        public string CodBarras = "";
        public string Ncm = "";
        public string UnMed = "";
        public string TipTribIcms = "";
        public string AliqIcms = "";
        public string AliqIcmsSubst = "";
        public string TipTribIpi = "";
        public string AliqIpi = "";
        public string CstPis = "";
        public string AliqPis = "";
        public string CstCofins = "";
        public string AliqCofins = "";
        public string Deposito = "";
        public string LocDepos = "";
        public string SubLocDepos = "";
        public string Fornecedor = "";
        public string GrupItens = "";
        public string Natureza = "";
        public string CustoCompra = "";
        public string CustoMedio = "";
        public string CustoPersonalizado = "";
        public bool CompSusp = false;
        public bool VendSusp = false;
        public bool ControlEstoq = false;

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
                string SqlInsert = "insert into t0025 values(@Nome, @DescDet, @CodBarras, @Ncm, @UnMed, ";
                SqlInsert += "@TipTribIcms, @AliqIcms, @AliqIcmsSubst, @TipTribIpi, @AliqIpi, @CstPis, @AliqPis, @CstCofins, @AliqCofins, ";
                SqlInsert += "@Deposito, @LocDepos, @SubLocDepos, @Fornecedor, @GrupItens, @Natureza,";
                SqlInsert +=  "@CustoCompra, @CustoMedio, @CustoPersonalizado, @CompSusp, @VendSusp, @ControlEstoq)";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

                ObjCmd.Parameters.AddWithValue("@Nome", Prod.Nome);
                ObjCmd.Parameters.AddWithValue("@DescDet", Prod.DescDet);
                ObjCmd.Parameters.AddWithValue("@CodBarras", Prod.CodBarras);
                ObjCmd.Parameters.AddWithValue("@Ncm", Prod.Ncm);
                ObjCmd.Parameters.AddWithValue("@UnMed", Prod.UnMed);
                ObjCmd.Parameters.AddWithValue("@CstIcms", Prod.AliqIcmsSubst);
                ObjCmd.Parameters.AddWithValue("@TipTribIcms", Prod.TipTribIcms);
                ObjCmd.Parameters.AddWithValue("@AliqIcms", Prod.AliqIcms);
                ObjCmd.Parameters.AddWithValue("@AliqIcmsSubst", Prod.AliqIcmsSubst);
                ObjCmd.Parameters.AddWithValue("@TipTribIpi", Prod.TipTribIpi);
                ObjCmd.Parameters.AddWithValue("@AliqIpi", Prod.AliqIpi);
                ObjCmd.Parameters.AddWithValue("@CstPis", Prod.CstPis);
                ObjCmd.Parameters.AddWithValue("@AliqPis", Prod.AliqPis);
                ObjCmd.Parameters.AddWithValue("@CstCofins", Prod.CstCofins);
                ObjCmd.Parameters.AddWithValue("@AliqCofins", Prod.AliqCofins);
                ObjCmd.Parameters.AddWithValue("@Deposito", Prod.Deposito);
                ObjCmd.Parameters.AddWithValue("@LocDepos", Prod.LocDepos);
                ObjCmd.Parameters.AddWithValue("@SubLocDepos", Prod.SubLocDepos);
                ObjCmd.Parameters.AddWithValue("@Fornecedor", Prod.Fornecedor);
                ObjCmd.Parameters.AddWithValue("@GrupItens", Prod.GrupItens);
                ObjCmd.Parameters.AddWithValue("@Natureza", Prod.Natureza);
                ObjCmd.Parameters.AddWithValue("@CustoCompra", Prod.CustoCompra);
                ObjCmd.Parameters.AddWithValue("@CustoMedio", Prod.CustoMedio);
                ObjCmd.Parameters.AddWithValue("@CustoPersonalizado", Prod.CustoPersonalizado);
                ObjCmd.Parameters.AddWithValue("@CompSusp", Prod.CompSusp);
                ObjCmd.Parameters.AddWithValue("@VendSusp", Prod.VendSusp);
                ObjCmd.Parameters.AddWithValue("ControlEstoq", Prod.ControlEstoq);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }

        public void atualizar(ProdObj Prod, string IdProd)
            {
                string SqlUpdate = "update t0025 set ";
                
                SqlUpdate += "Nome = @Nome, ";
                SqlUpdate += "DescDet = @DescDet, ";
                SqlUpdate += "CodBarras = @CodBarras, ";
                SqlUpdate += "Ncm = @Ncm, ";
                SqlUpdate += "UnMed = @UnMed, ";
                SqlUpdate += "TipTribIcms = @TipTribIcms, ";
                SqlUpdate += "AliqIcms = @AliqIcms,";
                SqlUpdate += "AliqIcmsSubst = @AliqIcmsSubst, ";
                SqlUpdate += "TipTribIpi = @TipTribIpi, ";
                SqlUpdate += "AliqIpi = @AliqIpi, ";
                SqlUpdate += "CstPis = @CstPis, ";
                SqlUpdate += "AliqPis = @AliqPis, ";
                SqlUpdate += "CstCofins = @CstCofins, ";
                SqlUpdate += "AliqCofins = @AliqCofins, ";
                SqlUpdate += "Deposito = @Deposito, ";
                SqlUpdate += "LocDepos = @LocDepos, "; 
                SqlUpdate += "SubLocDepos = @SubLocDepos, "; 
                SqlUpdate += "Fornecedor = @Fornecedor, "; 
                SqlUpdate += "GrupItens = @GrupItens "; 
                SqlUpdate += "Natureza = @Natureza ";
                SqlUpdate += "CustoCompra = @CustoCompra ";
                SqlUpdate += "CustoMedio = @CustoMedio ";
                SqlUpdate += "CustoPersonalizado = @CustoPersonalizado ";
                SqlUpdate += "CompSusp = @CompSusp ";
                SqlUpdate += "VendSusp = @VendSusp ";
                
                SqlUpdate += "where IdProd = @IdProd";
                
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

                ObjCmd.Parameters.AddWithValue("@Nome", Prod.Nome);
                ObjCmd.Parameters.AddWithValue("@DescDet", Prod.DescDet);
                ObjCmd.Parameters.AddWithValue("@CodBarras", Prod.CodBarras);
                ObjCmd.Parameters.AddWithValue("@Ncm", Prod.Ncm);
                ObjCmd.Parameters.AddWithValue("@UnMed", Prod.UnMed);
                ObjCmd.Parameters.AddWithValue("@TipTribIcms", Prod.TipTribIcms);
                ObjCmd.Parameters.AddWithValue("@AliqIcms", Prod.AliqIcms);
                ObjCmd.Parameters.AddWithValue("@AliqIcmsSubst", Prod.AliqIcmsSubst);
                ObjCmd.Parameters.AddWithValue("@TipTribIpi", Prod.TipTribIpi);
                ObjCmd.Parameters.AddWithValue("@AliqIpi", Prod.AliqIpi);
                ObjCmd.Parameters.AddWithValue("@CstPis", Prod.CstPis);
                ObjCmd.Parameters.AddWithValue("@AliqPis", Prod.AliqPis);
                ObjCmd.Parameters.AddWithValue("@CstCofins", Prod.CstCofins);
                ObjCmd.Parameters.AddWithValue("@AliqCofins", Prod.AliqCofins);
                ObjCmd.Parameters.AddWithValue("@Deposito", Prod.Deposito);
                ObjCmd.Parameters.AddWithValue("@LocDepos", Prod.LocDepos);
                ObjCmd.Parameters.AddWithValue("@SubLocDepos", Prod.SubLocDepos);
                ObjCmd.Parameters.AddWithValue("@Fornecedor", Prod.Fornecedor);
                ObjCmd.Parameters.AddWithValue("@GrupItens", Prod.GrupItens);
                ObjCmd.Parameters.AddWithValue("@Natureza", Prod.Natureza);
                ObjCmd.Parameters.AddWithValue("@CustoCompra", Prod.CustoCompra);
                ObjCmd.Parameters.AddWithValue("@CustoMedio", Prod.CustoMedio);
                ObjCmd.Parameters.AddWithValue("@CustoPersonalizado", Prod.CustoPersonalizado);
                ObjCmd.Parameters.AddWithValue("@CompSusp", Prod.CompSusp);
                ObjCmd.Parameters.AddWithValue("@VendSusp", Prod.VendSusp);
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
