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

            string colunas = "t0050.Nome as NomeCliente, t0050.CpfCnpj, t0050.Endereco,t0050.SitCredito, t0030.Nome as NomeCidade, t0029.Sigla";
            DadosClientes Cliente = new DadosClientes();
            Cliente.Consulta(colunas, "where t0050.IdCliente = "+ LsVyPrinc.CurrentRow.Cells[0].Value.ToString());
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

                string SitCredito = dr["SitCredito"].ToString();

                if (Convert.ToInt32(SitCredito) == 1)
                {
                    SecaoFormPdVenda.LabSitCred.Text = "Aprovado";
                    SecaoFormPdVenda.ImgOk.Visible = true;
                    SecaoFormPdVenda.ImgAlert.Visible = false;
                    SecaoFormPdVenda.ImgBloq.Visible = false;
                }
                if (Convert.ToInt32(SitCredito) == 2)
                {
                    SecaoFormPdVenda.LabSitCred.Text = "Pendente";
                    SecaoFormPdVenda.ImgAlert.Visible = true;
                    SecaoFormPdVenda.ImgOk.Visible = false;
                    SecaoFormPdVenda.ImgBloq.Visible = false;
                }
                if (Convert.ToInt32(SitCredito) == 3)
                {
                    SecaoFormPdVenda.LabSitCred.Text = "Bloqueado";
                    SecaoFormPdVenda.ImgBloq.Visible = true;
                    SecaoFormPdVenda.ImgAlert.Visible = false;
                    SecaoFormPdVenda.ImgAlert.Visible = false;
                }

                SecaoFormPdVenda.LabNomeCliente.Text = dr["NomeCliente"].ToString();
                SecaoFormPdVenda.LabCpfCnpjCliente.Text = CpfCnpj;
                SecaoFormPdVenda.LabEnderCliente.Text = dr["Endereco"].ToString();
                SecaoFormPdVenda.LabCidade.Text = dr["NomeCidade"].ToString();
                SecaoFormPdVenda.LabUf.Text = dr["Sigla"].ToString();


            }

        }
    }
}
