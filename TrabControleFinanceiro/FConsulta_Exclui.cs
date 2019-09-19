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
            cbOrdenar.SelectedIndex = 5;
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
                SqlConnection con = new SqlConnection(strCon);
                dtpDe.Visible = false;
                dtpAte.Visible = false;
                lblDe.Visible = false;
                lblAte.Visible = false;
                cbDespesa.Visible = true;
                rbDebito.Visible = false;
                rbCredito.Visible = false;
                DataTable dtDataCB = new DataTable();
                string SQL = @"SELECT * FROM tipo_despesa";
                SqlCommand cmdexibe = new SqlCommand(SQL, con);
                con.Open();
                dtDataCB.Load(cmdexibe.ExecuteReader());
                con.Close();
                cbDespesa.DataSource = dtDataCB;
                cbDespesa.DisplayMember = "tip_nome";
                cbDespesa.ValueMember = "tip_nome";
            }
        }

        private void DtpDe_ValueChanged(object sender, EventArgs e)
        {
            atualizaTabela(0);
        }

        private void DtpAte_ValueChanged(object sender, EventArgs e)
        {
            atualizaTabela(0);
        }

        private void RbCredito_CheckedChanged(object sender, EventArgs e)
        {
            atualizaTabela(1);
        }

        private void RbDebito_CheckedChanged(object sender, EventArgs e)
        {
            atualizaTabela(1);
        }

        private void CbDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaTabela(2);
        }

        private void atualizaTabela(int caso)
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
            switch (caso)
            {
                case 0:
                    SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo AND lan_data >= @dataD AND lan_data <= @dataA 
                    ORDER BY "+ordenar;
                    cmdfiltra = new SqlCommand(SQL, con);
                    cmdfiltra.Parameters.AddWithValue("@dataD", dtpDe.Value);
                    cmdfiltra.Parameters.AddWithValue("@dataA", dtpAte.Value);
                    dtControle.Clear();
                    con.Open();
                    dtControle.Load(cmdfiltra.ExecuteReader());
                    con.Close();
                    break;
                case 1:
                    SQL = @"SELECT lancamentos.lan_codigo as codigo,lancamentos.lan_data as data,lancamentos.lan_tipo as 'tipo de pagamento',lancamentos.lan_compensado as compensado,lan_valor as valor,tipo_despesa.tip_nome as 'tipo de despesa'
                    FROM lancamentos,tipo_despesa
                    WHERE tipo_despesa.tip_codigo = lancamentos.tip_codigo AND lan_tipo = @tipo
                    ORDER BY " + ordenar;
                    cmdfiltra = new SqlCommand(SQL, con);
                    if(rbCredito.Checked)
                        cmdfiltra.Parameters.AddWithValue("@tipo", 'C');
                    else
                        cmdfiltra.Parameters.AddWithValue("@tipo", 'D');
                    dtControle.Clear();
                    con.Open();
                    dtControle.Load(cmdfiltra.ExecuteReader());
                    con.Close();
                    break;
                case 2:
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
                    break;
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
            atualizaTabela(cbFiltrar.SelectedIndex);
        }

        private void CbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            atualizaTabela(cbFiltrar.SelectedIndex);
        }
    }
}
