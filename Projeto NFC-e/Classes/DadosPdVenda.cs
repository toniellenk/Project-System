using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_NFC_e 
{
    class DadosPdVenda
    {
        public class PdVendaObj
        {
            
            public string IdLoja = "";
            public string IdCliente = "";
            public string IdNatOperacao = "";
	        public string IdSerie = "";
	        public string DataEmissao = "";
	        public string DataUltAlter = "";
	        public string DataVenc = "";
	        public string IdVendedor = "";
	        public string Status = "";
	        public bool PendCredito = false;
            public bool PendDesconto = false;
            public bool PendEstoque = false;
	        public string PendCusto = "";
	        public string BcIcmsTotal = "";
	        public string ValorIcms = "";
	        public string BcIcmsSt = "";
	        public string ValorIcmsSt = "";
	        public string ValorIpi = "";
	        public string ValorPis = "";
	        public string ValorCofins = "";
	        public string ValorOutros = "";
	        public string ValorTotProd = "";
	        public string ValorFrete = "";
	        public string DescontoTotal = "";
	        public string ValorTotalLiq = "";
	        public string Observacoes = "";
	        public string IdCondPagamento = "";
	        public string EspecMonetaria = "";
	        public string AcrescFinan = "";
            public string ValorTotParcelas = "";

        }

        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public void Consulta()
        {

            try
            {
                string SqlSelect = "select * from t0060";
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
                //return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ao conectar a base de dados: " + ex.Message.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public void Consulta(string Condicoes)
        {

            /*Query SQL*/
            string SqlSelect = "select * from t0060" + Condicoes;

            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);

            /*Definição de parãmetros da Query */
            //   ObjCmd.Parameters.AddWithValue("@Condicoes", Condicoes);

            ObjConn.Open();
            SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            ObjConn.Close();
        }

        public void Consulta(string Colunas, string Condicoes)
        {

            /*Query SQL*/
            string SqlSelect = "select top 100 " + Colunas + " from t0060 ";
            SqlSelect += "inner join t0001 on t0060.IdLoja = t0001.IdLoja ";
            SqlSelect += "inner join t0050 on t0060.IdCliente = t0050.IdCliente ";
            SqlSelect += "inner join t0065 on t0060.IdNatOperacao = t0065.IdNatOperacao ";
            SqlSelect += "inner join t0070 on t0060.IdSerie = t0070.IdSerie ";
            SqlSelect += "inner join t0075 on t0060.IdVendedor = t0075.IdVendedor ";
            SqlSelect += "inner join t0080 on t0060.IdCondPagamento = t0080.IdCondPagamento ";
            SqlSelect += Condicoes;

            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);

            /*Definição de parãmetros da Query */
            //   ObjCmd.Parameters.AddWithValue("@Condicoes", Condicoes);

            ObjConn.Open();
            SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            ObjConn.Close();
        }

        public void inserir(PdVendaObj PdVenda)
        {


            string SqlInsert = "insert into t0060 values( ";
            SqlInsert += "@IdLoja,";
            SqlInsert += "@IdCliente,";
            SqlInsert += "@IdNatOperacao,";
            SqlInsert += "@IdSerie,";
            SqlInsert += "@DataEmissao,";
            SqlInsert += "@DataUltAlter,";
            SqlInsert += "@DataVenc,";
            SqlInsert += "@IdVendedor,";
            SqlInsert += "@Status,";
            SqlInsert += "@PendCredito,";
            SqlInsert += "@PendDesconto,";
            SqlInsert += "@PendEstoque,";
            SqlInsert += "@PendCusto,";
            SqlInsert += "@BcIcmsTotal,";
            SqlInsert += "@ValorIcms,";
            SqlInsert += "@BcIcmsSt,";
            SqlInsert += "@ValorIcmsSt,";
            SqlInsert += "@ValorIpi,";
            SqlInsert += "@ValorPis,";
            SqlInsert += "@ValorCofins,";
            SqlInsert += "@ValorOutros,";
            SqlInsert += "@ValorTotProd,";
            SqlInsert += "@ValorFrete,";
            SqlInsert += "@DescontoTotal,";
            SqlInsert += "@ValorTotalLiq,";
            SqlInsert += "@Observacoes,";
            SqlInsert += "@IdCondPagamento,";
            SqlInsert += "@EspecMonetaria,";
            SqlInsert += "@AcrescFinan,";
            SqlInsert += "@ValorTotParcelas)";

            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

            ObjCmd.Parameters.AddWithValue("@IdLoja", PdVenda.IdLoja);
            ObjCmd.Parameters.AddWithValue("@IdCliente", PdVenda.IdCliente);
            ObjCmd.Parameters.AddWithValue("@IdNatOperacao", PdVenda.IdNatOperacao);
            ObjCmd.Parameters.AddWithValue("@IdSerie", PdVenda.IdSerie);
            ObjCmd.Parameters.AddWithValue("@DataEmissao", PdVenda.DataEmissao);
            ObjCmd.Parameters.AddWithValue("@DataUltAlter", PdVenda.DataUltAlter);
            ObjCmd.Parameters.AddWithValue("@DataVenc", PdVenda.DataVenc);
            ObjCmd.Parameters.AddWithValue("@IdVendedor", PdVenda.IdVendedor);
            ObjCmd.Parameters.AddWithValue("@Status", PdVenda.Status);
            ObjCmd.Parameters.AddWithValue("@PendCredito", PdVenda.PendCredito);
            ObjCmd.Parameters.AddWithValue("@PendDesconto", PdVenda.PendDesconto);
            ObjCmd.Parameters.AddWithValue("@PendEstoque", PdVenda.PendEstoque);
            ObjCmd.Parameters.AddWithValue("@PendCusto", PdVenda.PendCusto);
            ObjCmd.Parameters.AddWithValue("@BcIcmsTotal", PdVenda.BcIcmsTotal);
            ObjCmd.Parameters.AddWithValue("@ValorIcms", PdVenda.ValorIcms);
            ObjCmd.Parameters.AddWithValue("@BcIcmsSt", PdVenda.BcIcmsSt);
            ObjCmd.Parameters.AddWithValue("@ValorIcmsSt", PdVenda.ValorIcmsSt);
            ObjCmd.Parameters.AddWithValue("@ValorIpi", PdVenda.ValorIpi);
            ObjCmd.Parameters.AddWithValue("@ValorPis", PdVenda.ValorPis);
            ObjCmd.Parameters.AddWithValue("@ValorCofins", PdVenda.ValorCofins);
            ObjCmd.Parameters.AddWithValue("@ValorOutros", PdVenda.ValorOutros);
            ObjCmd.Parameters.AddWithValue("@ValorTotProd", PdVenda.ValorTotProd);
            ObjCmd.Parameters.AddWithValue("@ValorFrete", PdVenda.ValorFrete);
            ObjCmd.Parameters.AddWithValue("@DescontoTotal", PdVenda.DescontoTotal);
            ObjCmd.Parameters.AddWithValue("@ValorTotalLiq", PdVenda.ValorTotalLiq);
            ObjCmd.Parameters.AddWithValue("@Observacoes", PdVenda.Observacoes);
            ObjCmd.Parameters.AddWithValue("@IdCondPagamento", PdVenda.IdCondPagamento);
            ObjCmd.Parameters.AddWithValue("@EspecMonetaria", PdVenda.EspecMonetaria);
            ObjCmd.Parameters.AddWithValue("@AcrescFinan", PdVenda.AcrescFinan);
            ObjCmd.Parameters.AddWithValue("@ValorTotParcelas", PdVenda.ValorTotParcelas);


            ObjConn.Open();

            ObjCmd.ExecuteNonQuery();

            ObjConn.Close();
        }

        public void atualizar(PdVendaObj PdVenda, string IdPdVenda, string IdLoja)
        {
            string SqlUpdate = "update t0060 set ";

            SqlUpdate += "IdLoja = @IdLoja, ";
            SqlUpdate += "IdCliente = @IdCliente, ";
            SqlUpdate += "IdNatOperacao = @IdNatOperacao, ";
            SqlUpdate += "IdSerie = @IdSerie, ";
            SqlUpdate += "DataEmissao = @DataEmissao, ";
            SqlUpdate += "DataUltAlter = @DataUltAlter, ";
            SqlUpdate += "DataVenc = @DataVenc, ";
            SqlUpdate += "IdVendedor = @IdVendedor, ";
            SqlUpdate += "Status = @Status, ";
            SqlUpdate += "PendCredito = @PendCredito, ";
            SqlUpdate += "PendDesconto = @PendDesconto, ";
            SqlUpdate += "PendEstoque = @PendEstoque, ";
            SqlUpdate += "PendCusto = @PendCusto, ";
            SqlUpdate += "BcIcmsTotal = @BcIcmsTotal, ";
            SqlUpdate += "ValorIcms = @ValorIcms, ";
            SqlUpdate += "BcIcmsSt = @BcIcmsSt, ";
            SqlUpdate += "ValorIcmsSt = @ValorIcmsSt, ";
            SqlUpdate += "ValorIpi = @ValorIpi, ";
            SqlUpdate += "ValorPis = @ValorPis, ";
            SqlUpdate += "ValorCofins = @ValorCofins, ";
            SqlUpdate += "ValorOutros = @ValorOutros, ";
            SqlUpdate += "ValorTotProd = @ValorTotProd, ";
            SqlUpdate += "ValorFrete = @ValorFrete, ";
            SqlUpdate += "DescontoTotal = @DescontoTotal, ";
            SqlUpdate += "ValorTotalLiq = @ValorTotalLiq, ";
            SqlUpdate += "Observacoes = @Observacoes, ";
            SqlUpdate += "IdCondPagamento = @IdCondPagamento, ";
            SqlUpdate += "EspecMonetaria = @EspecMonetaria, ";
            SqlUpdate += "AcrescFinan = @AcrescFinan, ";
            SqlUpdate += "ValorTotParcelas = @ValorTotParcelas ";

            SqlUpdate += "where IdPdVenda = @IdPdVenda and IdLoja = @IdLoja";

            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

            ObjCmd.Parameters.AddWithValue("@IdCliente", PdVenda.IdCliente);
            ObjCmd.Parameters.AddWithValue("@IdNatOperacao", PdVenda.IdNatOperacao);
            ObjCmd.Parameters.AddWithValue("@IdSerie", PdVenda.IdSerie);
            ObjCmd.Parameters.AddWithValue("@DataEmissao", PdVenda.DataEmissao);
            ObjCmd.Parameters.AddWithValue("@DataUltAlter", PdVenda.DataUltAlter);
            ObjCmd.Parameters.AddWithValue("@DataVenc", PdVenda.DataVenc);
            ObjCmd.Parameters.AddWithValue("@IdVendedor", PdVenda.IdVendedor);
            ObjCmd.Parameters.AddWithValue("@Status", PdVenda.Status);
            ObjCmd.Parameters.AddWithValue("@PendCredito", PdVenda.PendCredito);
            ObjCmd.Parameters.AddWithValue("@PendDesconto", PdVenda.PendDesconto);
            ObjCmd.Parameters.AddWithValue("@PendEstoque", PdVenda.PendEstoque);
            ObjCmd.Parameters.AddWithValue("@PendCusto", PdVenda.PendCusto);
            ObjCmd.Parameters.AddWithValue("@BcIcmsTotal", PdVenda.BcIcmsTotal);
            ObjCmd.Parameters.AddWithValue("@ValorIcms", PdVenda.ValorIcms);
            ObjCmd.Parameters.AddWithValue("@BcIcmsSt", PdVenda.BcIcmsSt);
            ObjCmd.Parameters.AddWithValue("@ValorIcmsSt", PdVenda.ValorIcmsSt);
            ObjCmd.Parameters.AddWithValue("@ValorIpi", PdVenda.ValorIpi);
            ObjCmd.Parameters.AddWithValue("@ValorPis", PdVenda.ValorPis);
            ObjCmd.Parameters.AddWithValue("@ValorCofins", PdVenda.ValorCofins);
            ObjCmd.Parameters.AddWithValue("@ValorOutros", PdVenda.ValorOutros);
            ObjCmd.Parameters.AddWithValue("@ValorTotProd", PdVenda.ValorTotProd);
            ObjCmd.Parameters.AddWithValue("@ValorFrete", PdVenda.ValorFrete);
            ObjCmd.Parameters.AddWithValue("@DescontoTotal", PdVenda.DescontoTotal);
            ObjCmd.Parameters.AddWithValue("@ValorTotalLiq", PdVenda.ValorTotalLiq);
            ObjCmd.Parameters.AddWithValue("@Observacoes", PdVenda.Observacoes);
            ObjCmd.Parameters.AddWithValue("@IdCondPagamento", PdVenda.IdCondPagamento);
            ObjCmd.Parameters.AddWithValue("@EspecMonetaria", PdVenda.EspecMonetaria);
            ObjCmd.Parameters.AddWithValue("@AcrescFinan", PdVenda.AcrescFinan);
            ObjCmd.Parameters.AddWithValue("@ValorTotParcelas", PdVenda.ValorTotParcelas);
            ObjCmd.Parameters.AddWithValue("@IdLoja", IdLoja);
            ObjCmd.Parameters.AddWithValue("@IdPdVenda", IdPdVenda);

            ObjConn.Open();

            ObjCmd.ExecuteNonQuery();

            ObjConn.Close();
        }

        public void remover(string IdPdVenda, string IdLoja)
        {
            try
            {
                string SqlRemov = "delete t0060 where IdPdVenda = @IdPdVenda and IdLoja = @IdLoja";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlRemov, ObjConn);

                ObjCmd.Parameters.AddWithValue("@IdPdVenda", IdPdVenda);
                ObjCmd.Parameters.AddWithValue("@IdLoja", IdLoja);

                ObjConn.Open();

                ObjCmd.ExecuteNonQuery();

                ObjConn.Close();

                MessageBox.Show("O Pedido de Venda " + IdPdVenda + " da Loja " + IdLoja + " foi excluído com sucesso.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ao tentar excluir: " + ex.Message.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
