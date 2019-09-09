namespace TrabControleFinanceiro
{
    partial class FConsulta
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
            this.ldescricao = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btordenar = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ldescricao
            // 
            this.ldescricao.AutoSize = true;
            this.ldescricao.Location = new System.Drawing.Point(13, 13);
            this.ldescricao.Name = "ldescricao";
            this.ldescricao.Size = new System.Drawing.Size(106, 13);
            this.ldescricao.TabIndex = 0;
            this.ldescricao.Text = "Selecionar descrição";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btordenar
            // 
            this.btordenar.Location = new System.Drawing.Point(125, 13);
            this.btordenar.Name = "btordenar";
            this.btordenar.Size = new System.Drawing.Size(75, 40);
            this.btordenar.TabIndex = 2;
            this.btordenar.Text = "Ordenar";
            this.btordenar.UseVisualStyleBackColor = true;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(251, 12);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(35, 13);
            this.l.TabIndex = 3;
            this.l.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 321);
            this.dataGridView1.TabIndex = 4;
            // 
            // FConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.btordenar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ldescricao);
            this.Name = "FConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldescricao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btordenar;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}