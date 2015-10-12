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
using System.IO;


namespace Projeto_NFC_e
{
    class WSmt
    {
       private XmlNode XmlEnvio;
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

        public void MontarXmlReciNFe(string Recibo)
        {
            string WSstats = null;
            XmlEnvio = null;
            WSstats = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";
            WSstats += "<consReciNFe xmlns=\"http://www.portalfiscal.inf.br/nfe\" versao=\"3.10\">";
            WSstats += "<tpAmb>1</tpAmb>";
            WSstats += "<nRec>" + Recibo + "</nRec>";
            WSstats += "</consReciNFe>";

            System.Xml.XmlDocument XmlArq = new System.Xml.XmlDocument();
            XmlArq.PreserveWhitespace = true;
            XmlArq.LoadXml(WSstats);
            XmlArq.Save("C:/teste.xml");
            XmlEnvio = XmlArq.DocumentElement;
        }

        public XmlDocument MontarXmlCacNFe()
        {
            string WSstats = null;
            XmlEnvio = null;
            WSstats = "<envEvento xmlns=\"http://www.portalfiscal.inf.br/nfe\" versao=\"1.00\">";
            WSstats += "<idLote>99999</idLote>";
            WSstats += "<evento versao=\"1.00\">";
            WSstats += "<infEvento Id=\"ID1101115115107371514600019765065000003346199999999501\">";
            WSstats += "<cOrgao>51</cOrgao>";
            WSstats += "<tpAmb>1</tpAmb>";
            WSstats += "<CNPJ>73715146000197</CNPJ>";
            WSstats += "<chNFe>51151073715146000197650650000033461999999995</chNFe>";
            WSstats += "<dhEvento>2015-10-10T17:54:51-04:00</dhEvento>";
            WSstats += "<tpEvento>110111</tpEvento>";
            WSstats += "<nSeqEvento>1</nSeqEvento>";
            WSstats += "<verEvento>1.00</verEvento>";
            WSstats += "<detEvento versao=\"1.00\">";
            WSstats += "<descEvento>Cancelamento</descEvento>";
            WSstats += "<nProt>151150220567771</nProt>";
            WSstats += "<xJust>***************************</xJust>";
            WSstats += "</detEvento>";
            WSstats += "</infEvento>";
            WSstats += "</evento>";
            WSstats += "</envEvento>";

            System.Xml.XmlDocument XmlArq = new System.Xml.XmlDocument();
            XmlArq.PreserveWhitespace = true;
            XmlArq.LoadXml(WSstats);
            XmlArq.Save("C:/teste.xml");
            return XmlArq;
        }

        public void AssinandoXMLCanc(XmlDocument XmlCanc)
        {

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

                XmlNodeList ListInfNFe = XmlCanc.GetElementsByTagName("infEvento");

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

                    XmlElement xmlSignature = XmlCanc.CreateElement("Signature", "http://www.w3.org/2000/09/xmldsig#");
                    XmlElement xmlSignedInfo = signedXml.SignedInfo.GetXml();
                    XmlElement xmlKeyInfo = signedXml.KeyInfo.GetXml();

                    xmlSignature.AppendChild(XmlCanc.ImportNode(xmlSignedInfo, true));
                    XmlElement xmlSignatureValue = XmlCanc.CreateElement("SignatureValue", xmlSignature.NamespaceURI);
                    string signBase64 = Convert.ToBase64String(signedXml.Signature.SignatureValue);
                    XmlText text = XmlCanc.CreateTextNode(signBase64);
                    xmlSignatureValue.AppendChild(text);
                    xmlSignature.AppendChild(xmlSignatureValue);
                    xmlSignature.AppendChild(XmlCanc.ImportNode(xmlKeyInfo, true));

                    var evento = XmlCanc.GetElementsByTagName("evento");

                    //Fixando tag Signature
                    evento[0].AppendChild(xmlSignature);

                    // Create an XML declaration. 
                    XmlDeclaration xmldecl;
                    xmldecl = XmlCanc.CreateXmlDeclaration("1.00", null, null);
                    xmldecl.Encoding = "UTF-8";

                    // Add the new node to the document.
                    XmlElement root = XmlCanc.DocumentElement;
                    XmlCanc.InsertBefore(xmldecl, root);

                    // Salvando XML
                    XmlCanc.Save("C:/NfeCancAssinado.xml");
                    XmlEnvio = XmlCanc.DocumentElement;

                }
            }
            else
            {
                MessageBox.Show("O Certificado com o Número de Série " + NumSerie + " não foi encontrado.");
            }

            lStore.Close();
        }

        public void WsEnvCancNfe()
        {
            CancNfe.RecepcaoEvento wsSer = new CancNfe.RecepcaoEvento();
            CancNfe.nfeCabecMsg wsCab = new CancNfe.nfeCabecMsg();
            wsCab.cUF = "51";
            wsCab.versaoDados = "1.00";
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
                    XmlRetorno = wsSer.nfeRecepcaoEvento(XmlEnvio).OuterXml;

                }
                else
                {
                    MessageBox.Show("O Número de Série " + NumSerie + " não foi encontrado.");
                }
            }

            lStore.Close();

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

        public void WsRecNfe()
        {
            RecNfe.NfeRetAutorizacao wsSer = new RecNfe.NfeRetAutorizacao();
            RecNfe.nfeCabecMsg wsCab = new RecNfe.nfeCabecMsg();

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
            if (LocCert)
            {
                wsSer.ClientCertificates.Add(cert);
                wsSer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                XmlRetorno = wsSer.nfeRetAutorizacaoLote(XmlEnvio).OuterXml;
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

         public void WsEnvNfe()
         {
             EnvNfe.NfeAutorizacao wsSer = new EnvNfe.NfeAutorizacao();
             EnvNfe.nfeCabecMsg wsCab = new EnvNfe.nfeCabecMsg();
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
                     XmlRetorno = wsSer.nfeAutorizacaoLote(XmlEnvio).OuterXml;

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

                    // infNFeSupl
                    var Vet = xmlSignedInfo.GetElementsByTagName("DigestValue");
                    string token;
                    string infNFeSupl = Vet[0].InnerText;
                //    MessageBox.Show(DigestValue);
                    XmlElement noinfNFeSupl = XmlNfe.CreateElement("infNFeSupl", "http://www.portalfiscal.inf.br/nfe");
                    XmlElement qrCode = XmlNfe.CreateElement("qrCode", "http://www.portalfiscal.inf.br/nfe");

                    token = "chNFe=51151073715146000197650650000031481128930037";
                    token += "&nVersao=100";
                    token += "&tpAmb=1";
                //    token += "&cDest=99999999000191";
                    token += "&dhEmi=" + Funcoes.ConvertHexa(MontarXmlNfe.DataAtualXml);
                    token += "&vNF=44.45&vICMS=0.00";
                    token += "&digVal=" + Funcoes.ConvertHexa(infNFeSupl);
                    token += "&cIdToken=000001";
                    string TokenSemRach = token;
                    token += "&cHashQRCode=e0be0fbae4020860f5a695b4cd7e2cc9";

                  //  MessageBox.Show(token);
                    string Rach = Funcoes.generateHasg(token);

            
                    string tokenCompleto = "<![CDATA[" + "http://www.sefaz.mt.gov.br/nfce/consultanfce?" + TokenSemRach + '&'+"cHashQRCode=" + Rach + "]]>";

                    
                    XmlText noText;
                    noText = XmlNfe.CreateTextNode(tokenCompleto);
                    qrCode.AppendChild(noText);
                    noinfNFeSupl.AppendChild(qrCode);
                    
                    
                    var evento = XmlNfe.GetElementsByTagName("NFe");

                    //Fixando tag infNFeSupl
                  //  evento[0].AppendChild(noinfNFeSupl);

                    //Fixando tag Signature
                    evento[0].AppendChild(xmlSignature);

                    // Create an XML declaration. 
                    XmlDeclaration xmldecl;
                    xmldecl = XmlNfe.CreateXmlDeclaration("1.0", null, null);
                    xmldecl.Encoding = "UTF-8";

                    // Add the new node to the document.
                    XmlElement root = XmlNfe.DocumentElement;
                    XmlNfe.InsertBefore(xmldecl, root);
    
                    // Salvando XML
                    XmlNfe.Save("C:/NfeAssinado.xml");
                    XmlEnvio = XmlNfe.DocumentElement;

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
