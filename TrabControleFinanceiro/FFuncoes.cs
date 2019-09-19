using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TrabControleFinanceiro
{
    public partial class FFuncoes : Form
    {
        private string action;
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Desktop\controle financeiro\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        //string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicga\Desktop\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dtControle = new DataTable();

        public FFuncoes(string action)
        {
            InitializeComponent();
            if (action == "Consultar")
            {
                btnAction.Visible = false;
            }
            cbOrdenar.SelectedIndex = -1;
            btnAction.Text = action;
            this.action = action;
            this.Text = action;
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
            inicio();
        }

        private void inicio()
        {
			string SQL;
			SqlConnection con = new SqlConnection(strCon);

            try
            {
                DataTable dtDataCB = new DataTable();
                SQL = @"SELECT * FROM tipo_despesa";
                SqlCommand cmdexibe = new SqlCommand(SQL, con);
                con.Open();
                dtDataCB.Load(cmdexibe.ExecuteReader());
                con.Close();
                cbDespesa.DataSource = dtDataCB;
                cbDespesa.DisplayMember = "tip_nome";
                cbDespesa.ValueMember = "tip_nome";
                cbDespesa.SelectedIndex = -1;

                SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo";

                cmdexibe = new SqlCommand(SQL, con);

                con.Open();
                dtControle.Load(cmdexibe.ExecuteReader());
                con.Close();
                dgvConsulta.DataSource = dtControle;
            }
            catch(Exception)
            {
                
            }

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atualizaTabela()
        {
            string SQL;
            SqlConnection con = new SqlConnection(strCon);
            string ordenar;

            ordenar = "lan_codigo";
            switch (cbOrdenar.SelectedIndex)
            {
                case 0:
                    ordenar = "lan_data";
                    break;
                case 1:
                    ordenar = "lan_tipo";
                    break;
                case 2:
                    ordenar = "lan_compensado";
                    break;
                case 3:
                    ordenar = "lan_valor";
                    break;
                case 4:
                    ordenar = "tip_nome";
                    break;
                case 5:
                    ordenar = "lan_codigo";
                    break;
            }
            SqlCommand cmdfiltra;
            if ((rbCredito.Checked || rbDebito.Checked) && cbDespesa.SelectedIndex == -1)
            {
                SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo AND 
                    lan_tipo = @tipo AND 
                    lan_data >= @dataD AND lan_data <= @dataA 
                    ORDER BY " + ordenar;
                cmdfiltra = new SqlCommand(SQL, con);
                if (rbCredito.Checked)
                    cmdfiltra.Parameters.AddWithValue("@tipo", 'C');
                else
                    cmdfiltra.Parameters.AddWithValue("@tipo", 'D');
                cmdfiltra.Parameters.AddWithValue("@dataD", dtpDe.Value);
                cmdfiltra.Parameters.AddWithValue("@dataA", dtpAte.Value);
                dtControle.Clear();
                con.Open();
                dtControle.Load(cmdfiltra.ExecuteReader());
                con.Close();
            }
            else if (cbDespesa.SelectedIndex != -1 && !rbCredito.Checked && !rbDebito.Checked)
            {
                SQL = @"SELECT tip_codigo FROM tipo_despesa";
                cmdfiltra = new SqlCommand(SQL, con);
                DataTable dtCod = new DataTable();
                con.Open();
                dtCod.Load(cmdfiltra.ExecuteReader());
                con.Close();
                int cod = Convert.ToInt32(dtCod.Rows[cbDespesa.SelectedIndex]["tip_codigo"].ToString());
                SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo AND lancamentos.tip_codigo = @cod
                    ORDER BY " + ordenar;
                cmdfiltra = new SqlCommand(SQL, con);
                cmdfiltra.Parameters.AddWithValue("@cod", cod);
                dtControle.Clear();
                con.Open();
                dtControle.Load(cmdfiltra.ExecuteReader());
                con.Close();
                dtCod.Clear();
            }
            else if((rbCredito.Checked || rbDebito.Checked) && cbDespesa.SelectedIndex != -1)
            {
                SQL = @"SELECT tip_codigo FROM tipo_despesa";
                cmdfiltra = new SqlCommand(SQL, con);
                DataTable dtCod = new DataTable();
                con.Open();
                dtCod.Load(cmdfiltra.ExecuteReader());
                con.Close();
                int cod = Convert.ToInt32(dtCod.Rows[cbDespesa.SelectedIndex]["tip_codigo"].ToString());
                SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo AND 
                    lan_data >= @dataD AND lan_data <= @dataA AND
                    lancamentos.tip_codigo = @cod AND
                    lan_tipo = @tipo
                    ORDER BY " + ordenar;
                cmdfiltra = new SqlCommand(SQL, con);
                cmdfiltra.Parameters.AddWithValue("@dataD", dtpDe.Value);
                cmdfiltra.Parameters.AddWithValue("@dataA", dtpAte.Value);
                cmdfiltra.Parameters.AddWithValue("@cod", cod);
                if (rbCredito.Checked)
                    cmdfiltra.Parameters.AddWithValue("@tipo", 'C');
                else
                    cmdfiltra.Parameters.AddWithValue("@tipo", 'D');
                dtControle.Clear();
                con.Open();
                dtControle.Load(cmdfiltra.ExecuteReader());
                con.Close();
            }
            else
            {
                SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo AND lan_data >= @dataD AND lan_data <= @dataA 
                    ORDER BY " + ordenar;
                cmdfiltra = new SqlCommand(SQL, con);
                cmdfiltra.Parameters.AddWithValue("@dataD", dtpDe.Value);
                cmdfiltra.Parameters.AddWithValue("@dataA", dtpAte.Value);
                dtControle.Clear();
                con.Open();
                dtControle.Load(cmdfiltra.ExecuteReader());
                con.Close();
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            string SQL = @"DELETE FROM lancamentos
                            WHERE lan_codigo = @cod";
            SqlCommand cmdDeletar = new SqlCommand(SQL, con);
            cmdDeletar.Parameters.AddWithValue("@cod",Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value));
            dgvConsulta.Rows.Remove(dgvConsulta.CurrentRow);
            con.Open();
            cmdDeletar.ExecuteNonQuery();
            con.Close();
        }

        private void CbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
        }

        private void CbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            atualizaTabela();
            btnFiltrar.Visible = false;
            btnTirarF.Visible = true;
        }

        private void RbDebito_CheckedChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
        }

        private void RbCredito_CheckedChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
        }

        private void CbDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
        }

        private void DtpAte_ValueChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
        }

        private void DtpDe_ValueChanged(object sender, EventArgs e)
        {
            btnFiltrar.Visible = true;
            btnTirarF.Visible = false;
        }

        private void BtnTirarF_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            cbDespesa.SelectedIndex = -1;
            rbCredito.Checked = false;
            rbDebito.Checked = false;
            cbOrdenar.SelectedIndex = -1;
            cbOrdenar.SelectedIndex = -1;
            btnFiltrar.Visible = false;
            btnTirarF.Visible = true;
            string SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo";

            SqlCommand cmdexibe = new SqlCommand(SQL, con);
            dtControle.Clear();
            con.Open();
            dtControle.Load(cmdexibe.ExecuteReader());
            con.Close();
            dgvConsulta.DataSource = dtControle;
        }

        private void DgvConsulta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.RowIndex % 2 == 0)
                dgvConsulta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            else
                dgvConsulta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
            dgvConsulta.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Ebrima", 10);
        }
    }
}
