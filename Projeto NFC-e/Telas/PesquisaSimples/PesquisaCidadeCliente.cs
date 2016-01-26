using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_NFC_e
{
    public partial class PesqSimplCidadeCliente : Projeto_NFC_e.FormPesquisaSimples
    {
        public PesqSimplCidadeCliente(FormCliente Form)
            : base(Form)
        {
            CampoId = "t0030.IdCidade";
            CampoDesc = "t0030.Nome";
            Tipo = "Cidade";
            Procura = SecaoFormCliente.TxtBxCidade.Text;
        }


        public override void CarregarFormBase()
                    {
                        SecaoFormCliente.TxtBxCidade.Text = LsVyPrinc.CurrentRow.Cells[0].Value.ToString();
                        SecaoFormCliente.LabDescCidade.Text = LsVyPrinc.CurrentRow.Cells[1].Value.ToString();
                    }
            
     }
}
