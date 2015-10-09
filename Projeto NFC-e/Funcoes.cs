﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projeto_NFC_e
{
    class Funcoes
    {
        public static int DigitoModulo11(string intNumero)
        {
            int[] intPesos = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 
            9, 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4 };
            string strText = intNumero;

            if (strText.Length > 43)
                throw new Exception("Número não suportado pela função!");

            int intSoma = 0;
            int intIdx = 0;
            for (int intPos = strText.Length - 1; intPos >= 0; intPos--)
            {
                intSoma += Convert.ToInt32(strText[intPos].ToString()) * intPesos[intIdx];
                intIdx++;
            }
            int intResto = (intSoma * 10) % 11;
            int intDigito = intResto;
            if (intDigito >= 10)
                intDigito = 0;

            return intDigito;
        }

        public static string ConvertHexa(string intNumero) {

            string hex = "";

            foreach (char c in intNumero)
            {

                hex += ((int)c).ToString("x");
            }

            return hex;
        }

        public static string generateHasg(string strAssinatura)
        {
            SHA1 hasher = SHA1.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] array = encoding.GetBytes(strAssinatura);
            array = hasher.ComputeHash(array);

            StringBuilder strHexa = new StringBuilder();

            foreach (byte item in array)
            {
                // Convertendo  para Hexadecimal
                strHexa.Append(item.ToString("x2"));
            }

            return strHexa.ToString();
        }

        public static string Token(string intNumero) 
        {
       string chave = "5115107371514600019765065000003148112893003" + Convert.ToString(Funcoes.DigitoModulo11("5115107371514600019765065000003148112893003"));
       string token;
       token = "chNFe=" + chave;
       token += "&nVersao=100";
       token += "&tpAmb=2";
       token += "&cDest=99999999000191";
       string data = Convert.ToString(DateTime.UtcNow);
       token += "&dhEmi=323031352d30312d32305431373a30303a34392d30323a3030&vNF=1.00&vICMS=0.00&digVal=2f4a703477714e6d6e4e646d31776b64743936655a486b65354f513d&cIdToken=000001&cHashQRCode=ecc4f0e7e612456f2e3521768bd572b6f0eae240";  
    return token;
        }

        public static string DataHoraAtual(){
            return DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss-04:00");
        }


    }
}