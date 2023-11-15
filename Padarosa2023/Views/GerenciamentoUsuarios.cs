using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa2023.Views
{
    public partial class GerenciamentoUsuarios : Form
    {
        // Atributos Globais:
        int idSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            // Obter os valores dos campos:
            usuario.NomeCompleto = txbNomeCad.Text;
            usuario.Email = txbEmailCad.Text;
            usuario.Senha = txbSenhaCad.Text;

            if(usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbSenhaCad.Clear();
                // Atualizar o dgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            GrbEditar.Enabled = true;
            GrbApagar.Enabled = true;   

            // obter a linha clicada:
            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            txbNomeEd.Text = linha.Cells[1].Value.ToString();
            txbEmailEd.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID o nome para existir no apagar:
            lblAp.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id= idSelecionado;
            // Apagar:
           var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if(usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dgvUsuarios.DataSource = usuario.ListarTudo();
                    // Limpar os campos da edição:
                    txbEmailEd.Clear();
                    txbNomeEd.Clear();
                    txbSenhaEd.Clear();
                    lblAp.Text = "Selecione um usuário para apagar.";
                    // Desabilitar os grbs:
                    GrbApagar.Enabled = false;
                    GrbEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover usuário!", "Falha!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEd_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario= new Classes.Usuario();
            usuario.Id = idSelecionado;
            usuario.NomeCompleto = txbNomeEd.Text;
            usuario.Email = txbEmailEd.Text;
            usuario.Senha = txbSenhaEd.Text;    

            // Editar:
            if(usuario.Modificar() == true)
            {
                MessageBox.Show("Usuário modificado!", "Sucesso!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information );
                // Atualizar o dgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
                // Limpar os campos da edição:
                txbEmailEd.Clear();
                txbNomeEd.Clear();
                txbSenhaEd.Clear();
                lblAp.Text = "Selecione um usuário para apagar.";
                // Desabilitar os grbs:
                GrbApagar.Enabled = false;
                GrbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar usuário!", "Falha!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}
