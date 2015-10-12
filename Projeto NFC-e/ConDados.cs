using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_NFC_e
{
    public class ConDados
    {
       public class ClientesObj {
        public string Nome;
        public string CpfCnpj;
        public int  Pessoa;
        public bool Estrangeiro;
        public string IdentEstrangeiro;
        public string RS;
        public string NomeFant;
        public string Endereco;
        public string Num;
        public string Cep;
        public string FoneRes;
        public string FoneCom;
        public string Cel;
        public string OutrosCont;
        public string Email;
        public string IdentFiscal;
        public string InscEst;
        public string InscMun;

       }
        
        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public DataTable ConsultaSimples(string Query) {

            string SqlSelect = Query;
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
        
    }
}
