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

      public XmlDocument MontarXmlEnvNfe()
        {
 
            XmlDocument XmlArq = new XmlDocument();

            XmlElement raiz, no, noNFe, noide, noInfNFe, noemit;
            XmlAttribute att;

            raiz = XmlArq.CreateElement("enviNFe", NFeNamespace);
            // Atributos do nó de enviNFe
            att = XmlArq.CreateAttribute("versao");
            att.Value = "3.10";
            raiz.Attributes.Append(att);

            XmlText noText;

            no = XmlArq.CreateElement("idLote", NFeNamespace);
            noText = XmlArq.CreateTextNode("1");
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
            noide.AppendChild(noNFe);

            // Filhos do ide
            no = XmlArq.CreateElement("cUF", NFeNamespace);
            noText = XmlArq.CreateTextNode("51");
            no.AppendChild(noText);
            noide.AppendChild(no);

            no = XmlArq.CreateElement("cNF", NFeNamespace);
            noText = XmlArq.CreateTextNode("518005127");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("natOp", NFeNamespace);
            noText = XmlArq.CreateTextNode("VENDAS MERCADORIAS");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("indPag", NFeNamespace);
            noText = XmlArq.CreateTextNode("0");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("mod", NFeNamespace);
            noText = XmlArq.CreateTextNode("65");
            no.AppendChild(noText);
            noide.AppendChild(no);

            no = XmlArq.CreateElement("serie", NFeNamespace);
            noText = XmlArq.CreateTextNode("65");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("nNF", NFeNamespace);
            noText = XmlArq.CreateTextNode("10");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("dhEmi", NFeNamespace);
            noText = XmlArq.CreateTextNode("2015-09-25T15:52:51-04:00");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("tpNF", NFeNamespace);
            noText = XmlArq.CreateTextNode("1");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("idDest", NFeNamespace);
            noText = XmlArq.CreateTextNode("1");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("cMunFG", NFeNamespace);
            noText = XmlArq.CreateTextNode("5103403");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("tpEmis", NFeNamespace);
            noText = XmlArq.CreateTextNode("1");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("cDV", NFeNamespace);
            noText = XmlArq.CreateTextNode("7");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("finNFe", NFeNamespace);
            noText = XmlArq.CreateTextNode("1");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("indFinal", NFeNamespace);
            noText = XmlArq.CreateTextNode("1");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("indPres", NFeNamespace);
            noText = XmlArq.CreateTextNode("1");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            no = XmlArq.CreateElement("procEmi", NFeNamespace);
            noText = XmlArq.CreateTextNode("0");
            no.AppendChild(noText);
            noide.AppendChild(no);
            
            
            InserirNo(no, noide, "verProc", "4.539");
            
          //  no = XmlArq.CreateElement("verProc", NFeNamespace);
          //  noText = XmlArq.CreateTextNode("4.539");
          //  no.AppendChild(noText);
          //  noide.AppendChild(no);
            
            
            // *** Inclua os demais campos aqui ....

            // Hierarquia de nós
            noNFe = XmlArq.CreateElement("NFe", NFeNamespace);
            noNFe.AppendChild(noInfNFe);
            raiz.AppendChild(noNFe);

            XmlArq.AppendChild(raiz);
            XmlArq.PreserveWhitespace = true;
            XmlArq.Save("C:/Nfe.xml");
            return XmlArq;
        }
      } 
  }    
