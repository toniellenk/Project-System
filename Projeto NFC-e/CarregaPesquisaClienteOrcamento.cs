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
    public class CarregaPesquisaClienteOrcamento : FormPesquisaSimples
    {

       public void FormPesquisaSimples()
        {
        }
        private override void roomDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarCidadeFormCliente();
            this.Close();
        }

        public override void CarregarCidadeFormCliente()
        {
                     
            
            DadosClientes Cliente = new DadosClientes();
            Cliente.Consulta("where IdCliente = " + LsVyPrinc.CurrentRow.Cells[0].Value.ToString());
            foreach (DataRow dr in Cliente.dt.Rows) {

                string CpfCnpj = dr["CpfCnpj"].ToString();

                CpfCnpj = CpfCnpj.Trim();

                if (CpfCnpj.Length == 14)
                {
                    CpfCnpj = CpfCnpj.Substring(0, 2) + "." + CpfCnpj.Substring(2, 3) + "." + CpfCnpj.Substring(5, 3) + "/" + CpfCnpj.Substring(8, 4) + "-" + CpfCnpj.Substring(12, 2);
                }
                if (CpfCnpj.Length == 11)
                {
                    CpfCnpj = CpfCnpj.Substring(0, 3) + "." + CpfCnpj.Substring(3, 3) + "." + CpfCnpj.Substring(6, 3) + "-" + CpfCnpj.Substring(9, 2);
                }

                SecaoFormPdVenda.LabNomeCliente.Text = dr["Nome"].ToString();
                SecaoFormPdVenda.LabCpfCnpjCliente.Text = CpfCnpj;
                    
            
            }

        }
    }
}
