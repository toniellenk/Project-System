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
             
             try
             {
                 string key = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Key;
                 string value = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Value;
                 string where = null;
                 switch (TipoFilt)
                 {
                     case 1:
                         {
                             switch (Convert.ToInt32(key))
                             {
                                 case 0:
                                     {
                                         where = "IdCliente";
                                         RadButContendo.Enabled = false;
                                         RadButIgual.Checked = true;
                                         break;
                                     }
                                 case 1:
                                     {
                                         where = "Nome";
                                         break;
                                     }
                                 case 2:
                                     {
                                         where = "CpfCnpj";
                                         break;
                                     }
                                 case 3:
                                     {
                                         where = "FoneRes";
                                         break;
                                     }
                                 case 4:
                                     {
                                         where = "Cel";
                                         break;
                                     }
                                 case 5:
                                     {
                                         where = "Email";
                                         break;
                                     }

                             }
                             if ((RadButContendo.Checked) && (TxtBoxProcurar.Text != ""))
                                 LsVyPrinc.DataSource = Controles.CarregarGradeClientes(" where " + where + " like '%" + TxtBoxProcurar.Text + "%'");

                             if ((RadButIgual.Checked) && (TxtBoxProcurar.Text != ""))
                                 LsVyPrinc.DataSource = Controles.CarregarGradeClientes(" where " + where + " = '" + TxtBoxProcurar.Text + "'");

                             if (TxtBoxProcurar.Text == "")
                                 LsVyPrinc.DataSource = Controles.CarregarGradeClientes("");
                        break;
                         }
                     case 2:
                         {
                             switch (Convert.ToInt32(key))
                             {
                                 case 0:
                                     {
                                         where = "IdProd";
                                         RadButContendo.Enabled = false;
                                         RadButIgual.Checked = true;
                                         break;
                                     }
                                 case 1:
                                     {
                                         where = "Nome";
                                         break;
                                     }
                                 case 2:
                                     {
                                         where = "[Desc]";
                                         break;
                                     }
                                 case 3:
                                     {
                                         where = "GrupItens";
                                         break;
                                     }
                                 case 4:
                                     {
                                         where = "UnMed";
                                         break;
                                     }
                                 case 5:
                                     {
                                         where = "Natureza";
                                         break;
                                     }

                             }
                             if ((RadButContendo.Checked) && (TxtBoxProcurar.Text != ""))
                                 LsVyPrinc.DataSource = Controles.CarregarGradeProdutos(" where " + where + " like '%" + TxtBoxProcurar.Text + "%'");

                             if ((RadButIgual.Checked) && (TxtBoxProcurar.Text != ""))
                                 LsVyPrinc.DataSource = Controles.CarregarGradeProdutos(" where " + where + " = '" + TxtBoxProcurar.Text + "'");

                             if (TxtBoxProcurar.Text == "")
                                 LsVyPrinc.DataSource = Controles.CarregarGradeProdutos("");
                             break;
                         }
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show("Ao filtrar dados dados: " + ex.Message.ToString(), "Erro ao Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
         }
        
    }
}
