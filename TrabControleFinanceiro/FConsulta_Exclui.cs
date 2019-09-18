using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrabControleFinanceiro
{
    public partial class FConsulta_Exclui : Form
    {
        private string action;
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicga\Desktop\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dtControle = new DataTable();

        public FConsulta_Exclui(string action)
        {
            InitializeComponent();
            if (action == "Consultar")
            {
                btnAction.Visible = false;
            }
            btnAction.Text = action;
            this.action = action;
            this.Text = action;
            dtpDe.Visible = false;
            dtpAte.Visible = false;
            lblDe.Visible = false;
            lblAte.Visible = false;
            cbDespesa.Visible = false;
            rbDebito.Visible = false;
            rbCredito.Visible = false;
            inicio();
        }

        private void inicio()
        {
			string SQL;
			SqlConnection con = new SqlConnection(strCon);
            
            SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo";

			SqlCommand cmdexibe = new SqlCommand(SQL, con);

			con.Open();
            dtControle.Load(cmdexibe.ExecuteReader());
            con.Close();
            dgvConsulta.DataSource = dtControle;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = cbFiltrar.Text, ordenar = cbOrdenar.Text, txt = "a"; //txt = ttbFiltro.Text;
            string sql;
            SqlConnection con = new SqlConnection(strCon);

            dtControle.Rows.Clear();
            if (filtro != "")
            {
                if(txt != "")
				{
					txt += "%";
					if (filtro == "Período")
					{
						sql = @"";
						SqlCommand cmdPesquisar = new SqlCommand(sql, con);
						cmdPesquisar.Parameters.AddWithValue("@", txt);
						con.Open();
						dtControle.Load(cmdPesquisar.ExecuteReader());
						con.Close();
					}
					else if (filtro == "Débito")
					{
						sql = @"";
						SqlCommand cmdPesquisar = new SqlCommand(sql, con);
						cmdPesquisar.Parameters.AddWithValue("@", txt);
						con.Open();
						dtControle.Load(cmdPesquisar.ExecuteReader());
						con.Close();
					}
					else if (filtro == "Crédito")
					{
						sql = @"";
						SqlCommand cmdPesquisar = new SqlCommand(sql, con);
						cmdPesquisar.Parameters.AddWithValue("@", txt);
						con.Open();
						dtControle.Load(cmdPesquisar.ExecuteReader());
						con.Close();
					}
					else if (filtro == "Tipo de Despesa")
					{
						sql = @"";
						SqlCommand cmdPesquisar = new SqlCommand(sql, con);
						cmdPesquisar.Parameters.AddWithValue("@", txt);
						con.Open();
						dtControle.Load(cmdPesquisar.ExecuteReader());
						con.Close();
					}
					dgvConsulta.DataSource = dtControle;
				}
				else
				{
					MessageBox.Show("Digitar o filtro desejado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					//ttbFiltro.Focus();
				}
            }
            if (ordenar != "")
            {
                if (ordenar == "Data")
                {
                    sql = @"SELECT * FROM lancamentos ORDER BY data";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Crédito/Débito")
                {
                    sql = @"SELECT * FROM lancamentos ORDER BY tipo";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Compensação")
                {
                    sql = @"SELECT * FROM lancamentos ORDER BY compensado";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Valor")
                {
                    sql = @"SELECT * FROM lancamentos ORDER BY valor";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Tipo de Despesa")
                {
                    sql = @"SELECT * FROM tipo_despesa ORDER BY nomeD";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                dgvConsulta.DataSource = dtControle;
			}
        }

        private void CbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrar.SelectedIndex == 0)
            {
                dtpDe.Visible = true;
                dtpAte.Visible = true;
                lblDe.Visible = true;
                lblAte.Visible = true;
                cbDespesa.Visible = false;
                rbDebito.Visible = false;
                rbCredito.Visible = false;
            }
            else if (cbFiltrar.SelectedIndex == 1)
            {
                dtpDe.Visible = false;
                dtpAte.Visible = false;
                lblDe.Visible = false;
                lblAte.Visible = false;
                cbDespesa.Visible = false;
                rbDebito.Visible = true;
                rbCredito.Visible = true;
            }
            else if (cbFiltrar.SelectedIndex == 2)
            {
                dtpDe.Visible = false;
                dtpAte.Visible = false;
                lblDe.Visible = false;
                lblAte.Visible = false;
                cbDespesa.Visible = true;
                rbDebito.Visible = false;
                rbCredito.Visible = false;
            }
        }

        private void DtpDe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpAte_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RbCredito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbDebito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CbDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atualizaTabela()
        {
            string SQL;
            SqlConnection con = new SqlConnection(strCon);
            string ordenar;
            switch(cbOrdenar.SelectedIndex)
            {
                case 0:
                    //ordenar = 
                break;
                case 1:
                    //ordenar =
                break;
                case 2:
                    //ordenar =
                break;
                case 3:
                    //ordenar =
                break;
            }

            if (cbFiltrar.SelectedItem.ToString() == "")
            {
                SQL = @"SELECT * FROM lancamentos ORDER BY data";
                SqlCommand cmdPesquisar = new SqlCommand(SQL, con);
                con.Open();
                dtControle.Load(cmdPesquisar.ExecuteReader());
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
    }
}
