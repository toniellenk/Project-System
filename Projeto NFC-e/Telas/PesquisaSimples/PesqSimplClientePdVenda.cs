using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public partial class PesqSimplClientePdVenda : Projeto_NFC_e.FormPesquisaSimples
    {
        public PesqSimplClientePdVenda(FormPdVenda Form, string Tipo)
            : base(Form, Tipo)
        {
            //  InitializeComponent();
        }

        public override void CarregarFormBase()
        {


            DadosClientes Cliente = new DadosClientes();
            Cliente.Consulta("where IdCliente = " + LsVyPrinc.CurrentRow.Cells[0].Value.ToString());
            foreach (DataRow dr in Cliente.dt.Rows)
            {

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
                SecaoFormPdVenda.LabEnderCliente.Text = dr["Endereco"].ToString();


            }

        }
    }
}
