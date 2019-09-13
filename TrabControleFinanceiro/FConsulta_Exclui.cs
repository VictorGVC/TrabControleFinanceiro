using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabControleFinanceiro
{
    public partial class FConsulta_Exclui : Form
    {
        DataTable dtControle = new DataTable();

        private string action;

        public FConsulta_Exclui(string action)
        {
            InitializeComponent();
            btnAction.Text = action;
            this.action = action;
            this.Text = action;
        }

        private void consultarTabela()
        {
            
        }

        private void excluirElemento()
        {
            
        }

		private void BtnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (action == "Consultar")
                consultarTabela();
            else
                excluirElemento();
        }

    }
}
