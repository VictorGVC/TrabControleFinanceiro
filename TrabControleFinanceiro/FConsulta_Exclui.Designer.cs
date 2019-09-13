﻿namespace TrabControleFinanceiro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.colcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompensado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBtn.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.Linen;
            this.pnlBtn.Controls.Add(this.btnAction);
            this.pnlBtn.Controls.Add(this.btnVoltar);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtn.Location = new System.Drawing.Point(0, 385);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(650, 30);
            this.pnlBtn.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAction.Location = new System.Drawing.Point(575, 0);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 30);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "button1";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 30);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.Color.Linen;
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCampos.Location = new System.Drawing.Point(0, 0);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(650, 100);
            this.pnlCampos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 285);
            this.panel1.TabIndex = 2;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcodigo,
            this.colData,
            this.colTipo,
            this.colCompensado,
            this.colValor,
            this.colTipoDespesa});
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(0, 0);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(650, 285);
            this.dgvConsulta.TabIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.HeaderText = "Codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo de Pagamento";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colCompensado
            // 
            this.colCompensado.HeaderText = "Compensado";
            this.colCompensado.Name = "colCompensado";
            this.colCompensado.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colTipoDespesa
            // 
            this.colTipoDespesa.HeaderText = "Tipo de Despesa";
            this.colTipoDespesa.Name = "colTipoDespesa";
            this.colTipoDespesa.ReadOnly = true;
            // 
            // FConsulta_Exclui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FConsulta_Exclui";
            this.Text = "Consulta";
            this.pnlBtn.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompensado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDespesa;
    }
}