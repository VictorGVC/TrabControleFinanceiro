namespace TrabControleFinanceiro
{
    partial class FCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadastro));
            this.pnlDados = new System.Windows.Forms.Panel();
            this.cbDespesa = new System.Windows.Forms.ComboBox();
            this.pnlRbtnComp = new System.Windows.Forms.Panel();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.lCompensado = new System.Windows.Forms.Label();
            this.pnlRbtnTipo = new System.Windows.Forms.Panel();
            this.rbtnCrédito = new System.Windows.Forms.RadioButton();
            this.rbtnDebito = new System.Windows.Forms.RadioButton();
            this.lTipo = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.ttbValor = new System.Windows.Forms.TextBox();
            this.lData = new System.Windows.Forms.Label();
            this.lValor = new System.Windows.Forms.Label();
            this.lNomeDesp = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlDados.SuspendLayout();
            this.pnlRbtnComp.SuspendLayout();
            this.pnlRbtnTipo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnlDados.Controls.Add(this.cbDespesa);
            this.pnlDados.Controls.Add(this.pnlRbtnComp);
            this.pnlDados.Controls.Add(this.pnlRbtnTipo);
            this.pnlDados.Controls.Add(this.dtpData);
            this.pnlDados.Controls.Add(this.ttbValor);
            this.pnlDados.Controls.Add(this.lData);
            this.pnlDados.Controls.Add(this.lValor);
            this.pnlDados.Controls.Add(this.lNomeDesp);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDados.Location = new System.Drawing.Point(0, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(311, 128);
            this.pnlDados.TabIndex = 0;
            // 
            // cbDespesa
            // 
            this.cbDespesa.FormattingEnabled = true;
            this.cbDespesa.Location = new System.Drawing.Point(15, 24);
            this.cbDespesa.Name = "cbDespesa";
            this.cbDespesa.Size = new System.Drawing.Size(162, 21);
            this.cbDespesa.TabIndex = 7;
            // 
            // pnlRbtnComp
            // 
            this.pnlRbtnComp.Controls.Add(this.rbtnNao);
            this.pnlRbtnComp.Controls.Add(this.rbtnSim);
            this.pnlRbtnComp.Controls.Add(this.lCompensado);
            this.pnlRbtnComp.Location = new System.Drawing.Point(103, 51);
            this.pnlRbtnComp.Name = "pnlRbtnComp";
            this.pnlRbtnComp.Size = new System.Drawing.Size(74, 53);
            this.pnlRbtnComp.TabIndex = 6;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(3, 36);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(45, 17);
            this.rbtnNao.TabIndex = 7;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(3, 16);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnSim.TabIndex = 6;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // lCompensado
            // 
            this.lCompensado.AutoSize = true;
            this.lCompensado.Location = new System.Drawing.Point(0, 0);
            this.lCompensado.Name = "lCompensado";
            this.lCompensado.Size = new System.Drawing.Size(75, 13);
            this.lCompensado.TabIndex = 5;
            this.lCompensado.Text = "Compensação";
            // 
            // pnlRbtnTipo
            // 
            this.pnlRbtnTipo.Controls.Add(this.rbtnCrédito);
            this.pnlRbtnTipo.Controls.Add(this.rbtnDebito);
            this.pnlRbtnTipo.Controls.Add(this.lTipo);
            this.pnlRbtnTipo.Location = new System.Drawing.Point(15, 51);
            this.pnlRbtnTipo.Name = "pnlRbtnTipo";
            this.pnlRbtnTipo.Size = new System.Drawing.Size(71, 53);
            this.pnlRbtnTipo.TabIndex = 5;
            // 
            // rbtnCrédito
            // 
            this.rbtnCrédito.AutoSize = true;
            this.rbtnCrédito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCrédito.Location = new System.Drawing.Point(9, 36);
            this.rbtnCrédito.Name = "rbtnCrédito";
            this.rbtnCrédito.Size = new System.Drawing.Size(58, 17);
            this.rbtnCrédito.TabIndex = 5;
            this.rbtnCrédito.TabStop = true;
            this.rbtnCrédito.Text = "Crédito";
            this.rbtnCrédito.UseVisualStyleBackColor = true;
            // 
            // rbtnDebito
            // 
            this.rbtnDebito.AutoSize = true;
            this.rbtnDebito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnDebito.Location = new System.Drawing.Point(9, 16);
            this.rbtnDebito.Name = "rbtnDebito";
            this.rbtnDebito.Size = new System.Drawing.Size(56, 17);
            this.rbtnDebito.TabIndex = 4;
            this.rbtnDebito.TabStop = true;
            this.rbtnDebito.Text = "Débito";
            this.rbtnDebito.UseVisualStyleBackColor = true;
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(6, 0);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(28, 13);
            this.lTipo.TabIndex = 3;
            this.lTipo.Text = "Tipo";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(196, 25);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 3;
            // 
            // ttbValor
            // 
            this.ttbValor.Location = new System.Drawing.Point(196, 66);
            this.ttbValor.Name = "ttbValor";
            this.ttbValor.Size = new System.Drawing.Size(97, 20);
            this.ttbValor.TabIndex = 1;
            this.ttbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TtbValor_KeyPress);
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(193, 9);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(30, 13);
            this.lData.TabIndex = 0;
            this.lData.Text = "Data";
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(193, 50);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(31, 13);
            this.lValor.TabIndex = 0;
            this.lValor.Text = "Valor";
            // 
            // lNomeDesp
            // 
            this.lNomeDesp.AutoSize = true;
            this.lNomeDesp.Location = new System.Drawing.Point(12, 8);
            this.lNomeDesp.Name = "lNomeDesp";
            this.lNomeDesp.Size = new System.Drawing.Size(95, 13);
            this.lNomeDesp.TabIndex = 0;
            this.lNomeDesp.Text = "Nome da Despesa";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 124);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(311, 37);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 37);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(236, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 37);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // FCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 161);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCadastro";
            this.Text = "Cadastro";
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlRbtnComp.ResumeLayout(false);
            this.pnlRbtnComp.PerformLayout();
            this.pnlRbtnTipo.ResumeLayout(false);
            this.pnlRbtnTipo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox ttbValor;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.Label lNomeDesp;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
		private System.Windows.Forms.Panel pnlRbtnComp;
		private System.Windows.Forms.RadioButton rbtnNao;
		private System.Windows.Forms.RadioButton rbtnSim;
		private System.Windows.Forms.Label lCompensado;
		private System.Windows.Forms.Panel pnlRbtnTipo;
		private System.Windows.Forms.RadioButton rbtnCrédito;
		private System.Windows.Forms.RadioButton rbtnDebito;
		private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.ComboBox cbDespesa;
    }
}

