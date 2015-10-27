using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public class DadosClientes
    {
       public class ClientesObj {
       public string Nome = "";
           public string CpfCnpj = "";
        public int Pessoa = 1;
        public bool Estrangeiro = false;
        public string IdentEstrangeiro = "";
        public string RS = "";
        public string NomeFant = "";
        public string Endereco = "";
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

        public void Consulta() {
            
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
        
        public void inserir(ClientesObj clientes)
            {


                string SqlInsert = "insert into t0050 values(@Nome, @CpfCnpj, @Pessoa, @Estrangeiro, ";
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
        
         public void atualizar(ClientesObj clientes, string IdCliente)
            {
                string SqlUpdate = "update t0050 set ";
                
                SqlUpdate += "Nome = @Nome, ";
                SqlUpdate += "CpfCnpj = @CpfCnpj, ";
                SqlUpdate += "Pessoa = @Pessoa, "; 
                SqlUpdate += "Estrangeiro = @Estrangeiro, ";
                SqlUpdate += "RS = @RS, ";
                SqlUpdate += "NomeFant = NomeFant,"; 
                SqlUpdate += "Endereco = @Endereco, ";
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
                
                SqlUpdate += "where IdCliente = @IdCliente";
                
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

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
                ObjCmd.Parameters.AddWithValue("@IdCliente", IdCliente);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }
        
        public void remover(string IdCliente)
            {
                try
                {
                    string SqlRemov = "delete t0050 where IdCliente = @IdCliente";
                    SqlConnection ObjConn = new SqlConnection(SrtCon);
                    SqlCommand ObjCmd = new SqlCommand(SqlRemov, ObjConn);

                    ObjCmd.Parameters.AddWithValue("@IdCliente", IdCliente);

                    ObjConn.Open();

                    ObjCmd.ExecuteNonQuery();

                    ObjConn.Close();

                    MessageBox.Show("O Cliente " + IdCliente+" foi excluído com sucesso.");

                }
                catch (Exception ex) {

                    MessageBox.Show("Ao tentar excluir: " + ex.Message.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
