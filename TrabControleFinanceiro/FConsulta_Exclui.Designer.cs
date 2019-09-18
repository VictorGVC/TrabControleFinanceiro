namespace TrabControleFinanceiro
{
    partial class FConsulta_Exclui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsulta_Exclui));
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.cbDespesa = new System.Windows.Forms.ComboBox();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.lbOrdenar = new System.Windows.Forms.Label();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.pnlBtn.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnlBtn.Controls.Add(this.btnAction);
            this.pnlBtn.Controls.Add(this.btnVoltar);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtn.Location = new System.Drawing.Point(0, 385);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(643, 30);
            this.pnlBtn.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.White;
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAction.Location = new System.Drawing.Point(568, 0);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 30);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "button1";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 30);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnlCampos.Controls.Add(this.cbDespesa);
            this.pnlCampos.Controls.Add(this.rbDebito);
            this.pnlCampos.Controls.Add(this.rbCredito);
            this.pnlCampos.Controls.Add(this.lblAte);
            this.pnlCampos.Controls.Add(this.lblDe);
            this.pnlCampos.Controls.Add(this.dtpAte);
            this.pnlCampos.Controls.Add(this.dtpDe);
            this.pnlCampos.Controls.Add(this.cbOrdenar);
            this.pnlCampos.Controls.Add(this.lbOrdenar);
            this.pnlCampos.Controls.Add(this.cbFiltrar);
            this.pnlCampos.Controls.Add(this.lbFiltro);
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCampos.Location = new System.Drawing.Point(0, 0);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(643, 80);
            this.pnlCampos.TabIndex = 1;
            // 
            // cbDespesa
            // 
            this.cbDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDespesa.FormattingEnabled = true;
            this.cbDespesa.Location = new System.Drawing.Point(351, 51);
            this.cbDespesa.Name = "cbDespesa";
            this.cbDespesa.Size = new System.Drawing.Size(121, 21);
            this.cbDespesa.TabIndex = 10;
            this.cbDespesa.SelectedIndexChanged += new System.EventHandler(this.CbDespesa_SelectedIndexChanged);
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Location = new System.Drawing.Point(488, 13);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(56, 17);
            this.rbDebito.TabIndex = 9;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Debito";
            this.rbDebito.UseVisualStyleBackColor = true;
            this.rbDebito.CheckedChanged += new System.EventHandler(this.RbDebito_CheckedChanged);
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(396, 14);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(58, 17);
            this.rbCredito.TabIndex = 8;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Credito";
            this.rbCredito.UseVisualStyleBackColor = true;
            this.rbCredito.CheckedChanged += new System.EventHandler(this.RbCredito_CheckedChanged);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(492, 34);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(23, 13);
            this.lblAte.TabIndex = 7;
            this.lblAte.Text = "Até";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(337, 34);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 6;
            this.lblDe.Text = "De";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(521, 31);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(110, 20);
            this.dtpAte.TabIndex = 5;
            this.dtpAte.ValueChanged += new System.EventHandler(this.DtpAte_ValueChanged);
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(361, 31);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(114, 20);
            this.dtpDe.TabIndex = 4;
            this.dtpDe.ValueChanged += new System.EventHandler(this.DtpDe_ValueChanged);
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Items.AddRange(new object[] {
            "Data",
            "Crédito/Débito",
            "Compensação",
            "Valor",
            "Tipo de Despesa"});
            this.cbOrdenar.Location = new System.Drawing.Point(12, 30);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(106, 21);
            this.cbOrdenar.TabIndex = 1;
            // 
            // lbOrdenar
            // 
            this.lbOrdenar.AutoSize = true;
            this.lbOrdenar.Location = new System.Drawing.Point(9, 14);
            this.lbOrdenar.Name = "lbOrdenar";
            this.lbOrdenar.Size = new System.Drawing.Size(66, 13);
            this.lbOrdenar.TabIndex = 0;
            this.lbOrdenar.Text = "Ordenar por:";
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "Período",
            "Tipo de Pagamento",
            "Tipo de Despesa"});
            this.cbFiltrar.Location = new System.Drawing.Point(225, 30);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(106, 21);
            this.cbFiltrar.TabIndex = 1;
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.CbFiltrar_SelectedIndexChanged);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(222, 14);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(54, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtrar Por:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 305);
            this.panel1.TabIndex = 2;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(0, 0);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(643, 305);
            this.dgvConsulta.TabIndex = 0;
            // 
            // FConsulta_Exclui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FConsulta_Exclui";
            this.Text = "Consulta";
            this.pnlBtn.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel pnlBtn;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Panel pnlCampos;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.Label lbOrdenar;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.ComboBox cbDespesa;
    }
}