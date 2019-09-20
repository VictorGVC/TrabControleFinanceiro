using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabControleFinanceiro
{
    public partial class FCompensar : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Desktop\controle financeiro\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        //string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicga\Desktop\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dtCompensa = new DataTable();

        public FCompensar()
        {
            InitializeComponent();
            Inicia();
            AcceptButton = btnCompensar;
        }

        private void Inicia()
        {
            string SQL;
            SqlConnection con = new SqlConnection(strCon);
            dtCompensa.Clear();
            SQL = @"SELECT lancamentos.lan_codigo as Codigo,tipo_despesa.tip_nome as 'Tipo de Despesa',
                    lancamentos.lan_compensado as Compensado,lancamentos.lan_valor as Valor,lancamentos.lan_data as Data
                    FROM lancamentos,tipo_despesa
                    WHERE lancamentos.tip_codigo = tipo_despesa.tip_codigo AND
                    lan_compensado = 'N' AND
                    lan_data >= @dataD AND lan_data <= @dataA";
            SqlCommand cmdExibe = new SqlCommand(SQL, con);
            cmdExibe.Parameters.AddWithValue("@dataD",dtpDe.Value);
            cmdExibe.Parameters.AddWithValue("@dataA",dtpAte.Value);
            con.Open();
            dtCompensa.Load(cmdExibe.ExecuteReader());
            con.Close();
            dgvCompensa.DataSource = dtCompensa;
            if (dgvCompensa.Rows.Count == 0)
                btnCompensar.Enabled = false;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.RowIndex % 2 == 0)
                dgvCompensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            else
                dgvCompensa.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
            dgvCompensa.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Ebrima", 8);
            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtpDe_ValueChanged(object sender, EventArgs e)
        {
            Inicia();
        }

        private void DtpAte_ValueChanged(object sender, EventArgs e)
        {
            Inicia();
        }

        private void BtnCompensar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confima compensação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(strCon);
                foreach(DataGridViewRow r in dgvCompensa.SelectedRows)
                {
                    string SQL = @"UPDATE lancamentos
                                SET lan_compensado = 'S'
                                WHERE lan_codigo = @cod1";
                    SqlCommand sqlatualiza = new SqlCommand(SQL, con);
                    sqlatualiza.Parameters.AddWithValue("@cod1", Convert.ToInt32(r.Cells[0].Value));
                    con.Open();
                    sqlatualiza.ExecuteNonQuery();
                    con.Close();
                }
                Inicia();
            }
        }

    }
}
