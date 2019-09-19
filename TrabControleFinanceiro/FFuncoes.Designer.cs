namespace TrabControleFinanceiro
{
    partial class FFuncoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFuncoes));
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.btnTirarF = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbDespesa = new System.Windows.Forms.ComboBox();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.lbOrdenar = new System.Windows.Forms.Label();
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
            this.pnlBtn.Location = new System.Drawing.Point(0, 379);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(643, 36);
            this.pnlBtn.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.White;
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAction.Image = ((System.Drawing.Image)(resources.GetObject("btnAction.Image")));
            this.btnAction.Location = new System.Drawing.Point(568, 0);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 36);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "button1";
            this.btnAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnVoltar.Size = new System.Drawing.Size(77, 36);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnlCampos.Controls.Add(this.btnTirarF);
            this.pnlCampos.Controls.Add(this.btnFiltrar);
            this.pnlCampos.Controls.Add(this.cbDespesa);
            this.pnlCampos.Controls.Add(this.rbDebito);
            this.pnlCampos.Controls.Add(this.rbCredito);
            this.pnlCampos.Controls.Add(this.lblAte);
            this.pnlCampos.Controls.Add(this.lblDe);
            this.pnlCampos.Controls.Add(this.dtpAte);
            this.pnlCampos.Controls.Add(this.dtpDe);
            this.pnlCampos.Controls.Add(this.cbOrdenar);
            this.pnlCampos.Controls.Add(this.lbOrdenar);
            this.pnlCampos.Controls.Add(this.lbFiltro);
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCampos.Location = new System.Drawing.Point(0, 0);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(643, 74);
            this.pnlCampos.TabIndex = 1;
            // 
            // btnTirarF
            // 
            this.btnTirarF.Image = ((System.Drawing.Image)(resources.GetObject("btnTirarF.Image")));
            this.btnTirarF.Location = new System.Drawing.Point(549, 15);
            this.btnTirarF.Name = "btnTirarF";
            this.btnTirarF.Size = new System.Drawing.Size(82, 41);
            this.btnTirarF.TabIndex = 12;
            this.btnTirarF.Text = "Limpar Filtro";
            this.btnTirarF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTirarF.UseVisualStyleBackColor = true;
            this.btnTirarF.Click += new System.EventHandler(this.BtnTirarF_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(556, 14);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 42);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // cbDespesa
            // 
            this.cbDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDespesa.FormattingEnabled = true;
            this.cbDespesa.Location = new System.Drawing.Point(205, 38);
            this.cbDespesa.Name = "cbDespesa";
            this.cbDespesa.Size = new System.Drawing.Size(114, 21);
            this.cbDespesa.TabIndex = 10;
            this.cbDespesa.SelectedIndexChanged += new System.EventHandler(this.CbDespesa_SelectedIndexChanged);
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Location = new System.Drawing.Point(418, 39);
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
            this.rbCredito.Location = new System.Drawing.Point(354, 39);
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
            this.lblAte.Location = new System.Drawing.Point(325, 15);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(23, 13);
            this.lblAte.TabIndex = 7;
            this.lblAte.Text = "Até";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(181, 15);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 6;
            this.lblDe.Text = "De";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(354, 13);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(120, 20);
            this.dtpAte.TabIndex = 5;
            this.dtpAte.ValueChanged += new System.EventHandler(this.DtpAte_ValueChanged);
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(205, 12);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(114, 20);
            this.dtpDe.TabIndex = 4;
            this.dtpDe.Value = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
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
            "Tipo de Despesa",
            "Codigo"});
            this.cbOrdenar.Location = new System.Drawing.Point(12, 30);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(106, 21);
            this.cbOrdenar.TabIndex = 1;
            this.cbOrdenar.SelectedIndexChanged += new System.EventHandler(this.CbOrdenar_SelectedIndexChanged);
            this.cbOrdenar.SelectedValueChanged += new System.EventHandler(this.CbOrdenar_SelectedValueChanged);
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
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(140, 15);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(35, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtrar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 305);
            this.panel1.TabIndex = 2;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToResizeColumns = false;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(0, 0);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(643, 305);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvConsulta_CellFormatting);
            // 
            // FFuncoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FFuncoes";
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTirarF;
    }
}