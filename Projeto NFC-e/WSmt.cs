using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_NFC_e
{
    class WSmt
    {
       private XmlNode XmlEnvio;
       private string XmlRetorno;
                    
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
            string NumSerie = "79B1801522204BB8";
            foreach (X509Certificate2 cert in lcerts)
            {
                if (cert.SerialNumber == NumSerie)
                {
                    wsSer.ClientCertificates.Add(cert);
                    wsSer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                    XmlRetorno = wsSer.nfeConsultaNF2(XmlEnvio).OuterXml;

                }
                else
                {
                    MessageBox.Show("O Número de Série " + NumSerie + " não foi encontrado.");
                }
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
