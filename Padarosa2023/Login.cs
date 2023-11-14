using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa2023
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciar um usuario:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            // Obter o resultado do SELECT no banco:
            var resultado = usuario.Logar();

            if(resultado.Rows.Count == 1)
            {
                // Senha correta: Proseguir..
                usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                // Próximo passo: abrir a janela menu:
                MenuPrincipal janela = new MenuPrincipal(usuario);
                // Esconder a janela atual:
                Hide();
                // Mostrar o menu:
                janela.ShowDialog();
                // Mostrar o login quando o menu fechar:
                Show();
            }
            else
            {
                // Senha incorreta:
                MessageBox.Show("Email ou senha incorretos.", 
                    "erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
