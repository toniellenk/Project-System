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
        string Tipo;

        public FormPesquisaSimples(string Tipo)
        {
            InitializeComponent();
            this.Tipo = Tipo;
        }

        private void FormPesquisaSimples_Load(object sender, EventArgs e)
        {
            CarregarListView();

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
   
            comboSource.Add("1", "ID");
            comboSource.Add("2", "DESCRIÇÃO");

            CombBxFilt.DataSource = new BindingSource(comboSource, null);
            CombBxFilt.DisplayMember = "Value";
            CombBxFilt.ValueMember = "Key";

            CombBxFilt.SelectedIndex = CombBxFilt.FindStringExact("DESCRIÇÃO");
        }

        private void PanFiltros_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CarregarListView()
        {
            ButNovo.Visible = true;
            ButAlterar.Visible = true;
            ButExcluir.Visible = true;
            
            LsVyPrinc.DataSource = Controles.CarregarGradeRapida("",Tipo);
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
            LsVyPrinc.Columns[0].Width = 30;
            LsVyPrinc.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);

            LsVyPrinc.Visible = true;
            PanFiltros.Visible = true;
        }
        
      public void CarregarFiltros()
         {
             
 //            try
  //           {
                 string key = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Key;
                 string value = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Value;
                 string where = null;
                 switch (Tipo)
                 {
                     case "Cidade":
                         {
                             switch (Convert.ToInt32(key))
                             {
                                 case 0:
                                     {
                                         where = "IdCidade";
                                         RadButContendo.Enabled = false;
                                         RadButIgual.Checked = true;
                                         break;
                                     }
                                 case 1:
                                     {
                                         where = "Nome";
                                         break;
                                     }                                

                             }
                             break;
                         }
                     case "Bairro":
                         {
                             switch (Convert.ToInt32(key))
                             {
                                 case 0:
                                     {
                                         where = "IdBairro";
                                         RadButContendo.Enabled = false;
                                         RadButIgual.Checked = true;
                                         break;
                                     }
                                 case 1:
                                     {
                                         where = "Nome";
                                         break;
                                     }

                             }
                             break;
                         }
                 }

                 if ((RadButContendo.Checked) && (TxtBoxProcurar.Text != ""))
                     LsVyPrinc.DataSource = Controles.CarregarGradeRapida(" where " + where + " like '%" + TxtBoxProcurar.Text + "%'", Tipo);

                 if ((RadButIgual.Checked) && (TxtBoxProcurar.Text != ""))
                     LsVyPrinc.DataSource = Controles.CarregarGradeRapida(" where " + where + " = '" + TxtBoxProcurar.Text + "'", Tipo);

                 if (TxtBoxProcurar.Text == "")
                     LsVyPrinc.DataSource = Controles.CarregarGradeRapida("", Tipo);

        //     }
       //      catch (Exception ex)
        //     {
        //         MessageBox.Show("Ao filtrar dados dados: " + ex.Message.ToString(), "Erro ao Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

       //      }
         }

      private void ButProcurar_Click(object sender, EventArgs e)
      {
          CarregarFiltros();
      }
        
    }
}
