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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.GrbCadastroProd = new System.Windows.Forms.GroupBox();
            this.txbCategoriaCad = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.txbNomeProdCad = new System.Windows.Forms.TextBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.GrbEdProd = new System.Windows.Forms.GroupBox();
            this.txbCategoriaEd = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbPrecoEd = new System.Windows.Forms.TextBox();
            this.lblCategoriaEd = new System.Windows.Forms.Label();
            this.lblPrecoEd = new System.Windows.Forms.Label();
            this.txbNomeProdEd = new System.Windows.Forms.TextBox();
            this.lblNomeEd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GrbApagarProd = new System.Windows.Forms.GroupBox();
            this.btnApagarProd = new System.Windows.Forms.Button();
            this.lblApagarProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.GrbCadastroProd.SuspendLayout();
            this.GrbEdProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.GrbApagarProd.SuspendLayout();
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
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 44);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(588, 220);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // GrbCadastroProd
            // 
            this.GrbCadastroProd.Controls.Add(this.txbCategoriaCad);
            this.GrbCadastroProd.Controls.Add(this.btnCadastrar);
            this.GrbCadastroProd.Controls.Add(this.txbPrecoCad);
            this.GrbCadastroProd.Controls.Add(this.lblCategoriaCad);
            this.GrbCadastroProd.Controls.Add(this.lblPrecoCad);
            this.GrbCadastroProd.Controls.Add(this.txbNomeProdCad);
            this.GrbCadastroProd.Controls.Add(this.lblNomeCad);
            this.GrbCadastroProd.Location = new System.Drawing.Point(197, 270);
            this.GrbCadastroProd.Name = "GrbCadastroProd";
            this.GrbCadastroProd.Size = new System.Drawing.Size(177, 207);
            this.GrbCadastroProd.TabIndex = 2;
            this.GrbCadastroProd.TabStop = false;
            this.GrbCadastroProd.Text = "Cadastro de Produtos";
            // 
            // txbCategoriaCad
            // 
            this.txbCategoriaCad.Location = new System.Drawing.Point(60, 114);
            this.txbCategoriaCad.Name = "txbCategoriaCad";
            this.txbCategoriaCad.Size = new System.Drawing.Size(100, 20);
            this.txbCategoriaCad.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(22, 153);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 33);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Location = new System.Drawing.Point(60, 73);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(100, 20);
            this.txbPrecoCad.TabIndex = 4;
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Location = new System.Drawing.Point(6, 117);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaCad.TabIndex = 3;
            this.lblCategoriaCad.Text = "Categoria:";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Location = new System.Drawing.Point(19, 73);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoCad.TabIndex = 2;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // txbNomeProdCad
            // 
            this.txbNomeProdCad.Location = new System.Drawing.Point(60, 35);
            this.txbNomeProdCad.Name = "txbNomeProdCad";
            this.txbNomeProdCad.Size = new System.Drawing.Size(100, 20);
            this.txbNomeProdCad.TabIndex = 1;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(19, 35);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome:";
            // 
            // GrbEdProd
            // 
            this.GrbEdProd.Controls.Add(this.txbCategoriaEd);
            this.GrbEdProd.Controls.Add(this.btnEditar);
            this.GrbEdProd.Controls.Add(this.txbPrecoEd);
            this.GrbEdProd.Controls.Add(this.lblCategoriaEd);
            this.GrbEdProd.Controls.Add(this.lblPrecoEd);
            this.GrbEdProd.Controls.Add(this.txbNomeProdEd);
            this.GrbEdProd.Controls.Add(this.lblNomeEd);
            this.GrbEdProd.Location = new System.Drawing.Point(390, 270);
            this.GrbEdProd.Name = "GrbEdProd";
            this.GrbEdProd.Size = new System.Drawing.Size(176, 207);
            this.GrbEdProd.TabIndex = 6;
            this.GrbEdProd.TabStop = false;
            this.GrbEdProd.Text = "Editar Produto";
            // 
            // txbCategoriaEd
            // 
            this.txbCategoriaEd.Location = new System.Drawing.Point(60, 114);
            this.txbCategoriaEd.Name = "txbCategoriaEd";
            this.txbCategoriaEd.Size = new System.Drawing.Size(100, 20);
            this.txbCategoriaEd.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(22, 153);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 33);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbPrecoEd
            // 
            this.txbPrecoEd.Location = new System.Drawing.Point(60, 73);
            this.txbPrecoEd.Name = "txbPrecoEd";
            this.txbPrecoEd.Size = new System.Drawing.Size(100, 20);
            this.txbPrecoEd.TabIndex = 4;
            // 
            // lblCategoriaEd
            // 
            this.lblCategoriaEd.AutoSize = true;
            this.lblCategoriaEd.Location = new System.Drawing.Point(6, 117);
            this.lblCategoriaEd.Name = "lblCategoriaEd";
            this.lblCategoriaEd.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaEd.TabIndex = 3;
            this.lblCategoriaEd.Text = "Categoria:";
            // 
            // lblPrecoEd
            // 
            this.lblPrecoEd.AutoSize = true;
            this.lblPrecoEd.Location = new System.Drawing.Point(10, 76);
            this.lblPrecoEd.Name = "lblPrecoEd";
            this.lblPrecoEd.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoEd.TabIndex = 2;
            this.lblPrecoEd.Text = "Preço:";
            // 
            // txbNomeProdEd
            // 
            this.txbNomeProdEd.Location = new System.Drawing.Point(60, 35);
            this.txbNomeProdEd.Name = "txbNomeProdEd";
            this.txbNomeProdEd.Size = new System.Drawing.Size(100, 20);
            this.txbNomeProdEd.TabIndex = 1;
            // 
            // lblNomeEd
            // 
            this.lblNomeEd.AutoSize = true;
            this.lblNomeEd.Location = new System.Drawing.Point(19, 35);
            this.lblNomeEd.Name = "lblNomeEd";
            this.lblNomeEd.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEd.TabIndex = 0;
            this.lblNomeEd.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Padarosa2023.Properties.Resources.caracteristicas;
            this.pictureBox1.Location = new System.Drawing.Point(12, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GrbApagarProd
            // 
            this.GrbApagarProd.Controls.Add(this.btnApagarProd);
            this.GrbApagarProd.Controls.Add(this.lblApagarProd);
            this.GrbApagarProd.Enabled = false;
            this.GrbApagarProd.Location = new System.Drawing.Point(257, 488);
            this.GrbApagarProd.Name = "GrbApagarProd";
            this.GrbApagarProd.Size = new System.Drawing.Size(252, 46);
            this.GrbApagarProd.TabIndex = 10;
            this.GrbApagarProd.TabStop = false;
            this.GrbApagarProd.Text = "Apagar";
            // 
            // btnApagarProd
            // 
            this.btnApagarProd.BackColor = System.Drawing.Color.Red;
            this.btnApagarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarProd.ForeColor = System.Drawing.Color.Black;
            this.btnApagarProd.Location = new System.Drawing.Point(176, 19);
            this.btnApagarProd.Name = "btnApagarProd";
            this.btnApagarProd.Size = new System.Drawing.Size(70, 21);
            this.btnApagarProd.TabIndex = 1;
            this.btnApagarProd.Text = "Apagar";
            this.btnApagarProd.UseVisualStyleBackColor = false;
            this.btnApagarProd.Click += new System.EventHandler(this.btnApagarProd_Click);
            // 
            // lblApagarProd
            // 
            this.lblApagarProd.AutoSize = true;
            this.lblApagarProd.Location = new System.Drawing.Point(7, 27);
            this.lblApagarProd.Name = "lblApagarProd";
            this.lblApagarProd.Size = new System.Drawing.Size(165, 13);
            this.lblApagarProd.TabIndex = 0;
            this.lblApagarProd.Text = "Selecione o produto para apagar.";
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 546);
            this.Controls.Add(this.GrbApagarProd);
            this.Controls.Add(this.GrbEdProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrbCadastroProd);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "GerenciamentoProdutos";
            this.Text = "GerenciamentoProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.GrbCadastroProd.ResumeLayout(false);
            this.GrbCadastroProd.PerformLayout();
            this.GrbEdProd.ResumeLayout(false);
            this.GrbEdProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.GrbApagarProd.ResumeLayout(false);
            this.GrbApagarProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox GrbCadastroProd;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.TextBox txbNomeProdCad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.GroupBox GrbEdProd;
        private System.Windows.Forms.TextBox txbPrecoEd;
        private System.Windows.Forms.Label lblCategoriaEd;
        private System.Windows.Forms.Label lblPrecoEd;
        private System.Windows.Forms.TextBox txbNomeProdEd;
        private System.Windows.Forms.Label lblNomeEd;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox GrbApagarProd;
        private System.Windows.Forms.Button btnApagarProd;
        private System.Windows.Forms.Label lblApagarProd;
        private System.Windows.Forms.TextBox txbCategoriaCad;
        private System.Windows.Forms.TextBox txbCategoriaEd;
    }
}