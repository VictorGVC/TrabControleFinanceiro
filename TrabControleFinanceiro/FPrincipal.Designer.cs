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
			this.pnlDados = new System.Windows.Forms.Panel();
			this.dtpData = new System.Windows.Forms.DateTimePicker();
			this.rbtnCrédito = new System.Windows.Forms.RadioButton();
			this.rbtnDebito = new System.Windows.Forms.RadioButton();
			this.ttbCompensa = new System.Windows.Forms.TextBox();
			this.ttbNome = new System.Windows.Forms.TextBox();
			this.ttbCodLan = new System.Windows.Forms.TextBox();
			this.ttbValor = new System.Windows.Forms.TextBox();
			this.ttbCodDesp = new System.Windows.Forms.TextBox();
			this.lCodLan = new System.Windows.Forms.Label();
			this.lData = new System.Windows.Forms.Label();
			this.lValor = new System.Windows.Forms.Label();
			this.lCompensado = new System.Windows.Forms.Label();
			this.lTipo = new System.Windows.Forms.Label();
			this.lNomeDesp = new System.Windows.Forms.Label();
			this.lCodDesp = new System.Windows.Forms.Label();
			this.pnlBotoes = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGravar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnInserir = new System.Windows.Forms.Button();
			this.pnlDados.SuspendLayout();
			this.pnlBotoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDados
			// 
			this.pnlDados.BackColor = System.Drawing.Color.DarkOrange;
			this.pnlDados.Controls.Add(this.dtpData);
			this.pnlDados.Controls.Add(this.rbtnCrédito);
			this.pnlDados.Controls.Add(this.rbtnDebito);
			this.pnlDados.Controls.Add(this.ttbCompensa);
			this.pnlDados.Controls.Add(this.ttbNome);
			this.pnlDados.Controls.Add(this.ttbCodLan);
			this.pnlDados.Controls.Add(this.ttbValor);
			this.pnlDados.Controls.Add(this.ttbCodDesp);
			this.pnlDados.Controls.Add(this.lCodLan);
			this.pnlDados.Controls.Add(this.lData);
			this.pnlDados.Controls.Add(this.lValor);
			this.pnlDados.Controls.Add(this.lCompensado);
			this.pnlDados.Controls.Add(this.lTipo);
			this.pnlDados.Controls.Add(this.lNomeDesp);
			this.pnlDados.Controls.Add(this.lCodDesp);
			this.pnlDados.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDados.Location = new System.Drawing.Point(0, 0);
			this.pnlDados.Name = "pnlDados";
			this.pnlDados.Size = new System.Drawing.Size(634, 116);
			this.pnlDados.TabIndex = 0;
			// 
			// dtpData
			// 
			this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpData.Location = new System.Drawing.Point(476, 72);
			this.dtpData.Name = "dtpData";
			this.dtpData.Size = new System.Drawing.Size(97, 20);
			this.dtpData.TabIndex = 3;
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
			// ttbCompensa
			// 
			this.ttbCompensa.Location = new System.Drawing.Point(252, 72);
			this.ttbCompensa.Name = "ttbCompensa";
			this.ttbCompensa.Size = new System.Drawing.Size(165, 20);
			this.ttbCompensa.TabIndex = 1;
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
			// ttbValor
			// 
			this.ttbValor.Location = new System.Drawing.Point(423, 72);
			this.ttbValor.Name = "ttbValor";
			this.ttbValor.Size = new System.Drawing.Size(47, 20);
			this.ttbValor.TabIndex = 1;
			// 
			// ttbCodDesp
			// 
			this.ttbCodDesp.Enabled = false;
			this.ttbCodDesp.Location = new System.Drawing.Point(15, 26);
			this.ttbCodDesp.Name = "ttbCodDesp";
			this.ttbCodDesp.Size = new System.Drawing.Size(47, 20);
			this.ttbCodDesp.TabIndex = 1;
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
			// lData
			// 
			this.lData.AutoSize = true;
			this.lData.Location = new System.Drawing.Point(473, 56);
			this.lData.Name = "lData";
			this.lData.Size = new System.Drawing.Size(30, 13);
			this.lData.TabIndex = 0;
			this.lData.Text = "Data";
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
			// lCompensado
			// 
			this.lCompensado.AutoSize = true;
			this.lCompensado.Location = new System.Drawing.Point(249, 56);
			this.lCompensado.Name = "lCompensado";
			this.lCompensado.Size = new System.Drawing.Size(75, 13);
			this.lCompensado.TabIndex = 0;
			this.lCompensado.Text = "Compensação";
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
			// lNomeDesp
			// 
			this.lNomeDesp.AutoSize = true;
			this.lNomeDesp.Location = new System.Drawing.Point(156, 10);
			this.lNomeDesp.Name = "lNomeDesp";
			this.lNomeDesp.Size = new System.Drawing.Size(95, 13);
			this.lNomeDesp.TabIndex = 0;
			this.lNomeDesp.Text = "Nome da Despesa";
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
			// pnlBotoes
			// 
			this.pnlBotoes.BackColor = System.Drawing.Color.Linen;
			this.pnlBotoes.Controls.Add(this.btnCancelar);
			this.pnlBotoes.Controls.Add(this.btnGravar);
			this.pnlBotoes.Controls.Add(this.btnFechar);
			this.pnlBotoes.Controls.Add(this.btnConsultar);
			this.pnlBotoes.Controls.Add(this.btnExcluir);
			this.pnlBotoes.Controls.Add(this.btnInserir);
			this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBotoes.Location = new System.Drawing.Point(0, 117);
			this.pnlBotoes.Name = "pnlBotoes";
			this.pnlBotoes.Size = new System.Drawing.Size(634, 44);
			this.pnlBotoes.TabIndex = 1;
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCancelar.Location = new System.Drawing.Point(300, 0);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 44);
			this.btnCancelar.TabIndex = 16;
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
			this.btnGravar.TabIndex = 15;
			this.btnGravar.Text = "Gravar";
			this.btnGravar.UseVisualStyleBackColor = true;
			this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
			this.btnFechar.Location = new System.Drawing.Point(559, 0);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(75, 44);
			this.btnFechar.TabIndex = 13;
			this.btnFechar.Text = " Fechar";
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnConsultar.Location = new System.Drawing.Point(150, 0);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 44);
			this.btnConsultar.TabIndex = 12;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnExcluir.Location = new System.Drawing.Point(75, 0);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 44);
			this.btnExcluir.TabIndex = 9;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnInserir.Location = new System.Drawing.Point(0, 0);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(75, 44);
			this.btnInserir.TabIndex = 7;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 161);
			this.Controls.Add(this.pnlBotoes);
			this.Controls.Add(this.pnlDados);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FPrincipal";
			this.Text = "Controle Financeiro";
			this.pnlDados.ResumeLayout(false);
			this.pnlDados.PerformLayout();
			this.pnlBotoes.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
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
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}

