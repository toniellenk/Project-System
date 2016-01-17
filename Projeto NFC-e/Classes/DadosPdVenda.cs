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
            public string Nome = "";
            public string CpfCnpj = "";
            public int Pessoa = 1;
            public bool Estrangeiro = false;
            public string IdentEstrangeiro = "";
            public string RS = "";
            public string NomeFant = "";
            public string Endereco = "";
            public string IdCidade = "";
            public string Num = "";
            public string Cep = "";
            public string FoneRes = "";
            public string FoneCom = "";
            public string Cel = "";
            public string OutrosCont = "";
            public string Email = "";
            public int IdentFiscal = 1;
            public string InscEst = "";
            public string InscMun = "";

        }

        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public void Consulta()
        {

            try
            {
                string SqlSelect = "select * from t0050";
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
            string SqlSelect = "select * from t0050" + Condicoes;

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


            string SqlInsert = "insert into t0050 values(@Nome, @CpfCnpj, @Pessoa, @Estrangeiro, ";
            SqlInsert += "@IdentEstrangeiro, @RS, @NomeFant, @Endereco, @IdCidade,";
            SqlInsert += "@Num, @Cep, @FoneRes, @FoneCom, ";
            SqlInsert += "@Cel, @OutrosCont, @Email, @IdentFiscal, ";
            SqlInsert += "@InscEst, @InscMun)";
            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

            ObjCmd.Parameters.AddWithValue("@Nome", PdVenda.Nome);
            ObjCmd.Parameters.AddWithValue("@CpfCnpj", PdVenda.CpfCnpj);
            ObjCmd.Parameters.AddWithValue("@Pessoa", PdVenda.Pessoa);
            ObjCmd.Parameters.AddWithValue("@Estrangeiro", PdVenda.Estrangeiro);
            ObjCmd.Parameters.AddWithValue("@IdentEstrangeiro", PdVenda.IdentEstrangeiro);
            ObjCmd.Parameters.AddWithValue("@RS", PdVenda.RS);
            ObjCmd.Parameters.AddWithValue("@NomeFant", PdVenda.NomeFant);
            ObjCmd.Parameters.AddWithValue("@Endereco", PdVenda.Endereco);
            ObjCmd.Parameters.AddWithValue("@IdCidade", PdVenda.IdCidade);
            ObjCmd.Parameters.AddWithValue("@Num", PdVenda.Num);
            ObjCmd.Parameters.AddWithValue("@Cep", PdVenda.Cep);
            ObjCmd.Parameters.AddWithValue("@FoneRes", PdVenda.FoneRes);
            ObjCmd.Parameters.AddWithValue("@FoneCom", PdVenda.FoneCom);
            ObjCmd.Parameters.AddWithValue("@Cel", PdVenda.Cel);
            ObjCmd.Parameters.AddWithValue("@OutrosCont", PdVenda.OutrosCont);
            ObjCmd.Parameters.AddWithValue("@Email", PdVenda.Email);
            ObjCmd.Parameters.AddWithValue("@IdentFiscal", PdVenda.IdentFiscal);
            ObjCmd.Parameters.AddWithValue("@InscEst", PdVenda.InscEst);
            ObjCmd.Parameters.AddWithValue("@InscMun", PdVenda.InscMun);

            ObjConn.Open();

            ObjCmd.ExecuteNonQuery();

            ObjConn.Close();
        }

        public void atualizar(PdVendaObj PdVenda, string IdPdVenda)
        {
            string SqlUpdate = "update t0050 set ";

            SqlUpdate += "Nome = @Nome, ";
            SqlUpdate += "CpfCnpj = @CpfCnpj, ";
            SqlUpdate += "Pessoa = @Pessoa, ";
            SqlUpdate += "Estrangeiro = @Estrangeiro, ";
            SqlUpdate += "IdentEstrangeiro = @IdentEstrangeiro, ";
            SqlUpdate += "RS = @RS, ";
            SqlUpdate += "NomeFant = NomeFant,";
            SqlUpdate += "Endereco = @Endereco, ";
            SqlUpdate += "IdCidade = @IdCidade, ";
            SqlUpdate += "Num = @Num, ";
            SqlUpdate += "Cep = @Cep, ";
            SqlUpdate += "FoneRes = @FoneRes, ";
            SqlUpdate += "FoneCom = @FoneCom, ";
            SqlUpdate += "Cel = @Cel, ";
            SqlUpdate += "OutrosCont = @OutrosCont, ";
            SqlUpdate += "Email = @Email, ";
            SqlUpdate += "IdentFiscal = @IdentFiscal, ";
            SqlUpdate += "InscEst = @InscEst, ";
            SqlUpdate += "InscMun = @InscMun ";

            SqlUpdate += "where IdPdVenda = @IdPdVenda";

            SqlConnection ObjConn = new SqlConnection(SrtCon);
            SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

            ObjCmd.Parameters.AddWithValue("@Nome", PdVenda.Nome);
            ObjCmd.Parameters.AddWithValue("@CpfCnpj", PdVenda.CpfCnpj);
            ObjCmd.Parameters.AddWithValue("@Pessoa", PdVenda.Pessoa);
            ObjCmd.Parameters.AddWithValue("@Estrangeiro", PdVenda.Estrangeiro);
            ObjCmd.Parameters.AddWithValue("@IdentEstrangeiro", PdVenda.IdentEstrangeiro);
            ObjCmd.Parameters.AddWithValue("@RS", PdVenda.RS);
            ObjCmd.Parameters.AddWithValue("@NomeFant", PdVenda.NomeFant);
            ObjCmd.Parameters.AddWithValue("@Endereco", PdVenda.Endereco);
            ObjCmd.Parameters.AddWithValue("@IdCidade", PdVenda.IdCidade);
            ObjCmd.Parameters.AddWithValue("@Num", PdVenda.Num);
            ObjCmd.Parameters.AddWithValue("@Cep", PdVenda.Cep);
            ObjCmd.Parameters.AddWithValue("@FoneRes", PdVenda.FoneRes);
            ObjCmd.Parameters.AddWithValue("@FoneCom", PdVenda.FoneCom);
            ObjCmd.Parameters.AddWithValue("@Cel", PdVenda.Cel);
            ObjCmd.Parameters.AddWithValue("@OutrosCont", PdVenda.OutrosCont);
            ObjCmd.Parameters.AddWithValue("@Email", PdVenda.Email);
            ObjCmd.Parameters.AddWithValue("@IdentFiscal", PdVenda.IdentFiscal);
            ObjCmd.Parameters.AddWithValue("@InscEst", PdVenda.InscEst);
            ObjCmd.Parameters.AddWithValue("@InscMun", PdVenda.InscMun);
            ObjCmd.Parameters.AddWithValue("@IdPdVenda", IdPdVenda);

            ObjConn.Open();

            ObjCmd.ExecuteNonQuery();

            ObjConn.Close();
        }

        public void remover(string IdPdVenda)
        {
            try
            {
                string SqlRemov = "delete t0050 where IdPdVenda = @IdPdVenda";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlRemov, ObjConn);

                ObjCmd.Parameters.AddWithValue("@IdPdVenda", IdPdVenda);

                ObjConn.Open();

                ObjCmd.ExecuteNonQuery();

                ObjConn.Close();

                MessageBox.Show("O PdVenda " + IdPdVenda + " foi excluído com sucesso.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ao tentar excluir: " + ex.Message.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
