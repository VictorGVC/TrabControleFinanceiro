namespace TrabControleFinanceiro
{
    partial class FCompensar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompensar));
            this.pnlDatas = new System.Windows.Forms.Panel();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvCompensa = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCompensar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlDatas.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompensa)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatas
            // 
            this.pnlDatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnlDatas.Controls.Add(this.lblAte);
            this.pnlDatas.Controls.Add(this.lblDe);
            this.pnlDatas.Controls.Add(this.dtpAte);
            this.pnlDatas.Controls.Add(this.dtpDe);
            this.pnlDatas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatas.Location = new System.Drawing.Point(0, 0);
            this.pnlDatas.Name = "pnlDatas";
            this.pnlDatas.Size = new System.Drawing.Size(333, 45);
            this.pnlDatas.TabIndex = 0;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(161, 15);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(23, 13);
            this.lblAte.TabIndex = 11;
            this.lblAte.Text = "Até";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(17, 15);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 10;
            this.lblDe.Text = "De";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(190, 13);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(120, 20);
            this.dtpAte.TabIndex = 9;
            this.dtpAte.ValueChanged += new System.EventHandler(this.DtpAte_ValueChanged);
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(41, 12);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(114, 20);
            this.dtpDe.TabIndex = 8;
            this.dtpDe.Value = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.dtpDe.ValueChanged += new System.EventHandler(this.DtpDe_ValueChanged);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvCompensa);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 45);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(333, 245);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvCompensa
            // 
            this.dgvCompensa.AllowUserToAddRows = false;
            this.dgvCompensa.AllowUserToDeleteRows = false;
            this.dgvCompensa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.dgvCompensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompensa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompensa.Location = new System.Drawing.Point(0, 0);
            this.dgvCompensa.Name = "dgvCompensa";
            this.dgvCompensa.ReadOnly = true;
            this.dgvCompensa.Size = new System.Drawing.Size(333, 245);
            this.dgvCompensa.TabIndex = 0;
            this.dgvCompensa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnlButtons.Controls.Add(this.btnCompensar);
            this.pnlButtons.Controls.Add(this.btnVoltar);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 253);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(333, 37);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnCompensar
            // 
            this.btnCompensar.BackColor = System.Drawing.Color.White;
            this.btnCompensar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompensar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCompensar.Image = ((System.Drawing.Image)(resources.GetObject("btnCompensar.Image")));
            this.btnCompensar.Location = new System.Drawing.Point(241, 0);
            this.btnCompensar.Name = "btnCompensar";
            this.btnCompensar.Size = new System.Drawing.Size(92, 37);
            this.btnCompensar.TabIndex = 2;
            this.btnCompensar.Text = "Compensar";
            this.btnCompensar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompensar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 37);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FCompensar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 290);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlDatas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCompensar";
            this.Text = "Compensar";
            this.pnlDatas.ResumeLayout(false);
            this.pnlDatas.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompensa)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatas;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCompensar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvCompensa;
    }
}