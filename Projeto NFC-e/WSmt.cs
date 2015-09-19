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
       private XmlDocument XmlNfe;
       private string XmlRetorno;
       X509Certificate2 cert;
                    
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

        public void MontarXmlEnvNfe()
        {
            string WSstats = null;
            XmlEnvio = null;
            WSstats = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";
            WSstats += "<EnvNfe xmlns=\"http://www.portalfiscal.inf.br/nfe\" versao=\"3.10\" >";
            WSstats += "<infNFe Id=\"NFe3508059978\" versao=\"3.10\">";
            WSstats += "<cUF>51</cUF>";
            WSstats += "<cNF>518005127</cNF>";
            WSstats += "<natOp>Venda a vista</natOp>";
            WSstats += "<mod>65</mod>";
            WSstats += "<serie>1</serie>";
            WSstats += "<dEmi>2008-05-06</dEmi>";
            WSstats += "<tpAmb>2</tpAmb>";
            WSstats += "</infNFe>";
            WSstats += "</EnvNfe>";

            System.Xml.XmlDocument XmlArq = new System.Xml.XmlDocument();
            XmlArq.PreserveWhitespace = true;
            XmlArq.LoadXml(WSstats);
            XmlArq.Save("C:/nfe.xml");
            XmlNfe = XmlArq;
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

        public void AssinandoXML(){

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

                    XmlDocument Doc = new XmlDocument();
                    XmlElement xmlSignature = Doc.CreateElement("Signature", "http://www.w3.org/2000/09/xmldsig#");
                    XmlElement xmlSignedInfo = signedXml.SignedInfo.GetXml();
                    XmlElement xmlKeyInfo = signedXml.KeyInfo.GetXml();


                    XmlElement xmlSignatureValue = Doc.CreateElement("SignatureValue", xmlSignature.NamespaceURI);
                    string signBase64 = Convert.ToBase64String(signedXml.Signature.SignatureValue);
                    XmlText text = Doc.CreateTextNode(signBase64);
                    xmlSignatureValue.AppendChild(text);
                    xmlSignature.AppendChild(xmlSignatureValue);

                    xmlSignature.AppendChild(Doc.ImportNode(xmlSignedInfo, true));
                    xmlSignature.AppendChild(Doc.ImportNode(xmlKeyInfo, true));
                  //  XmlNfe.AppendChild(xmlSignature);
                    var evento = XmlNfe.GetElementsByTagName("EnvNfe");
                    evento[0].AppendChild(xmlSignature);
                    XmlNfe.Save("C:/nfe.xml");
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
