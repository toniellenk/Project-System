using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public class DadosCidadesBairros
    {
        public class BairCidObj {
            public string NomeCidade = "";
            public int IdCidade;
            public int IdEstado;
            public string CodIbge = "";
            public string NomeBairro = "";
            public string Ddd = "";
       }
        
        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public void Consulta() {
            
        try
            {
                string SqlSelect = "select * from t0030 inner join t0031 on t0030.CodCidade = t0031.CodCidade";
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


        public void ConsultaCidade(string Condicoes)
        { 
                    
                /*Query SQL*/
                string SqlSelect = "select top 100 * from t0030 " + Condicoes;
               
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

        public void ConsultaBairro(string Condicoes)
        {

            /*Query SQL*/
            string SqlSelect = "select * from t0031 " + Condicoes;

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
        
        public void InserirCidade(BairCidObj dados)
            {


                string SqlInsert = "insert into t0030 values(@NomeCidade, @CodIbge, @Ddd, @IdEstado)";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

                ObjCmd.Parameters.AddWithValue("@NomeCidade", dados.NomeCidade);
                ObjCmd.Parameters.AddWithValue("@CodIbge", dados.CodIbge);
                ObjCmd.Parameters.AddWithValue("@Ddd", dados.Ddd);
                ObjCmd.Parameters.AddWithValue("@IdEstado", dados.IdEstado);

                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }

        public void InserirBairro(BairCidObj dados)
        {


            string SqlInsert = "insert into t0031 values(@NomeBairro, @IdCidade)";
            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

            ObjCmd.Parameters.AddWithValue("@NomeBairro", dados.NomeBairro);
            ObjCmd.Parameters.AddWithValue("@IdCidade", dados.IdCidade);

            ObjConn.Open();

            ObjCmd.ExecuteNonQuery();

            ObjConn.Close();
        }

        public void AtualizarCidade(BairCidObj dados, string IdCidade)
            {
                string SqlUpdate = "update t0030 set ";

                SqlUpdate += "NomeCidade = @NomeCidade, ";
                SqlUpdate += "CodIbge = @CodIbge, ";
                SqlUpdate += "Ddd = @Ddd, ";
                SqlUpdate += "IdEstado = @IdEstado ";

                SqlUpdate += "where IdCidade = @IdCidade";
                
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

                ObjCmd.Parameters.AddWithValue("@NomeCidade", dados.NomeCidade);
                ObjCmd.Parameters.AddWithValue("@CodIbge", dados.CodIbge);
                ObjCmd.Parameters.AddWithValue("@Ddd", dados.Ddd);
                ObjCmd.Parameters.AddWithValue("@IdEstado", dados.IdEstado);
                ObjCmd.Parameters.AddWithValue("@IdCidade", IdCidade);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }


        public void AtualizarBairro(BairCidObj dados, string IdBairro)
        {
            string SqlUpdate = "update t0031 set ";

            SqlUpdate += "NomeBairro = @NomeBairro, ";
            SqlUpdate += "IdCidade = @IdCidade ";

            SqlUpdate += "where IdBairro = @IdBairro";

            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

            ObjCmd.Parameters.AddWithValue("@NomeBairro", dados.NomeCidade);
            ObjCmd.Parameters.AddWithValue("@IdCidade", dados.IdEstado);
            ObjCmd.Parameters.AddWithValue("@IdBairro", IdBairro);

            ObjConn.Open();

            ObjCmd.ExecuteNonQuery();

            ObjConn.Close();
        }
        
        public void RemoverCidade(string IdCidade)
            {
                try
                {
                    string SqlRemov = "delete t0030 where IdCidade = @IdCidade";
                    SqlConnection ObjConn = new SqlConnection(SrtCon);
                    SqlCommand ObjCmd = new SqlCommand(SqlRemov, ObjConn);

                    ObjCmd.Parameters.AddWithValue("@IdCidade", IdCidade);

                    ObjConn.Open();

                    ObjCmd.ExecuteNonQuery();

                    ObjConn.Close();

                    MessageBox.Show("A Cidade " + IdCidade + " foi excluída com sucesso.");

                }
                catch (Exception ex) {

                    MessageBox.Show("Ao tentar excluir: " + ex.Message.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        public void RemoverBairro(string IdBairro)
        {
            try
            {
                string SqlRemov = "delete t0031 where IdBairro = @IdBairro";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlRemov, ObjConn);

                ObjCmd.Parameters.AddWithValue("@IdBairro", IdBairro);

                ObjConn.Open();

                ObjCmd.ExecuteNonQuery();

                ObjConn.Close();

                MessageBox.Show("O Bairro " + IdBairro + " foi excluído com sucesso.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ao tentar excluir: " + ex.Message.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
