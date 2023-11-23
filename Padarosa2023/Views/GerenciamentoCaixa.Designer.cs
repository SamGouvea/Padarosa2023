namespace Padarosa2023.Views
{
    partial class GerenciamentoCaixa
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
            this.lblNumComanda = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.dgvFicha = new System.Windows.Forms.DataGridView();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.chbPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumComanda
            // 
            this.lblNumComanda.AutoSize = true;
            this.lblNumComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumComanda.Location = new System.Drawing.Point(60, 49);
            this.lblNumComanda.Name = "lblNumComanda";
            this.lblNumComanda.Size = new System.Drawing.Size(150, 25);
            this.lblNumComanda.TabIndex = 0;
            this.lblNumComanda.Text = "N° Comanda:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(216, 49);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(91, 35);
            this.txbComanda.TabIndex = 1;
            // 
            // dgvFicha
            // 
            this.dgvFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFicha.Location = new System.Drawing.Point(12, 104);
            this.dgvFicha.Name = "dgvFicha";
            this.dgvFicha.Size = new System.Drawing.Size(542, 222);
            this.dgvFicha.TabIndex = 3;
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(176, 9);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(200, 25);
            this.lblCaixa.TabIndex = 4;
            this.lblCaixa.Text = "Caixa :: Padarosa";
            // 
            // chbPagamentoRecebido
            // 
            this.chbPagamentoRecebido.AutoSize = true;
            this.chbPagamentoRecebido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbPagamentoRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoRecebido.Location = new System.Drawing.Point(375, 380);
            this.chbPagamentoRecebido.Name = "chbPagamentoRecebido";
            this.chbPagamentoRecebido.Size = new System.Drawing.Size(170, 17);
            this.chbPagamentoRecebido.TabIndex = 5;
            this.chbPagamentoRecebido.Text = "PAGAMENTO RECEBIDO";
            this.chbPagamentoRecebido.UseVisualStyleBackColor = true;
            this.chbPagamentoRecebido.CheckedChanged += new System.EventHandler(this.chbPagamentoRecebido_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Lime;
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(375, 403);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(170, 28);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "ENCERRAR COMANDA";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(370, 338);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 29);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "R$ 00,00";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Padarosa2023.Properties.Resources.lupa;
            this.btnBuscar.Location = new System.Drawing.Point(313, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 35);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Padarosa2023.Properties.Resources.caixa_eletronico;
            this.pictureBox1.Location = new System.Drawing.Point(65, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // GerenciamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 451);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbPagamentoRecebido);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.dgvFicha);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.lblNumComanda);
            this.Name = "GerenciamentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumComanda;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.DataGridView dgvFicha;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.CheckBox chbPagamentoRecebido;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnBuscar;
    }
}