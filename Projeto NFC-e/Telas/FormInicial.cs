using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Projeto_NFC_e
{
    public partial class FormInicial : Form
    {

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        int TipoButNv, TipoButAlt, TipoButDel;

        public FormInicial()
        {
            InitializeComponent();
            LsVyPrinc.Visible = false;
            BuNvCliente.Visible = false;
            ButAltCliente.Visible = false;
            ButDelCliente.Visible = false;
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void nFeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nFeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNfe NFE = new FormNfe();
            NFE.ShowDialog();
        }

        private void MenuInicial_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saldoProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
         public void produtosToolStripMenuItem_Click(object sender, EventArgs e){
             
             
         } 
        
        public void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuNvCliente.Visible = true;
            ButAltCliente.Visible = true;
            ButDelCliente.Visible = true;
            TipoButNv = Controles.BotaoNv.NvCliente();
            TipoButDel = Controles.BotaoAlt.AltCliente();
            TipoButAlt = Controles.BotaoAlt.AltCliente();
          //  TipoGrade = Controles.TipoGrade.GradeCliente(); 

            Dictionary<string,string> comboSource = new Dictionary<string,string>();
            comboSource.Add("1", "Sunday");
            comboSource.Add("2", "Monday");
            comboSource.Add("3", "Tuesday");
            comboSource.Add("4", "Wednesday");
            comboSource.Add("5", "Thursday");
            comboSource.Add("6", "Friday");
            comboSource.Add("7", "Saturday");
            CombBxFilt.DataSource = new BindingSource(comboSource, null);
            CombBxFilt.DisplayMember = "Value";
            CombBxFilt.ValueMember = "Key";
 

                //   CombBxFilt.SelectedIndex = CombBxFilt.FindStringExact("Sunday");

 
        }

        private void ButNovo_Click(object sender, EventArgs e)
        {
            Controles.Novo(TipoButNv);
        }

        private void ListViewPinc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Métodos
         private void CarregarListViewClientes() 
        {

            LsVyPrinc.DataSource = Controles.CarregarGradeClientes();
            LsVyPrinc.Columns[0].Width = 30;
            LsVyPrinc.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            LsVyPrinc.Visible = true;

        }
        #endregion

         private void LsVyPrinc_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
         {

         }

         private void LsVyPrinc_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void ButAltCliente_Click(object sender, EventArgs e)
         {
             int ItemSelect = Convert.ToInt32(LsVyPrinc.CurrentRow.Cells[0].Value.ToString());
             Controles.Alterar(TipoButAlt, ItemSelect);
         }

         private void ButDelCliente_Click(object sender, EventArgs e)
         {
             int ItemSelect = Convert.ToInt32(LsVyPrinc.CurrentRow.Cells[0].Value.ToString());
             Controles.Remover(TipoButDel, ItemSelect);

         }

         private void PanCentral_Paint(object sender, PaintEventArgs e)
         {

         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }

         private void button1_Click(object sender, EventArgs e)
         {
             string key = ((KeyValuePair<string,string>)CombBxFilt.SelectedItem).Key;
             string value = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Value;
             MessageBox.Show(key + "   " + value);
         }

    }
}
