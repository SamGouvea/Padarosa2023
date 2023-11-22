namespace Padarosa2023.Views
{
    partial class GerenciamentoComanda
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
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblProdutoLan = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbProdutoLan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComanda
            // 
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Location = new System.Drawing.Point(256, 34);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.Size = new System.Drawing.Size(392, 503);
            this.dgvComanda.TabIndex = 0;
            this.dgvComanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComanda_CellClick);
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(24, 40);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(85, 18);
            this.lblComanda.TabIndex = 1;
            this.lblComanda.Text = "Comanda:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(0, 125);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(109, 18);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Cód Produto:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(115, 33);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(98, 29);
            this.txbComanda.TabIndex = 3;
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(115, 118);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(103, 29);
            this.txbCodProduto.TabIndex = 4;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Lime;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(10, 183);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(193, 43);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.lblProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.txbCodProduto);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 34);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(224, 240);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.lblProdutoLan);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.lblQuantidade);
            this.grbLancamento.Controls.Add(this.txbProdutoLan);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Location = new System.Drawing.Point(12, 297);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(224, 209);
            this.grbLancamento.TabIndex = 7;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(108, 109);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(110, 24);
            this.txbQuantidade.TabIndex = 6;
            // 
            // lblProdutoLan
            // 
            this.lblProdutoLan.AutoSize = true;
            this.lblProdutoLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLan.Location = new System.Drawing.Point(29, 44);
            this.lblProdutoLan.Name = "lblProdutoLan";
            this.lblProdutoLan.Size = new System.Drawing.Size(73, 18);
            this.lblProdutoLan.TabIndex = 1;
            this.lblProdutoLan.Text = "Produto:";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.Lime;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(10, 151);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(193, 43);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(4, 112);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(98, 18);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txbProdutoLan
            // 
            this.txbProdutoLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutoLan.Location = new System.Drawing.Point(108, 41);
            this.txbProdutoLan.Name = "txbProdutoLan";
            this.txbProdutoLan.Size = new System.Drawing.Size(110, 24);
            this.txbProdutoLan.TabIndex = 3;
            // 
            // GerenciamentoComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 555);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvComanda);
            this.Name = "GerenciamentoComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoComanda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblProdutoLan;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbProdutoLan;
    }
}