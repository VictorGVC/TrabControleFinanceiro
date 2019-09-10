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
    public partial class FConsulta : Form
    {
        private string action;

        public FConsulta(string action)
        {
            InitializeComponent();
            btAction.Text = action;
            this.action = action;
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultarTabela()
        {
            
        }

        private void excluirElemento()
        {
            
        }

        private void BtAction_Click(object sender, EventArgs e)
        {
            if (action == "Consultar")
                consultarTabela();
            else
                excluirElemento();
        }
    }
}
