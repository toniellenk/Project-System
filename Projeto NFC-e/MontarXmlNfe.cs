using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;


namespace Projeto_NFC_e
{

   
    class MontarXmlNfe
    {

      XmlDocument XmlArq = new XmlDocument();
      XmlText noText;
      string NFeNamespace = "http://www.portalfiscal.inf.br/nfe";

      void InserirNo(XmlElement NoInsert, string tag, string valor)
      {
          XmlElement no;
          no = XmlArq.CreateElement(tag, NFeNamespace);
          noText = XmlArq.CreateTextNode(valor);
          no.AppendChild(noText);
          NoInsert.AppendChild(no); 
    
        }

      public XmlDocument MontarXmlEnvNfe()
        {


            XmlElement raiz, no, noNFe, noide, noInfNFe, noemit, noenderEmit, det, prod;
            XmlAttribute att;

            raiz = XmlArq.CreateElement("enviNFe", NFeNamespace);
            // Atributos do nó de enviNFe
            att = XmlArq.CreateAttribute("versao");
            att.Value = "3.10";
            raiz.Attributes.Append(att);

            no = XmlArq.CreateElement("idLote", NFeNamespace);
            noText = XmlArq.CreateTextNode("12190");
            no.AppendChild(noText);
            // "Nó" é filho de raiz :
            raiz.AppendChild(no);

            no = XmlArq.CreateElement("indSinc", NFeNamespace);
            noText = XmlArq.CreateTextNode("0");
            no.AppendChild(noText);
            // "Nó" é filho de raiz :
            raiz.AppendChild(no);

            // infNFE
            noInfNFe = XmlArq.CreateElement("infNFe", NFeNamespace);
            att = XmlArq.CreateAttribute("Id");
            att.Value = "NFe51150973715146000197650650000031481128930037";
            noInfNFe.Attributes.Append(att);

            att = XmlArq.CreateAttribute("versao");
            att.Value = "3.10";
            noInfNFe.Attributes.Append(att);
            
             // ide
            noide = XmlArq.CreateElement("ide", NFeNamespace);
            noInfNFe.AppendChild(noide);
            

            // Filhos do ide

            InserirNo( noide, "cUF", "51");

            InserirNo( noide, "cNF", "12893003");

            InserirNo( noide, "natOp", "3148");

            InserirNo( noide, "indPag", "0");

            InserirNo( noide, "mod", "65");

            InserirNo( noide, "serie", "65");

            InserirNo( noide, "nNF", "3148");

            InserirNo( noide, "dhEmi", "2015-09-25T15:52:51-04:00");

            InserirNo( noide, "tpNF", "1");

            InserirNo( noide, "idDest", "1");

            InserirNo(noide, "cMunFG", "5103403");

            InserirNo( noide, "tpImp", "4");

            InserirNo( noide, "tpEmis", "1");

            InserirNo( noide, "cDV", "7");

            InserirNo(noide, "tpAmb", "1");

            InserirNo( noide, "finNFe", "1");

            InserirNo( noide, "indFinal", "1");

            InserirNo( noide, "indPres", "1");

            InserirNo( noide, "procEmi", "0");                      
            
            InserirNo( noide, "verProc", "4.539");
            
             // emit
            noemit = XmlArq.CreateElement("emit", NFeNamespace);
            noInfNFe.AppendChild(noemit);

            // filhos emit
            
            InserirNo( noemit, "CNPJ", "73715146000197");
            
            InserirNo( noemit, "xNome", "1 - BABY HOUSE COM BRINQ E UTILIDADES LTDA");

            InserirNo(noemit, "xFant", "BABY DREAMS");
            
             // enderEmit
            noenderEmit = XmlArq.CreateElement("enderEmit", NFeNamespace);
            noemit.AppendChild(noenderEmit);
            
            InserirNo( noenderEmit, "xLgr", "RUA 24 DE OUTUBRO");
            
            InserirNo( noenderEmit, "nro", "723");
            
            InserirNo( noenderEmit, "xBairro", "BOSQUE");
            
            InserirNo( noenderEmit, "cMun", "5103403");
            
            InserirNo( noenderEmit, "xMun", "CUIABA");
            
            InserirNo( noenderEmit, "UF", "MT");
            
            InserirNo( noenderEmit, "CEP", "78045290");
            
            InserirNo( noenderEmit, "cPais", "1058");
            
            InserirNo( noenderEmit, "xPais", "BRASIL");
            
            InserirNo( noenderEmit, "fone", "6533228570");
            
            InserirNo( noemit, "IE", "131495453");
            
            InserirNo( noemit, "CRT", "3");

            // det
            det = XmlArq.CreateElement("det", NFeNamespace);
            att = XmlArq.CreateAttribute("nItem");
            att.Value = "1";
            det.Attributes.Append(att);
            noInfNFe.AppendChild(det);

            // prod
            prod = XmlArq.CreateElement("prod", NFeNamespace);
            det.AppendChild(prod);

            // filhos prod
            InserirNo(prod, "cProd", "8639");

            InserirNo(prod, "cEAN", "");

            InserirNo(prod, "xProd", "BODY M/C LILAS MAMAE E EU TEMOS ALGO 241-242 T-P/M");

            InserirNo(prod, "NCM", "61119090");

            InserirNo(prod, "CFOP", "5102");

            InserirNo(prod, "uCom", "PC");

            InserirNo(prod, "qCom", "1");

            InserirNo(prod, "vUnCom", "46.31");

            InserirNo(prod, "vProd", "46.31");

            InserirNo(prod, "cEANTrib", "");

            InserirNo(prod, "uTrib", "PC");

            InserirNo(prod, "qTrib", "1");

            InserirNo(prod, "vUnTrib", "46.31");

            InserirNo(prod, "vDesc", "1.86");

            InserirNo(prod, "indTot", "1");

            // *** Inclua os demais campos aqui ....

            // Hierarquia de nós
            noNFe = XmlArq.CreateElement("NFe", NFeNamespace);
            att = XmlArq.CreateAttribute("xmlns");
            att.Value = "http://www.portalfiscal.inf.br/nfe";
            noNFe.Attributes.Append(att);
            noNFe.AppendChild(noInfNFe);        

            raiz.AppendChild(noNFe);          

            XmlArq.AppendChild(raiz);
            XmlArq.PreserveWhitespace = true;
            XmlArq.Save("C:/Nfe.xml");
            return XmlArq;
        }
      } 
  }    
