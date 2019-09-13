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
            fcad.ShowDialog();
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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
