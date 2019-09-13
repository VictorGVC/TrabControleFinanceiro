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
    public partial class FCadastro : Form
    {
        string titulo = "Controle Financeiro";

        public FCadastro()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            ttbCodDesp.Clear();
            ttbNome.Clear();
            ttbCodLan.Clear();
            rbtnDebito.Checked = false;
            rbtnCrédito.Checked = false;
            ttbCompensa.Clear();
            ttbValor.Clear();
            dtpData.Value = DateTime.Now.Date;
        }

		private void BtnGravar_Click(object sender, EventArgs e)
		{

		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
            Close();
		}

	}
}
