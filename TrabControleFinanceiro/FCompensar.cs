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
    public partial class FCompensar : Form
    {
        public FCompensar()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.RowIndex % 2 == 0)
                dgvCompensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            else
                dgvCompensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
            dgvCompensa.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Ebrima", 10);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
