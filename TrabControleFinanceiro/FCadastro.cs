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
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicga\Desktop\Banco controle\databaseFinanceiro.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dtControle = new DataTable();

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
			rbtnSim.Checked = false;
			rbtnNao.Checked = false;
			ttbValor.Clear();
            dtpData.Value = DateTime.Now.Date;
        }

		private void BtnGravar_Click(object sender, EventArgs e)
		{
            try
            {
				string SQL;
				SqlConnection con = new SqlConnection(strCon);
                
                SQL = @"SELECT tip_codigo, tip_nome FROM tipo_despesa
                        WHERE tip_nome = @nomeD";

                SqlCommand cmdPesquisar = new SqlCommand(SQL, con);

				cmdPesquisar.Parameters.AddWithValue("@nomeD", ttbNome.Text);
                con.Open();
                dtControle.Load(cmdPesquisar.ExecuteReader());
                con.Close();
                int codD = Convert.ToInt32(dtControle.Rows[0]["tip_codigo"].ToString());
                dtControle.Clear();
                SQL = @"INSERT INTO lancamentos(lan_data,tip_codigo,lan_tipo,lan_compensado,lan_valor)
                        VALUES(@data,@cod,@tipo,@compensado,@valor)";

				SqlCommand cmdGravar = new SqlCommand(SQL, con);

				cmdGravar.Parameters.AddWithValue("@data",dtpData.Value);
                cmdGravar.Parameters.AddWithValue("@cod",codD);
				if (rbtnDebito.Checked)
					cmdGravar.Parameters.AddWithValue("@tipo", 'D');
				else if (rbtnCrédito.Checked)
                    cmdGravar.Parameters.AddWithValue("@tipo",'C');
				if (rbtnSim.Checked)
					cmdGravar.Parameters.AddWithValue("@compensado", "Sim");
				else if (rbtnNao.Checked)
					cmdGravar.Parameters.AddWithValue("@compensado", "Não");
				cmdGravar.Parameters.AddWithValue("@valor",Convert.ToDouble(ttbValor.Text));
                con.Open();
                cmdGravar.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                if(MessageBox.Show("Tipo de despesa não cadastrado, deseja realmente cadastrar um novo?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
					string SQL;
					SqlConnection con = new SqlConnection(strCon);
                    
                    SQL = @"INSERT INTO tipo_despesa(tip_nome)
                        VALUES(@nomeT)";

					SqlCommand cmdGravar = new SqlCommand(SQL, con);

					cmdGravar.Parameters.AddWithValue("@nomeT", ttbNome.Text);
                    con.Open();
                    cmdGravar.ExecuteNonQuery();
                    con.Close();
                    SQL = @"SELECT tip_codigo, tip_nome FROM tipo_despesa
                        WHERE tip_nome = @nomeD";

					SqlCommand cmdPesquisar = new SqlCommand(SQL, con);

					cmdPesquisar.Parameters.AddWithValue("@nomeD", ttbNome.Text);
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
						cmdGravar.Parameters.AddWithValue("@compensado", "Sim");
					else if(rbtnNao.Checked)
						cmdGravar.Parameters.AddWithValue("@compensado", "Não");
					cmdGravar.Parameters.AddWithValue("@valor", Convert.ToDouble(ttbValor.Text));
                    con.Open();
                    cmdGravar.ExecuteNonQuery();
                    con.Close();
                }
                
            }
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
            Close();
		}

	}
}
