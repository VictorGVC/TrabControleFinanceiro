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
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FCadastro fcad = new FCadastro();

            Hide();
            fcad.ShowDialog();
            Show();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FFuncoes telac = new FFuncoes("Excluir");

            Hide();
            telac.ShowDialog();
            Show();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FFuncoes telac = new FFuncoes("Consultar");

            Hide();
            telac.ShowDialog();
            Show();
        }

        private void BtnCompensar_Click(object sender, EventArgs e)
        {
            FFuncoes telac = new FFuncoes("Compensar");

            Hide();
            telac.ShowDialog();
            Show();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
