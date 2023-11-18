using Padarosa2023.Classes;
using System;
using System.Collections;
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
    public partial class GerenciamentoProdutos : Form
    {
        int idSelecionado = 0;
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            Classes.Produto produto = new Classes.Produto();

            this.usuario = usuario;

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvProdutos.DataSource = produto.ListarProduto();

            Classes.Categoria categoria = new Classes.Categoria();

            // Montar um Array de itens para colocar no cmb:
            var r = categoria.ListarTudo(); // r é a tabela do bd

            // Percorrer o R, montar a string e adicionar no array listacmb:
            foreach (DataRow linha in r.Rows)
            {
                cmbCategoriasEd.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
                cmbCategoriasCad.Items.Add(linha.ItemArray[0].ToString() + " - "+linha.ItemArray[1].ToString());
            }

            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Produto produto = new Classes.Produto();
            // Obter os valores dos campos:
            produto.Nome = txbNomeProdCad.Text;
            produto.Preco = double.Parse(txbPrecoCad.Text);
            produto.IdRespCadastro = usuario.Id;
            produto.IdCategoria = int.Parse(cmbCategoriasCad.Text.Split('-')[0]);



            if (produto.CadastrarProduto() == true)
            {
                MessageBox.Show("produto cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeProdCad.Clear();
                txbPrecoCad.Clear();
                cmbCategoriasCad.SelectedIndex = -1;
                // Atualizar o dgv:
                dgvProdutos.DataSource = produto.ListarProduto();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o produto!");
            }


        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            GrbEdProd.Enabled = true;
            GrbApagarProd.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = dgvProdutos.Rows[linhaSelecionada];

            txbNomeProdEd.Text = linha.Cells[1].Value.ToString();
            txbPrecoEd.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID o nome para existir no apagar:
            lblApagarProd.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagarProd_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;
            // Apagar:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (produto.Apagar() == true)
                {
                    MessageBox.Show("Produto removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dgvProdutos.DataSource = produto.ListarProduto();
                    // Limpar os campos da edição:
                    txbPrecoEd.Clear();
                    txbNomeProdEd.Clear();
                    cmbCategoriasCad.Text = "";
                    lblApagarProd.Text = "Selecione um produto para apagar.";
                    // Desabilitar os grbs:
                    GrbApagarProd.Enabled = false;
                    GrbEdProd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover o produto!", "Falha!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbCategoriasEd.Text != "")
            {
                Classes.Produto produto = new Classes.Produto();
                produto.Id = idSelecionado;
                produto.Nome = txbNomeProdEd.Text;
                produto.Preco = double.Parse(txbPrecoEd.Text);
                produto.IdCategoria = int.Parse(cmbCategoriasEd.Text.Split('-')[0]);

                // Editar:
                if (produto.Modificar() == true)
                {
                    MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dgvProdutos.DataSource = produto.ListarProduto();
                    // Limpar os campos da edição:
                    txbPrecoEd.Clear();
                    txbNomeProdEd.Clear();
                    

                    lblApagarProd.Text = "Selecione um produto para apagar.";
                    // Desabilitar os grbs:
                    GrbApagarProd.Enabled = false;
                    GrbEdProd.Enabled = false;

                    cmbCategoriasEd.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o produto!", "Falha!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Escolha uma categoria para editar!");
            }


        }
    }
}
