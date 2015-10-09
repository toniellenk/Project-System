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
    public partial class FormNfe : Form
    {
        public FormNfe()
        {
            InitializeComponent();


        }


        private void countTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }

        private void cUFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            WSmt StatusServ = new WSmt();
            StatusServ.MontarXmlStatServ();
            XmlEnv.Text = StatusServ.XmlEnv();
            StatusServ.WsStatServ();
            RetSefaz.Text = StatusServ.XmlRet();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RetSefaz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButTest_Click(object sender, EventArgs e)
        {
            RetSefaz.Text = null;
            XmlEnv.Text = null;
        }

        private void RetSefaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void XmlEnv_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ButConsNfc_Click(object sender, EventArgs e)
        {
            WSmt ConsNfe = new WSmt();
            string chave = "5115107371514600019765065000003148112893003" + Convert.ToString(Funcoes.DigitoModulo11("5115107371514600019765065000003148112893003"));
        //    MessageBox.Show(chave);
            ConsNfe.MontarXmlConsSit(chave);
            ConsNfe.WsConsNfe();
            XmlEnv.Text = ConsNfe.XmlEnv();
            RetSefaz.Text = ConsNfe.XmlRet();
        }

        private void XmlEnv_Click_1(object sender, EventArgs e)
        {

        }

        private void RetSefaz_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MontarXmlNfe xml = new MontarXmlNfe();           
            WSmt ConsNfe = new WSmt();
            ConsNfe.AssinandoXML(xml.MontarXmlEnvNfe());
            ConsNfe.WsEnvNfe();
            XmlEnv.Text = ConsNfe.XmlEnv();
            RetSefaz.Text = ConsNfe.XmlRet();
        }

        private void ButMontNfe_Click(object sender, EventArgs e)
        {
            WSmt ConsNfe = new WSmt();
            ConsNfe.MontarXmlReciNFe("510000004862240");
            ConsNfe.WsRecNfe();
            XmlEnv.Text = ConsNfe.XmlEnv();
            RetSefaz.Text = ConsNfe.XmlRet();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormInicial Inicial = new FormInicial();
            Inicial.ShowDialog();
        }

        private void button1_Click_3(object sender, EventArgs e)

        {
            MontarXmlNfe xml = new MontarXmlNfe();
            WSmt ConsNfe = new WSmt();
            ConsNfe.AssinandoXML(xml.MontarXmlEnvNfe());
        }
    }
}
