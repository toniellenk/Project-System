using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public partial class FormPesquisaSimples : Form
    {
        public FormCliente SecaoFormCliente;
        public FormPdVenda SecaoFormPdVenda;
        public string Tipo, Procura, CampoId, CampoDesc;
        string key = "2";
        string value = "";
        bool TemProcura = false;
        public int TipoProcura = 2;

        public FormPesquisaSimples()
        {
            InitializeComponent();
        }


        public FormPesquisaSimples(FormCliente Form)
        {
            InitializeComponent();
            SecaoFormCliente = Form;
        }

        public FormPesquisaSimples(FormPdVenda Form)
        {
            InitializeComponent();
            SecaoFormPdVenda = Form;
        }

        private void FormPesquisaSimples_Load(object sender, EventArgs e)
        {
            CarregarListView();

          //  this.FormClosing += new FormClosingEventHandler(FormPesquisaSimples_Closing);
            this.LsVyPrinc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDataGridView_CellContentDoubleClick); 

          //  this.FormClosed += new FormClosedEventHandler(Inicio_FormClosed_1);

            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            comboSource.Add("1", "ID");
            comboSource.Add("2", "DESCRIÇÃO");

            CombBxFilt.DataSource = new BindingSource(comboSource, null);
            CombBxFilt.DisplayMember = "Value";
            CombBxFilt.ValueMember = "Key";

            CombBxFilt.SelectedIndex = CombBxFilt.FindStringExact("DESCRIÇÃO");
        }

        public void roomDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarFormBase();
            this.Close();
        }


        private void PanFiltros_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void CarregarFormBase()
        {

        }

        public void CarregarListView()
        {
            try
            {
                ButNovo.Visible = true;
                ButAlterar.Visible = true;
                ButExcluir.Visible = true;


                Procura.Trim();
                if (Procura != "" && TipoProcura == 2) { TemProcura = true; TxtBoxProcurar.Text = Procura; RadButContendo.Checked = true; key = "2"; CarregarFiltros(); }
                if (Procura != "" && TipoProcura == 1) { TemProcura = true; TxtBoxProcurar.Text = Procura; RadButIgual.Checked = true; key = "1"; CarregarFiltros(); }
                if (Procura == "") LsVyPrinc.DataSource = Controles.CarregarGradeRapida("", Tipo);

                LsVyPrinc.Columns[0].Width = 50;
                LsVyPrinc.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);

                LsVyPrinc.Visible = true;
                PanFiltros.Visible = true;
            }
            catch (Exception ex) {
                MessageBox.Show("Não Foi possível realizar consulta pelo seguinte motivo: " + ex.Message.ToString(), "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        public void CarregarFiltros()
        {


                if (TemProcura == false)
                {
                    key = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Key;
                    value = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Value;
                }
                string where = null;
                switch (Convert.ToInt32(key))
                            {
                                case 1:
                                    {
                                        where = CampoId;
                                        RadButContendo.Enabled = false;
                                        RadButIgual.Checked = true;
                                        break;
                                    }
                                case 2:
                                    {
                                        where = CampoDesc;
                                        break;
                                    }
                            }
                            
                
                if ((RadButContendo.Checked) && (TxtBoxProcurar.Text != ""))
                    LsVyPrinc.DataSource = Controles.CarregarGradeRapida("where " + where + " like '%" + Procura + "%'", Tipo);

                if ((RadButIgual.Checked) && (TxtBoxProcurar.Text != ""))
                    LsVyPrinc.DataSource = Controles.CarregarGradeRapida("where " + where + " = '" + Convert.ToInt32(Procura) + "'", Tipo);

                if (TxtBoxProcurar.Text == "")
                    LsVyPrinc.DataSource = Controles.CarregarGradeRapida("", Tipo);
                TemProcura = false;

            }

        private void ButProcurar_Click(object sender, EventArgs e)
        {
            Procura = TxtBoxProcurar.Text;
            CarregarFiltros();
        }

        private void RadButIgual_CheckedChanged(object sender, EventArgs e)
        {

        }

           private void CombBxFilt_SelectedIndexChanged(object sender, EventArgs e)
            {
                string key = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Key;
                switch (Convert.ToInt32(key))
                                   {
                                       case 1:
                                           {
                                               RadButContendo.Enabled = false;
                                               RadButIgual.Checked = true;
                                               break;
                                           }
                                       case 2:
                                           {
                                               RadButContendo.Enabled = true;
                                               RadButContendo.Checked = true;
                                               break;
                                           }              
                                  }
        
          }

           private void button1_Click(object sender, EventArgs e)
           {
               CarregarFormBase();
               this.Close();
           }

           private void ButCancelar_Click(object sender, EventArgs e)
           {
               this.Close();
           }

           private void ButNovo_Click(object sender, EventArgs e)
           {

           } 
    }
}
