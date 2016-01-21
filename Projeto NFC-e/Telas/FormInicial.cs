using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace Projeto_NFC_e
{
    public partial class FormInicial : Form
    {

        int TipoButNv, TipoButAlt, TipoButDel, TipoFilt;
        string[] Filtros;

        public FormInicial()
        {
            InitializeComponent();
            PanCentral.Visible = false;
            LsVyPrinc.Visible = false;
            ButNovo.Visible = false;
            ButAlterar.Visible = false;
            ButExcluir.Visible = false;
            NomRotina.Visible = false;
        }

        public void Foco(object sender, EventArgs e)
        {
            switch (TipoButAlt)
            {
                case 1:
                    {
                        CarregarListViewClientes();
                        break;
                    }
                case 2:
                    {
                        CarregarListViewProdutos();
                        break;
                    }
            }
        }
        /*
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //column header / row headers
            {
                return;
            }

            this.LsVyPrinc.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightBlue;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.LightBlue;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.LightBlue;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.LightBlue;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.LightBlue;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.LightBlue;
          //  this.LsVyPrinc.CurrentRow.Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //column header / row headers
            {
                return;
            }

            this.LsVyPrinc.Rows[e.RowIndex].Cells[0].Style.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[1].Style.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[2].Style.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[3].Style.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[4].Style.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LsVyPrinc.Rows[e.RowIndex].Cells[5].Style.BackColor = System.Drawing.SystemColors.ActiveBorder;

        }
        */
        private void FormInicial_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(FormInicial_Closing);
        }

        private void FormInicial_Closing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            //e.Cancel = false;
            if (MessageBox.Show("Você têm certeza que quer sair do Sistema?", "My Application",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
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
        
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
         {
             PanCentral.Visible = true;
             NomRotina.Text = "Cadastro de Produtos";
             NomRotina.Visible = true;
             CarregarListViewProdutos();

             Filtros = new string[] { "ID", "NOME", "DESCRIÇÃO DETALHADA", "GRUPO DE ITENS", "UN. MEDIDA", "NATUREZA" };

             CombBxFilt.DataSource = new BindingSource(FiltrosGrade(Filtros), null);
             CombBxFilt.DisplayMember = "Value";
             CombBxFilt.ValueMember = "Key";

             CombBxFilt.SelectedIndex = CombBxFilt.FindStringExact("Nome");


         }
        
        public void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanCentral.Visible = true;
            NomRotina.Text = "Cadastro de Clientes";
            NomRotina.Visible = true;
            CarregarListViewClientes();

            Filtros = new string[] { "ID", "NOME", "CPF / CNPJ", "TELEFONE", "CEL", "E-MAIL" };

            CombBxFilt.DataSource = new BindingSource(FiltrosGrade(Filtros), null);
            CombBxFilt.DisplayMember = "Value";
            CombBxFilt.ValueMember = "Key";            

            CombBxFilt.SelectedIndex = CombBxFilt.FindStringExact("Nome");
            

        }

        private void ButNovo_Click(object sender, EventArgs e)
        {
            Controles.Novo(TipoButNv);
            switch (TipoButNv)
            {
                case 1:
                    {
                        CarregarListViewClientes();
                        break;
                    }
                case 2:
                    {
                        CarregarListViewProdutos();
                        break;
                    }
                case 3:
                    {
                        CarregarListViewPdVenda();
                        break;
                    }
            }
        }

        private void ListViewPinc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
             string ItemSelect = LsVyPrinc.CurrentRow.Cells[0].Value.ToString();
             Controles.Alterar(TipoButAlt, ItemSelect);
         }

         private void ButDelCliente_Click(object sender, EventArgs e)
         {
             string ItemSelect = LsVyPrinc.CurrentRow.Cells[0].Value.ToString();
             Controles.Remover(TipoButDel, ItemSelect);        

             switch (TipoButDel){
                case 1:
                    {
                        CarregarListViewClientes();
                        break;
                    } 
                case 2:
                    {
                        CarregarListViewProdutos();
                        break;
                    }
                }
         }

         private void PanCentral_Paint(object sender, PaintEventArgs e)
         {

         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }

         private void ButProcurar_Click(object sender, EventArgs e)
         {
             CarregarFiltros();       
         
         }

         private void CombBxFilt_SelectedIndexChanged(object sender, EventArgs e)
         {
             string key = ((KeyValuePair<string, string>)CombBxFilt.SelectedItem).Key;
             switch (Convert.ToInt32(key))
             {
                 case 0:
                     {
                         RadButContendo.Enabled = false;
                         RadButIgual.Enabled = true;
                         RadButIgual.Checked = true;
                         break;
                     }
                 case 1:
                     {
                         RadButContendo.Enabled = true;
                         RadButIgual.Enabled = true;
                         RadButContendo.Checked = true;
                         break;
                     }
                 case 2:
                     {
                         RadButContendo.Enabled = true;
                         RadButIgual.Enabled = true;
                         RadButIgual.Checked = true;
                         break;
                     }
                 case 3:
                     {
                         RadButContendo.Enabled = true;
                         RadButIgual.Enabled = true;
                         RadButContendo.Checked = true;
                         break;
                     }
                 case 4:
                     {
                         RadButContendo.Enabled = true;
                         RadButIgual.Enabled = true;
                         RadButContendo.Checked = true;
                         break;
                     }
                 case 5:
                     {
                         RadButContendo.Enabled = true;
                         RadButIgual.Enabled = true;
                         RadButContendo.Checked = true;
                         break;
                     }
             }
         }
         private void groupBox1_Enter(object sender, EventArgs e)
         {

         }


         #region Métodos
         public void CarregarListViewClientes()
         {
             ButNovo.Visible = true;
             ButAlterar.Visible = true;
             ButExcluir.Visible = true;
             TipoButNv = Controles.BotaoNv.NvCliente;
             TipoButDel = Controles.BotaoDel.DelCliente();
             TipoButAlt = Controles.BotaoAlt.AltCliente();
             TipoFilt = Controles.BotaoFiltro.FiltCliente;

             LsVyPrinc.DataSource = Controles.CarregarGradeClientes("");
             LsVyPrinc.Columns[0].Width = 30;
             LsVyPrinc.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);

             LsVyPrinc.Visible = true;
             PanFiltros.Visible = true;
   


         }

         public void CarregarListViewPdVenda()
         {
             ButNovo.Visible = true;
             ButAlterar.Visible = true;
             ButExcluir.Visible = true;
             TipoButNv = Controles.BotaoNv.NvPdVenda;
             TipoButDel = Controles.BotaoDel.DelPdVenda();
             TipoButAlt = Controles.BotaoAlt.AltPdVenda();
             TipoFilt = Controles.BotaoFiltro.FiltPdVenda;

             LsVyPrinc.DataSource = Controles.CarregarGradePdVenda("");
             LsVyPrinc.Columns[0].Width = 30;
             LsVyPrinc.Columns[2].Width = 30;
             LsVyPrinc.Columns[3].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);

             LsVyPrinc.Visible = true;
             PanFiltros.Visible = true;



         }
         public void CarregarListViewProdutos()
         {

             ButNovo.Visible = true;
             ButAlterar.Visible = true;
             ButExcluir.Visible = true;
             TipoButNv = Controles.BotaoNv.NvProduto;
             TipoButDel = Controles.BotaoDel.DelProd();
             TipoButAlt = Controles.BotaoAlt.AltProduto();
             TipoFilt = Controles.BotaoFiltro.FiltProduto;
             //  Controles Grade = new Controles();
             LsVyPrinc.DataSource = Controles.CarregarGradeProdutos("");
             LsVyPrinc.Columns[0].Width = 30;
             LsVyPrinc.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);

             LsVyPrinc.Visible = true;
             PanFiltros.Visible = true;




         }

         public Dictionary<string, string> FiltrosGrade(string[] Arr)
         {
             Dictionary<string, string> comboSource = new Dictionary<string, string>();
             for (int i = 0; i < Filtros.Length; i++)
             {
                 comboSource.Add(Convert.ToString(i), Convert.ToString(Arr[i]));
             }
             return comboSource;
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

                     case 3:
                         {
                             switch (Convert.ToInt32(key))
                             {
                                 case 0:
                                     {
                                         where = "IdPdVenda";
                                         RadButContendo.Enabled = false;
                                         RadButIgual.Checked = true;
                                         break;
                                     }
                                 case 1:
                                     {
                                         where = "DataEmissao";
                                         break;
                                     }
                                 case 2:
                                     {
                                         where = "IdCliente";
                                         break;
                                     }
                                 case 3:
                                     {
                                         where = "Nome";
                                         break;
                                     }
                                 case 4:
                                     {
                                         where = "ValorTotalLiq";
                                         break;
                                     }
                                 case 5:
                                     {
                                         where = "Status";
                                         break;
                                     }
                                 case 6:
                                     {
                                         where = "DataUltAlter";
                                         break;
                                     }

                             }
                             if ((RadButContendo.Checked) && (TxtBoxProcurar.Text != ""))
                                 LsVyPrinc.DataSource = Controles.CarregarGradePdVenda(" where " + where + " like '%" + TxtBoxProcurar.Text + "%'");

                             if ((RadButIgual.Checked) && (TxtBoxProcurar.Text != ""))
                                 LsVyPrinc.DataSource = Controles.CarregarGradePdVenda(" where " + where + " = '" + TxtBoxProcurar.Text + "'");

                             if (TxtBoxProcurar.Text == "")
                                 LsVyPrinc.DataSource = Controles.CarregarGradePdVenda("");
                             break;
                         }
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show("Ao filtrar dados dados: " + ex.Message.ToString(), "Erro ao Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
         }
         #endregion

         private void NomRotina_Click(object sender, EventArgs e)
         {

         }

         private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
         {
             PanCentral.Visible = true;
             NomRotina.Text = "Manutenção de Pedidos de Venda";
             NomRotina.Visible = true;
            // LsVyPrinc.Rows.Clear();
             CarregarListViewPdVenda();

             Filtros = new string[] { "ID", "Data Emissão", "ID Cliente", "Nome Cliente", "Valor", "Status", "Ult. Alteração" };

             CombBxFilt.DataSource = new BindingSource(FiltrosGrade(Filtros), null);
             CombBxFilt.DisplayMember = "Value";
             CombBxFilt.ValueMember = "Key";

             CombBxFilt.SelectedIndex = CombBxFilt.FindStringExact("Data Emissão");
         }

         private void pictureBox1_Click(object sender, EventArgs e)
         {

         }
    }
}
