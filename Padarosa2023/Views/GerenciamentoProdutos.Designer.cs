namespace Padarosa2023.Views
{
    partial class GerenciamentoProdutos
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbCadastroProd = new System.Windows.Forms.GroupBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.txbProdutoCad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumeroCad = new System.Windows.Forms.Label();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbCadastroProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(193, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciador de Produtos";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 220);
            this.dataGridView1.TabIndex = 1;
            // 
            // grbCadastroProd
            // 
            this.grbCadastroProd.Controls.Add(this.lblCategoriaCad);
            this.grbCadastroProd.Controls.Add(this.lblNumeroCad);
            this.grbCadastroProd.Controls.Add(this.txbProdutoCad);
            this.grbCadastroProd.Controls.Add(this.lblNomeCad);
            this.grbCadastroProd.Location = new System.Drawing.Point(197, 270);
            this.grbCadastroProd.Name = "grbCadastroProd";
            this.grbCadastroProd.Size = new System.Drawing.Size(181, 186);
            this.grbCadastroProd.TabIndex = 2;
            this.grbCadastroProd.TabStop = false;
            this.grbCadastroProd.Text = "Cadastro de Produtos";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(16, 35);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome:";
            // 
            // txbProdutoCad
            // 
            this.txbProdutoCad.Location = new System.Drawing.Point(69, 35);
            this.txbProdutoCad.Name = "txbProdutoCad";
            this.txbProdutoCad.Size = new System.Drawing.Size(100, 20);
            this.txbProdutoCad.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 174);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblNumeroCad
            // 
            this.lblNumeroCad.AutoSize = true;
            this.lblNumeroCad.Location = new System.Drawing.Point(16, 73);
            this.lblNumeroCad.Name = "lblNumeroCad";
            this.lblNumeroCad.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroCad.TabIndex = 2;
            this.lblNumeroCad.Text = "Número:";
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Location = new System.Drawing.Point(19, 115);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaCad.TabIndex = 3;
            this.lblCategoriaCad.Text = "Categoria:";
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbCadastroProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "GerenciamentoProdutos";
            this.Text = "GerenciamentoProdutos";
            this.Load += new System.EventHandler(this.GerenciamentoProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbCadastroProd.ResumeLayout(false);
            this.grbCadastroProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbCadastroProd;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.TextBox txbProdutoCad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblNumeroCad;
    }
}