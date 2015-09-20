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
    class WSmt
    {
       private XmlNode XmlEnvio;
       private string XmlRetorno;
       X509Certificate2 cert;
       static string NFeNamespace = "http://www.portalfiscal.inf.br/nfe";
                    
        public void MontarXmlStatServ(){    
            string WSstats = null;
            XmlEnvio = null;
            WSstats = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";
            WSstats += "<consStatServ xmlns=\"http://www.portalfiscal.inf.br/nfe\" versao=\"3.10\" >"; 
            WSstats += "<tpAmb>1</tpAmb>";
            WSstats += "<cUF>51</cUF>";
            WSstats += "<xServ>STATUS</xServ>";
            WSstats += "</consStatServ>";

            System.Xml.XmlDocument XmlArq = new System.Xml.XmlDocument();
            XmlArq.PreserveWhitespace = true;
            XmlArq.LoadXml(WSstats);
            XmlEnvio = XmlArq.DocumentElement;
        }

        public XmlDocument MontarXmlEnvNfe()
        {
 
            XmlDocument XmlArq = new XmlDocument();

            XmlElement raiz, no, noNFe, noInfNFe;
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
            att.Value = "NFe3508059978";
            noInfNFe.Attributes.Append(att);

            att = XmlArq.CreateAttribute("versao");
            att.Value = "3.10";
            noInfNFe.Attributes.Append(att);

            // Filhos do infNFE
            no = XmlArq.CreateElement("cUF", NFeNamespace);
            noText = XmlArq.CreateTextNode("51");
            no.AppendChild(noText);
            noInfNFe.AppendChild(no);

            no = XmlArq.CreateElement("cNF", NFeNamespace);
            noText = XmlArq.CreateTextNode("518005127");
            no.AppendChild(noText);
            noInfNFe.AppendChild(no);

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
        

        public void MontarXmlConsSit(string ChaveNfe){    
            string WSstats = null;
            XmlEnvio = null;
            WSstats = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";
            WSstats += "<consSitNFe xmlns=\"http://www.portalfiscal.inf.br/nfe\" versao=\"3.10\">";
            WSstats += "<tpAmb>1</tpAmb>";
            WSstats += "<xServ>CONSULTAR</xServ>";
            WSstats += "<chNFe>"+ChaveNfe+"</chNFe>";
            WSstats += "</consSitNFe>";

            System.Xml.XmlDocument XmlArq = new System.Xml.XmlDocument();
            XmlArq.PreserveWhitespace = true;
            XmlArq.LoadXml(WSstats);
            XmlArq.Save("C:/teste.xml");
            XmlEnvio = XmlArq.DocumentElement;
        }
         
        public void WsConsNfe()
        {
            ConsNfe.NfeConsulta2 wsSer = new ConsNfe.NfeConsulta2();
            ConsNfe.nfeCabecMsg wsCab = new ConsNfe.nfeCabecMsg();

            wsCab.cUF = "51";
            wsCab.versaoDados = "3.10";
            wsSer.nfeCabecMsgValue = wsCab;


            X509Certificate2Collection lcerts;
            X509Store lStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);

            // Abre o Store
            lStore.Open(OpenFlags.OpenExistingOnly);

            // Lista os certificados
            lcerts = lStore.Certificates;
            bool LocCert = false;
            string NumSerie = "79B1801522204BB8";
            
            foreach (X509Certificate2 tpcert in lcerts)
            {
                if (tpcert.SerialNumber == NumSerie)
                {
                    cert = tpcert;
                    LocCert = true;
                }
            }    
            if  (LocCert) {
                    wsSer.ClientCertificates.Add(cert);
                    wsSer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                    XmlRetorno = wsSer.nfeConsultaNF2(XmlEnvio).OuterXml;
                    }
            else
                {
                    MessageBox.Show("O Certificado com o Número de Série " + NumSerie + " não foi encontrado.");
                }
                     
            lStore.Close();
        }
        
         public void WsStatServ()
        
        {
            StatServ.NfeStatusServico2 wsSer = new StatServ.NfeStatusServico2();
            StatServ.nfeCabecMsg wsCab = new StatServ.nfeCabecMsg();
            wsCab.cUF = "51";
            wsCab.versaoDados = "3.10";
            wsSer.nfeCabecMsgValue = wsCab;


            X509Certificate2Collection lcerts;
            X509Store lStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);

            // Abre o Store
            lStore.Open(OpenFlags.OpenExistingOnly);

            // Lista os certificados
            lcerts = lStore.Certificates;
            string NumSerie = "79B1801522204BB8";
            foreach (X509Certificate2 cert in lcerts)
            {
                if (cert.SerialNumber == NumSerie)
                {
                    wsSer.ClientCertificates.Add(cert);
                    XmlRetorno = wsSer.nfeStatusServicoNF2(XmlEnvio).OuterXml;

                }
                else
                {
                    MessageBox.Show("O Número de Série " + NumSerie + " não foi encontrado.");
                }
            }

            lStore.Close();      
        
        }

        public void AssinandoXML(XmlDocument XmlNfe){

            X509Certificate2Collection lcerts;
            X509Store lStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);

            // Abre o Store
            lStore.Open(OpenFlags.OpenExistingOnly);

            // Lista os certificados
            lcerts = lStore.Certificates;
            bool LocCert = false;
            string NumSerie = "79B1801522204BB8";

            foreach (X509Certificate2 tpcert in lcerts)
            {
                if (tpcert.SerialNumber == NumSerie)
                {
                    cert = tpcert;
                    LocCert = true;
                }
            }
            if (LocCert)
            {
                XmlNodeList ListInfNFe = XmlNfe.GetElementsByTagName("infNFe");

                foreach (XmlElement infNFe in ListInfNFe)
                {
                    string id = infNFe.Attributes.GetNamedItem("Id").Value;
                    SignedXml signedXml = new SignedXml(infNFe);
                    signedXml.SigningKey = cert.PrivateKey;

                    // Transformações p/ DigestValue da Nota
                    Reference reference = new Reference("#" + id);
                    reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                    reference.AddTransform(new XmlDsigC14NTransform());
                    signedXml.AddReference(reference);

                    KeyInfo keyInfo = new KeyInfo();
                    keyInfo.AddClause(new KeyInfoX509Data(cert));
                    signedXml.KeyInfo = keyInfo;

                    signedXml.ComputeSignature();

                 //   XmlDocument Doc = new XmlDocument();
                    XmlElement xmlSignature = XmlNfe.CreateElement("Signature", "http://www.w3.org/2000/09/xmldsig#");
                    XmlElement xmlSignedInfo = signedXml.SignedInfo.GetXml();
                    XmlElement xmlKeyInfo = signedXml.KeyInfo.GetXml();

                    xmlSignature.AppendChild(XmlNfe.ImportNode(xmlSignedInfo, true));
                    XmlElement xmlSignatureValue = XmlNfe.CreateElement("SignatureValue", xmlSignature.NamespaceURI);
                    string signBase64 = Convert.ToBase64String(signedXml.Signature.SignatureValue);
                    XmlText text = XmlNfe.CreateTextNode(signBase64);
                    xmlSignatureValue.AppendChild(text);
                    xmlSignature.AppendChild(xmlSignatureValue);


                    xmlSignature.AppendChild(XmlNfe.ImportNode(xmlKeyInfo, true));
                  //  XmlNfe.AppendChild(xmlSignature);
                    var evento = XmlNfe.GetElementsByTagName("NFe");
                    evento[0].AppendChild(xmlSignature);
                    XmlNfe.Save("C:/NfeAssinado.xml");
                }
       
            }
            else
            {
                MessageBox.Show("O Certificado com o Número de Série " + NumSerie + " não foi encontrado.");
            }

            lStore.Close();

            
        }

        public string XmlEnv()
        {
            return XmlEnvio.OuterXml;
        }

        public string XmlRet()
        {
             return XmlRetorno;
        }
    }

}
