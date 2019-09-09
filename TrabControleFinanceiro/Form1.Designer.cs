namespace TrabControleFinanceiro
{
    partial class FPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lCodDesp = new System.Windows.Forms.Label();
            this.lNomeDesp = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.lCodLan = new System.Windows.Forms.Label();
            this.lCompensado = new System.Windows.Forms.Label();
            this.lValor = new System.Windows.Forms.Label();
            this.ttbCodDesp = new System.Windows.Forms.TextBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.ttbCodLan = new System.Windows.Forms.TextBox();
            this.rbtnDebito = new System.Windows.Forms.RadioButton();
            this.rbtnCrédito = new System.Windows.Forms.RadioButton();
            this.ttbCompensa = new System.Windows.Forms.TextBox();
            this.ttbValor = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lData = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.rbtnCrédito);
            this.panel1.Controls.Add(this.rbtnDebito);
            this.panel1.Controls.Add(this.ttbCompensa);
            this.panel1.Controls.Add(this.ttbNome);
            this.panel1.Controls.Add(this.ttbCodLan);
            this.panel1.Controls.Add(this.ttbValor);
            this.panel1.Controls.Add(this.ttbCodDesp);
            this.panel1.Controls.Add(this.lCodLan);
            this.panel1.Controls.Add(this.lData);
            this.panel1.Controls.Add(this.lValor);
            this.panel1.Controls.Add(this.lCompensado);
            this.panel1.Controls.Add(this.lTipo);
            this.panel1.Controls.Add(this.lNomeDesp);
            this.panel1.Controls.Add(this.lCodDesp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 116);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.btnLocalizar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGravar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnIncluir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 44);
            this.panel2.TabIndex = 1;
            // 
            // lCodDesp
            // 
            this.lCodDesp.AutoSize = true;
            this.lCodDesp.Location = new System.Drawing.Point(12, 9);
            this.lCodDesp.Name = "lCodDesp";
            this.lCodDesp.Size = new System.Drawing.Size(100, 13);
            this.lCodDesp.TabIndex = 0;
            this.lCodDesp.Text = "Código da Despesa";
            // 
            // lNomeDesp
            // 
            this.lNomeDesp.AutoSize = true;
            this.lNomeDesp.Location = new System.Drawing.Point(156, 10);
            this.lNomeDesp.Name = "lNomeDesp";
            this.lNomeDesp.Size = new System.Drawing.Size(95, 13);
            this.lNomeDesp.TabIndex = 0;
            this.lNomeDesp.Text = "Nome da Despesa";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(156, 56);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(28, 13);
            this.lTipo.TabIndex = 0;
            this.lTipo.Text = "Tipo";
            // 
            // lCodLan
            // 
            this.lCodLan.AutoSize = true;
            this.lCodLan.Location = new System.Drawing.Point(12, 56);
            this.lCodLan.Name = "lCodLan";
            this.lCodLan.Size = new System.Drawing.Size(117, 13);
            this.lCodLan.TabIndex = 0;
            this.lCodLan.Text = "Código do Lançamento";
            // 
            // lCompensado
            // 
            this.lCompensado.AutoSize = true;
            this.lCompensado.Location = new System.Drawing.Point(249, 56);
            this.lCompensado.Name = "lCompensado";
            this.lCompensado.Size = new System.Drawing.Size(75, 13);
            this.lCompensado.TabIndex = 0;
            this.lCompensado.Text = "Compensação";
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(420, 56);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(31, 13);
            this.lValor.TabIndex = 0;
            this.lValor.Text = "Valor";
            // 
            // ttbCodDesp
            // 
            this.ttbCodDesp.Enabled = false;
            this.ttbCodDesp.Location = new System.Drawing.Point(15, 26);
            this.ttbCodDesp.Name = "ttbCodDesp";
            this.ttbCodDesp.Size = new System.Drawing.Size(47, 20);
            this.ttbCodDesp.TabIndex = 1;
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(159, 26);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(258, 20);
            this.ttbNome.TabIndex = 1;
            // 
            // ttbCodLan
            // 
            this.ttbCodLan.Enabled = false;
            this.ttbCodLan.Location = new System.Drawing.Point(15, 72);
            this.ttbCodLan.Name = "ttbCodLan";
            this.ttbCodLan.Size = new System.Drawing.Size(47, 20);
            this.ttbCodLan.TabIndex = 1;
            // 
            // rbtnDebito
            // 
            this.rbtnDebito.AutoSize = true;
            this.rbtnDebito.Location = new System.Drawing.Point(159, 72);
            this.rbtnDebito.Name = "rbtnDebito";
            this.rbtnDebito.Size = new System.Drawing.Size(56, 17);
            this.rbtnDebito.TabIndex = 2;
            this.rbtnDebito.TabStop = true;
            this.rbtnDebito.Text = "Débito";
            this.rbtnDebito.UseVisualStyleBackColor = true;
            // 
            // rbtnCrédito
            // 
            this.rbtnCrédito.AutoSize = true;
            this.rbtnCrédito.Location = new System.Drawing.Point(159, 92);
            this.rbtnCrédito.Name = "rbtnCrédito";
            this.rbtnCrédito.Size = new System.Drawing.Size(58, 17);
            this.rbtnCrédito.TabIndex = 2;
            this.rbtnCrédito.TabStop = true;
            this.rbtnCrédito.Text = "Crédito";
            this.rbtnCrédito.UseVisualStyleBackColor = true;
            // 
            // ttbCompensa
            // 
            this.ttbCompensa.Location = new System.Drawing.Point(252, 72);
            this.ttbCompensa.Name = "ttbCompensa";
            this.ttbCompensa.Size = new System.Drawing.Size(165, 20);
            this.ttbCompensa.TabIndex = 1;
            // 
            // ttbValor
            // 
            this.ttbValor.Location = new System.Drawing.Point(423, 72);
            this.ttbValor.Name = "ttbValor";
            this.ttbValor.Size = new System.Drawing.Size(47, 20);
            this.ttbValor.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(476, 72);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 3;
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(473, 56);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(30, 13);
            this.lData.TabIndex = 0;
            this.lData.Text = "Data";
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Location = new System.Drawing.Point(559, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 44);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.Location = new System.Drawing.Point(375, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 44);
            this.btnLocalizar.TabIndex = 12;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Location = new System.Drawing.Point(300, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 44);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Location = new System.Drawing.Point(225, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 44);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Location = new System.Drawing.Point(150, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 44);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlterar.Location = new System.Drawing.Point(75, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIncluir.Location = new System.Drawing.Point(0, 0);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 44);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 161);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPrincipal";
            this.Text = "Controle Financeiro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.RadioButton rbtnCrédito;
        private System.Windows.Forms.RadioButton rbtnDebito;
        private System.Windows.Forms.TextBox ttbCompensa;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.TextBox ttbCodLan;
        private System.Windows.Forms.TextBox ttbValor;
        private System.Windows.Forms.TextBox ttbCodDesp;
        private System.Windows.Forms.Label lCodLan;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.Label lCompensado;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.Label lNomeDesp;
        private System.Windows.Forms.Label lCodDesp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
    }
}

