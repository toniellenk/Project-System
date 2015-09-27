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
    public partial class FormInicial : Form
    {
        public FormInicial()
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
            ConsNfe.MontarXmlConsSit("51150973715146000197650650000030801125830025");
           // ConsNfe.MontarXmlConsSit(TxtChave.Text);
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
        }

        private void ButMontNfe_Click(object sender, EventArgs e)
        {
            MontarXmlNfe xml = new MontarXmlNfe();
            xml.MontarXmlEnvNfe();
        }
    }
}
