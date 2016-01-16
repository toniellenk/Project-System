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
        string Tipo, ItemSelect;
        FormCliente Teste1;

        public FormPesquisaSimples(FormCliente Form1, string Tipo)
        {
            InitializeComponent();
            Teste1 = Form1;
            this.Tipo = Tipo;
        }

        private void FormPesquisaSimples_Load(object sender, EventArgs e)
        {
            CarregarListView();

            this.FormClosing += new FormClosingEventHandler(FormPesquisaSimples_Closing);
          //  this.FormClosed += new FormClosedEventHandler(Inicio_FormClosed_1);

            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            comboSource.Add("1", "ID");
            comboSource.Add("2", "DESCRIÇÃO");

            CombBxFilt.DataSource = new BindingSource(comboSource, null);
            CombBxFilt.DisplayMember = "Value";
            CombBxFilt.ValueMember = "Key";

            CombBxFilt.SelectedIndex = CombBxFilt.FindStringExact("DESCRIÇÃO");
        }


        public void FormPesquisaSimples_Closing(object sender, FormClosingEventArgs e)
        {
            Teste1.TxtBxCidade.Text = LsVyPrinc.CurrentRow.Cells[0].Value.ToString();
        }

        public string RetornarSelecao() {
            
            return ItemSelect; 
        }

        private void PanFiltros_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CarregarListView()
        {
            ButNovo.Visible = true;
            ButAlterar.Visible = true;
            ButExcluir.Visible = true;

            LsVyPrinc.DataSource = Controles.CarregarGradeRapida("", Tipo);
            /*
            switch (Tipo){
                case "Cidade": {
                        LsVyPrinc.DataSource = Controles.CarregarGradeRapida("","Cidade");
                }
                case "Bairro": {
                        LsVyPrinc.DataSource = Controles.CarregarGradeRapida("","Bairro");
                }  
            }
            */
            LsVyPrinc.Columns[0].Width = 50;
            LsVyPrinc.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);

            LsVyPrinc.Visible = true;
            PanFiltros.Visible = true;
        }

        public void CarregarFiltros()
        {

            try
            {
                string key = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Key;
                string value = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Value;
                string where = null;
                switch (Tipo)
                {
                    case "Cidade":
                        {
                            switch (Convert.ToInt32(key))
                            {
                                case 1:
                                    {
                                        where = "t0030.IdCidade";
                                        break;
                                    }
                                case 2:
                                    {
                                        where = "t0030.Nome";
                                        break;
                                    }

                            }
                            break;
                        }
                    case "Bairro":
                        {
                            switch (Convert.ToInt32(key))
                            {
                                case 1:
                                    {
                                        where = "IdBairro";
                                        RadButContendo.Enabled = false;
                                        RadButIgual.Checked = true;
                                        break;
                                    }
                                case 2:
                                    {
                                        where = "Nome";
                                        break;
                                    }

                            }
                            break;
                        }
                }

                if ((RadButContendo.Checked) && (TxtBoxProcurar.Text != ""))
                    LsVyPrinc.DataSource = Controles.CarregarGradeRapida("where " + where + " like '%" + TxtBoxProcurar.Text + "%'", Tipo);

                if ((RadButIgual.Checked) && (TxtBoxProcurar.Text != ""))
                    LsVyPrinc.DataSource = Controles.CarregarGradeRapida("where " + where + " = '" + TxtBoxProcurar.Text + "'", Tipo);

                if (TxtBoxProcurar.Text == "")
                    LsVyPrinc.DataSource = Controles.CarregarGradeRapida("", Tipo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ao filtrar dados dados: " + ex.Message.ToString(), "Erro ao Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ButProcurar_Click(object sender, EventArgs e)
        {
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
    }
}
