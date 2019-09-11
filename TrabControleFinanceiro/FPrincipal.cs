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
    public partial class FPrincipal : Form
    {
        string titulo = "Controle Financeiro";

        public FPrincipal()
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
            habilitar("N");
        }

        private void habilitar(string acao)
        {
            switch (acao)
            {
                case "I": Text = titulo + " - INSERINDO"; break;
                case "V": Text = titulo + " - VISUALIZANDO"; break;
                default: Text = titulo; break;
            }
            btnInserir.Enabled = acao == "N";
            btnExcluir.Enabled = acao == "V";
            btnGravar.Enabled = acao == "I";
            btnCancelar.Enabled = "IV".IndexOf(acao) >= 0;
            pnlDados.Enabled = acao == "I";
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            habilitar("I");
            ttbNome.Focus();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FConsulta_Exclui telac = new FConsulta_Exclui("Excluir");
            telac.ShowDialog();
        }

		private void BtnConsultar_Click(object sender, EventArgs e)
		{
			FConsulta_Exclui telac = new FConsulta_Exclui("Consultar");
			telac.ShowDialog();
		}

		private void BtnGravar_Click(object sender, EventArgs e)
		{

		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			inicializar();
		}

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

	}
}
