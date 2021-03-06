﻿using System;
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
    //  public static string NFeNamespace, DataAtualXml, cUF, CNPJ, mod,serie, nNF, cNF, cDV;
      
      public static string  NFeNamespace = "http://www.portalfiscal.inf.br/nfe";
      public static string DataAtualXml = Funcoes.DataHoraAtual();
      public static string  cUF = "51";
      public static string  CNPJ = "73715146000197";
      public static string  mod = "55";
      public static string  serie = "65";
      public static string  nNF = "3148";
      public static string cNF = "12893003";
      public static string cDV = "7";

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

            XmlElement raiz, no, noNFe, noIde, noInfNFe, noEmit, noEnderEmit, 
                noDet, noProd, noImposto, noICMS, noPIS, noCOFINS, noICMS90,
                noPISAliq, noCOFINSAliq, noTotal, noICMSTot, noTransp, noPag, noInfAdic;
            XmlAttribute att;

            raiz = XmlArq.CreateElement("enviNFe", NFeNamespace);
            // Atributos do nó de enviNFe
            att = XmlArq.CreateAttribute("versao");
            att.Value = "3.10";
            raiz.Attributes.Append(att);

            no = XmlArq.CreateElement("idLote", NFeNamespace);
            noText = XmlArq.CreateTextNode("1219");
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
            att.Value = "NFe51151073715146000197650650000033461999999995";
            noInfNFe.Attributes.Append(att);

            att = XmlArq.CreateAttribute("versao");
            att.Value = "3.10";
            noInfNFe.Attributes.Append(att);
            
             // ide
            noIde = XmlArq.CreateElement("ide", NFeNamespace);
            noInfNFe.AppendChild(noIde);
            

            // Filhos do ide

            InserirNo( noIde, "cUF", "51");

            InserirNo( noIde, "cNF", "99999999");

            InserirNo(noIde, "natOp", "VENDAS MERCADORIAS");

            InserirNo( noIde, "indPag", "0");

            InserirNo( noIde, "mod", "65");

            InserirNo( noIde, "serie", "65");

            InserirNo( noIde, "nNF", "3346");

            InserirNo(noIde, "dhEmi", DataAtualXml);

            InserirNo( noIde, "tpNF", "1");

            InserirNo( noIde, "idDest", "1");

            InserirNo(noIde, "cMunFG", "5103403");

            InserirNo( noIde, "tpImp", "4");

            InserirNo( noIde, "tpEmis", "1");

            InserirNo( noIde, "cDV", "5");

            InserirNo(noIde, "tpAmb", "1");

            InserirNo( noIde, "finNFe", "1");

            InserirNo( noIde, "indFinal", "1");

            InserirNo( noIde, "indPres", "1");

            InserirNo( noIde, "procEmi", "0");                      
            
            InserirNo( noIde, "verProc", "4.539");
            
             // emit
            noEmit = XmlArq.CreateElement("emit", NFeNamespace);
            noInfNFe.AppendChild(noEmit);

            // filhos emit
            
            InserirNo( noEmit, "CNPJ", "73715146000197");
            
            InserirNo( noEmit, "xNome", "1 - BABY HOUSE COM BRINQ E UTILIDADES LTDA");

            InserirNo(noEmit, "xFant", "BABY DREAMS");
            
             // enderEmit
            noEnderEmit = XmlArq.CreateElement("enderEmit", NFeNamespace);
            noEmit.AppendChild(noEnderEmit);
            
            InserirNo( noEnderEmit, "xLgr", "RUA 24 DE OUTUBRO");
            
            InserirNo( noEnderEmit, "nro", "723");
            
            InserirNo( noEnderEmit, "xBairro", "BOSQUE");
            
            InserirNo( noEnderEmit, "cMun", "5103403");
            
            InserirNo( noEnderEmit, "xMun", "CUIABA");
            
            InserirNo( noEnderEmit, "UF", "MT");
            
            InserirNo( noEnderEmit, "CEP", "78045290");
            
            InserirNo( noEnderEmit, "cPais", "1058");
            
            InserirNo( noEnderEmit, "xPais", "BRASIL");
            
            InserirNo( noEnderEmit, "fone", "6533228570");
            
            InserirNo( noEmit, "IE", "131495453");
            
            InserirNo( noEmit, "CRT", "3");

            // det
            noDet = XmlArq.CreateElement("det", NFeNamespace);
            att = XmlArq.CreateAttribute("nItem");
            att.Value = "1";
            noDet.Attributes.Append(att);
            noInfNFe.AppendChild(noDet);

            // prod
            noProd = XmlArq.CreateElement("prod", NFeNamespace);
            noDet.AppendChild(noProd);

            // filhos prod
            InserirNo(noProd, "cProd", "8639");

            InserirNo(noProd, "cEAN", "");

            InserirNo(noProd, "xProd", "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL");

            InserirNo(noProd, "NCM", "61119090");

            InserirNo(noProd, "CFOP", "5102");

            InserirNo(noProd, "uCom", "PC");

            InserirNo(noProd, "qCom", "1");

            InserirNo(noProd, "vUnCom", "46.31");

            InserirNo(noProd, "vProd", "46.31");

            InserirNo(noProd, "cEANTrib", "");

            InserirNo(noProd, "uTrib", "PC");

            InserirNo(noProd, "qTrib", "1");

            InserirNo(noProd, "vUnTrib", "46.31");

            InserirNo(noProd, "vDesc", "1.86");

            InserirNo(noProd, "indTot", "1");

            // imposto
            noImposto = XmlArq.CreateElement("imposto", NFeNamespace);
            noDet.AppendChild(noImposto);

            // ICMS
            noICMS = XmlArq.CreateElement("ICMS", NFeNamespace);
            noImposto.AppendChild(noICMS);

            // ICMS90
            noICMS90 = XmlArq.CreateElement("ICMS90", NFeNamespace);
            noICMS.AppendChild(noICMS90);
          
            // filhos ICMS90
            InserirNo(noICMS90, "orig", "0");

            InserirNo(noICMS90, "CST", "90");

            // PIS
            noPIS = XmlArq.CreateElement("PIS", NFeNamespace);
            noImposto.AppendChild(noPIS);

            // PISAliq
            noPISAliq = XmlArq.CreateElement("PISAliq", NFeNamespace);
            noPIS.AppendChild(noPISAliq);

            // filhos PISAliq
            InserirNo(noPISAliq, "CST", "01");

            InserirNo(noPISAliq, "vBC", "44.45");

            InserirNo(noPISAliq, "pPIS", "0.65");

            InserirNo(noPISAliq, "vPIS", "0.29");  

            // COFINS
            noCOFINS = XmlArq.CreateElement("COFINS", NFeNamespace);
            noImposto.AppendChild(noCOFINS);

            // COFINSAliq
            noCOFINSAliq = XmlArq.CreateElement("COFINSAliq", NFeNamespace);
            noCOFINS.AppendChild(noCOFINSAliq);

            // filhos COFINSAliq
            InserirNo(noCOFINSAliq, "CST", "01");

            InserirNo(noCOFINSAliq, "vBC", "44.45");

            InserirNo(noCOFINSAliq, "pCOFINS", "3.00");

            InserirNo(noCOFINSAliq, "vCOFINS", "1.33");

            // total
            noTotal = XmlArq.CreateElement("total", NFeNamespace);
            noInfNFe.AppendChild(noTotal);

            // ICMSTot
            noICMSTot = XmlArq.CreateElement("ICMSTot", NFeNamespace);
            noTotal.AppendChild(noICMSTot);

            // filhos ICMSTot
            InserirNo(noICMSTot, "vBC", "0");
            
            InserirNo(noICMSTot, "vICMS", "0");
            
            InserirNo(noICMSTot, "vICMSDeson", "0");
            
            InserirNo(noICMSTot, "vBCST", "0");
            
            InserirNo(noICMSTot, "vST", "0");
            
            InserirNo(noICMSTot, "vProd", "46.31");
            
            InserirNo(noICMSTot, "vFrete", "0");
            
            InserirNo(noICMSTot, "vSeg", "0");
            
            InserirNo(noICMSTot, "vDesc", "1.86");
            
            InserirNo(noICMSTot, "vII", "0");
            
            InserirNo(noICMSTot, "vIPI", "0");
            
            InserirNo(noICMSTot, "vPIS", "0.29");
            
            InserirNo(noICMSTot, "vCOFINS", "1.33");
            
            InserirNo(noICMSTot, "vOutro", "0");
            
            InserirNo(noICMSTot, "vNF", "44.45");
            
            // transp
            noTransp = XmlArq.CreateElement("transp", NFeNamespace);
            noInfNFe.AppendChild(noTransp);
            
            InserirNo(noTransp, "modFrete", "9");
            
            // pag
            noPag = XmlArq.CreateElement("pag", NFeNamespace);
            noInfNFe.AppendChild(noPag);
            
            InserirNo(noPag, "tPag", "99");
            
            InserirNo(noPag, "vPag", "44.45");
            
            // infAdic
            noInfAdic = XmlArq.CreateElement("infAdic", NFeNamespace);
            noInfNFe.AppendChild(noInfAdic);
            
            InserirNo(noInfAdic, "infCpl", "TESTE EMISSAO NFC-E AMBIENTE DE HOMOLOGACAO");

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
