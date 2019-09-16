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
    public partial class FConsulta_Exclui : Form
    {
        private string action;
        string strConexao = @"";
        DataTable dtControle = new DataTable();

        public FConsulta_Exclui(string action)
        {
            InitializeComponent();
            btnAction.Text = action;
            this.action = action;
            this.Text = action;
        }

        private void consultarTabela()
        {
            
        }

        private void excluirElemento()
        {
            
        }

		private void BtnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (action == "Consultar")
            {
                btnAction.Visible = false;
                consultarTabela();
            }
            else
                excluirElemento();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = cbFiltrar.Text, ordenar = cbOrdenar.Text, txt = ttbFiltro.Text;
            string sql;
            SqlConnection con = new SqlConnection(strConexao);

            dtControle.Rows.Clear();
            if (filtro != "")
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
            if (ordenar != "")
            {
                if (ordenar == "Data")
                {
                    sql = @"";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Crédito/Débito")
                {
                    sql = @"";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Compensação")
                {
                    sql = @"";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Valor")
                {
                    sql = @"";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                else if (ordenar == "Tipo de Despesa")
                {
                    sql = @"";
                    SqlCommand cmdPesquisar = new SqlCommand(sql, con);
                    con.Open();
                    dtControle.Load(cmdPesquisar.ExecuteReader());
                    con.Close();
                }
                dgvConsulta.DataSource = dtControle;
            }
        }
    }
}
