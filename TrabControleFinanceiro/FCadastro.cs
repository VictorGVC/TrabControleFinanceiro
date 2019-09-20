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
    public partial class FCadastro : Form
    {
        //string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Desktop\controle financeiro\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicga\Desktop\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dtControle = new DataTable();

		public FCadastro()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            SqlConnection con = new SqlConnection(strCon);

            dtpData.Value = DateTime.Now.Date;
            rbtnDebito.Checked = false;
			rbtnCrédito.Checked = false;
			rbtnSim.Checked = false;
			rbtnNao.Checked = false;
			ttbValor.Clear();

            DataTable dtDataCB = new DataTable();
            string SQL = @"SELECT * FROM tipo_despesa";
            SqlCommand cmdexibe = new SqlCommand(SQL, con);

            con.Open();
            dtDataCB.Load(cmdexibe.ExecuteReader());
            con.Close();
            cbDespesa.DataSource = dtDataCB;
            cbDespesa.DisplayMember = "tip_nome";
            cbDespesa.ValueMember = "tip_nome";
            cbDespesa.SelectedIndex = -1;
        }

		private void BtnGravar_Click(object sender, EventArgs e)
		{
            if(cbDespesa.Text != "")
            {
                if(rbtnCrédito.Checked != false || rbtnDebito.Checked != false)
                {
                    if(rbtnSim.Checked != false || rbtnNao.Checked != false)
                    {
                        if(ttbValor.Text != "")
                        {
                            try
                            {
                                string SQL;
                                SqlConnection con = new SqlConnection(strCon);

                                SQL = @"SELECT tip_codigo, tip_nome FROM tipo_despesa
                                        WHERE tip_nome = @nomeD";

                                SqlCommand cmdPesquisar = new SqlCommand(SQL, con);

                                cmdPesquisar.Parameters.AddWithValue("@nomeD", cbDespesa.Text);
                                con.Open();
                                dtControle.Load(cmdPesquisar.ExecuteReader());
                                con.Close();
                                int codD = Convert.ToInt32(dtControle.Rows[0]["tip_codigo"].ToString());
                                dtControle.Clear();
                                SQL = @"INSERT INTO lancamentos(lan_data,tip_codigo,lan_tipo,lan_compensado,lan_valor)
                                        VALUES(@data,@cod,@tipo,@compensado,@valor)";

                                SqlCommand cmdGravar = new SqlCommand(SQL, con);

                                cmdGravar.Parameters.AddWithValue("@data", dtpData.Value);
                                cmdGravar.Parameters.AddWithValue("@cod", codD);
                                if (rbtnDebito.Checked)
                                    cmdGravar.Parameters.AddWithValue("@tipo", 'D');
                                else if (rbtnCrédito.Checked)
                                    cmdGravar.Parameters.AddWithValue("@tipo", 'C');
                                if (rbtnSim.Checked)
                                    cmdGravar.Parameters.AddWithValue("@compensado", "S");
                                else if (rbtnNao.Checked)
                                    cmdGravar.Parameters.AddWithValue("@compensado", "N");
                                cmdGravar.Parameters.AddWithValue("@valor", Convert.ToDouble(ttbValor.Text));
                                con.Open();
                                cmdGravar.ExecuteNonQuery();
                                con.Close();
                            }
                            catch
                            {
                                if (MessageBox.Show("Tipo de despesa não cadastrado, deseja realmente cadastrar um novo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string SQL;
                                    SqlConnection con = new SqlConnection(strCon);

                                    SQL = @"INSERT INTO tipo_despesa(tip_nome)
                                            VALUES(@nomeT)";

                                    SqlCommand cmdGravar = new SqlCommand(SQL, con);

                                    cmdGravar.Parameters.AddWithValue("@nomeT", cbDespesa.Text);
                                    con.Open();
                                    cmdGravar.ExecuteNonQuery();
                                    con.Close();
                                    SQL = @"SELECT tip_codigo, tip_nome FROM tipo_despesa
                                            WHERE tip_nome = @nomeD";

                                    SqlCommand cmdPesquisar = new SqlCommand(SQL, con);

                                    cmdPesquisar.Parameters.AddWithValue("@nomeD", cbDespesa.Text);
                                    con.Open();
                                    dtControle.Load(cmdPesquisar.ExecuteReader());
                                    con.Close();
                                    int codD = Convert.ToInt32(dtControle.Rows[0]["tip_codigo"].ToString());
                                    dtControle.Clear();
                                    SQL = @"INSERT INTO lancamentos(lan_data,tip_codigo,lan_tipo,lan_compensado,lan_valor)
                                            VALUES(@data,@cod,@tipo,@compensado,@valor)";
                                    cmdGravar = new SqlCommand(SQL, con);
                                    cmdGravar.Parameters.AddWithValue("@data", dtpData.Value);
                                    cmdGravar.Parameters.AddWithValue("@cod", codD);
                                    if (rbtnDebito.Checked)
                                        cmdGravar.Parameters.AddWithValue("@tipo", 'D');
                                    else if (rbtnCrédito.Checked)
                                        cmdGravar.Parameters.AddWithValue("@tipo", 'C');
                                    if (rbtnSim.Checked)
                                        cmdGravar.Parameters.AddWithValue("@compensado", "S");
                                    else if (rbtnNao.Checked)
                                        cmdGravar.Parameters.AddWithValue("@compensado", "N");
                                    cmdGravar.Parameters.AddWithValue("@valor", Convert.ToDouble(ttbValor.Text));
                                    con.Open();
                                    cmdGravar.ExecuteNonQuery();
                                    con.Close();
                                }
                            }
                            inicializar();
                        }
                        else
                        {
                            MessageBox.Show("Digitar valor desejado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ttbValor.Focus();
                        }
                    }
                    else
                        MessageBox.Show("Selecionar Compensação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Selecionar Tipo do lançamento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Digitar despesa desejada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDespesa.Focus();
            }
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
            Close();
		}

        private void TtbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == (char)Keys.Back))
            {
                if (e.KeyChar == '.')
                    e.KeyChar = ',';
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (ttbValor.Text.Contains(",") && (e.KeyChar == ',')|| (e.KeyChar == ',')&&ttbValor.Text == "")
                e.Handled = true;
        }
    }
}
