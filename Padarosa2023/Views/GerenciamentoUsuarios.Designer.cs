namespace Padarosa2023.Views
{
    partial class GerenciamentoUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.GrbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.GrbEditar = new System.Windows.Forms.GroupBox();
            this.btnEd = new System.Windows.Forms.Button();
            this.txbSenhaEd = new System.Windows.Forms.TextBox();
            this.txbEmailEd = new System.Windows.Forms.TextBox();
            this.txbNomeEd = new System.Windows.Forms.TextBox();
            this.lblSenhaEd = new System.Windows.Forms.Label();
            this.lblEmailEd = new System.Windows.Forms.Label();
            this.lblNomeEd = new System.Windows.Forms.Label();
            this.GrbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblAp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.GrbCadastro.SuspendLayout();
            this.GrbEditar.SuspendLayout();
            this.GrbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 44);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(549, 244);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // GrbCadastro
            // 
            this.GrbCadastro.Controls.Add(this.btnCad);
            this.GrbCadastro.Controls.Add(this.txbSenhaCad);
            this.GrbCadastro.Controls.Add(this.txbEmailCad);
            this.GrbCadastro.Controls.Add(this.txbNomeCad);
            this.GrbCadastro.Controls.Add(this.lblSenhaCad);
            this.GrbCadastro.Controls.Add(this.lblEmailCad);
            this.GrbCadastro.Controls.Add(this.lblNomeCad);
            this.GrbCadastro.Location = new System.Drawing.Point(146, 294);
            this.GrbCadastro.Name = "GrbCadastro";
            this.GrbCadastro.Size = new System.Drawing.Size(205, 156);
            this.GrbCadastro.TabIndex = 1;
            this.GrbCadastro.TabStop = false;
            this.GrbCadastro.Text = "Cadastro";
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.Lime;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCad.Location = new System.Drawing.Point(25, 110);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(141, 28);
            this.btnCad.TabIndex = 7;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Location = new System.Drawing.Point(94, 84);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.Size = new System.Drawing.Size(102, 20);
            this.txbSenhaCad.TabIndex = 6;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(94, 58);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(102, 20);
            this.txbEmailCad.TabIndex = 4;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(94, 32);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(102, 20);
            this.txbNomeCad.TabIndex = 3;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(49, 87);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCad.TabIndex = 2;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(52, 58);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 1;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 32);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome Completo:";
            // 
            // GrbEditar
            // 
            this.GrbEditar.Controls.Add(this.btnEd);
            this.GrbEditar.Controls.Add(this.txbSenhaEd);
            this.GrbEditar.Controls.Add(this.txbEmailEd);
            this.GrbEditar.Controls.Add(this.txbNomeEd);
            this.GrbEditar.Controls.Add(this.lblSenhaEd);
            this.GrbEditar.Controls.Add(this.lblEmailEd);
            this.GrbEditar.Controls.Add(this.lblNomeEd);
            this.GrbEditar.Enabled = false;
            this.GrbEditar.Location = new System.Drawing.Point(357, 294);
            this.GrbEditar.Name = "GrbEditar";
            this.GrbEditar.Size = new System.Drawing.Size(205, 156);
            this.GrbEditar.TabIndex = 8;
            this.GrbEditar.TabStop = false;
            this.GrbEditar.Text = "Edição";
            // 
            // btnEd
            // 
            this.btnEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEd.Location = new System.Drawing.Point(25, 110);
            this.btnEd.Name = "btnEd";
            this.btnEd.Size = new System.Drawing.Size(141, 28);
            this.btnEd.TabIndex = 7;
            this.btnEd.Text = "Editar";
            this.btnEd.UseVisualStyleBackColor = false;
            this.btnEd.Click += new System.EventHandler(this.btnEd_Click);
            // 
            // txbSenhaEd
            // 
            this.txbSenhaEd.Location = new System.Drawing.Point(94, 84);
            this.txbSenhaEd.Name = "txbSenhaEd";
            this.txbSenhaEd.Size = new System.Drawing.Size(102, 20);
            this.txbSenhaEd.TabIndex = 6;
            // 
            // txbEmailEd
            // 
            this.txbEmailEd.Location = new System.Drawing.Point(94, 58);
            this.txbEmailEd.Name = "txbEmailEd";
            this.txbEmailEd.Size = new System.Drawing.Size(102, 20);
            this.txbEmailEd.TabIndex = 4;
            // 
            // txbNomeEd
            // 
            this.txbNomeEd.Location = new System.Drawing.Point(94, 32);
            this.txbNomeEd.Name = "txbNomeEd";
            this.txbNomeEd.Size = new System.Drawing.Size(102, 20);
            this.txbNomeEd.TabIndex = 3;
            // 
            // lblSenhaEd
            // 
            this.lblSenhaEd.AutoSize = true;
            this.lblSenhaEd.Location = new System.Drawing.Point(49, 87);
            this.lblSenhaEd.Name = "lblSenhaEd";
            this.lblSenhaEd.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaEd.TabIndex = 2;
            this.lblSenhaEd.Text = "Senha:";
            // 
            // lblEmailEd
            // 
            this.lblEmailEd.AutoSize = true;
            this.lblEmailEd.Location = new System.Drawing.Point(52, 58);
            this.lblEmailEd.Name = "lblEmailEd";
            this.lblEmailEd.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEd.TabIndex = 1;
            this.lblEmailEd.Text = "Email:";
            // 
            // lblNomeEd
            // 
            this.lblNomeEd.AutoSize = true;
            this.lblNomeEd.Location = new System.Drawing.Point(6, 32);
            this.lblNomeEd.Name = "lblNomeEd";
            this.lblNomeEd.Size = new System.Drawing.Size(85, 13);
            this.lblNomeEd.TabIndex = 0;
            this.lblNomeEd.Text = "Nome Completo:";
            // 
            // GrbApagar
            // 
            this.GrbApagar.Controls.Add(this.btnApagar);
            this.GrbApagar.Controls.Add(this.lblAp);
            this.GrbApagar.Enabled = false;
            this.GrbApagar.Location = new System.Drawing.Point(201, 456);
            this.GrbApagar.Name = "GrbApagar";
            this.GrbApagar.Size = new System.Drawing.Size(252, 46);
            this.GrbApagar.TabIndex = 9;
            this.GrbApagar.TabStop = false;
            this.GrbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(176, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(70, 21);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.Location = new System.Drawing.Point(7, 27);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(163, 13);
            this.lblAp.TabIndex = 0;
            this.lblAp.Text = "Selecione o usuário para apagar.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Padarosa2023.Properties.Resources.Custom_Icon_Design_Pretty_Office_13_Users_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(167, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 24);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Gerenciador de Usuários";
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 502);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.GrbApagar);
            this.Controls.Add(this.GrbEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuarios";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.GrbCadastro.ResumeLayout(false);
            this.GrbCadastro.PerformLayout();
            this.GrbEditar.ResumeLayout(false);
            this.GrbEditar.PerformLayout();
            this.GrbApagar.ResumeLayout(false);
            this.GrbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox GrbCadastro;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txbSenhaCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GrbEditar;
        private System.Windows.Forms.Button btnEd;
        private System.Windows.Forms.TextBox txbSenhaEd;
        private System.Windows.Forms.TextBox txbEmailEd;
        private System.Windows.Forms.TextBox txbNomeEd;
        private System.Windows.Forms.Label lblSenhaEd;
        private System.Windows.Forms.Label lblEmailEd;
        private System.Windows.Forms.Label lblNomeEd;
        private System.Windows.Forms.GroupBox GrbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblAp;
        private System.Windows.Forms.Label lblTitulo;
    }
}