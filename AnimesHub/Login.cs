using AnimesHub.Data;
using AnimesHub.Enums;
using AnimesHub.Forms;
using AnimesHub.Models;
using System.Drawing.Drawing2D;

namespace AnimesHub
{
    public partial class Login : Form
    {
        private int _usuarioLongado;
        public Login()
        {
            InitializeComponent();
        }

        private void lblLoginEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Recuperação de senha em desenvolvimento");
        }

        private void btnLoginCadastrar_Click(object sender, EventArgs e)
        {
            MostrarCadastro();
        }

        private void lblJaPossuiConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarLogin();
        }

        private void MostrarLogin()
        {
            pnlLogin.Visible = true;
            pnlCadastrar.Visible = false;
        }

        private void MostrarCadastro()
        {
            pnlLogin.Visible = false;
            pnlCadastrar.Visible = true;
        }

        private void btnLoginEntrar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            var usuario = db.Usuarios.FirstOrDefault(x => x.UserLogin == txtUserLogin.Text && x.Password == txtUserSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario ou Senha Errada.");
                return;
            }

            var formPrincipal = new FormPrincipal(usuario);

            this.Hide();

            DialogResult resultado = formPrincipal.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                // Clicou em Sair
                this.Show();
            }
            else
            {
                // Clicou no X
                Application.Exit();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            using var db = new AppDbContext();

            var usuario = new Usuario
            {
                UserLogin = txtUserCadastro.Text,
                Age = 1,
                Email = txtEmailCadastro.Text,
                Password = txtSenhaCadastro.Text,
                Role = Enums.UserRole.User
            };
            if(!db.Usuarios.Any(x => x.Role == Enums.UserRole.Admin))
            {
                usuario.Role = Enums.UserRole.Admin;
            }

            db.Usuarios.Add(usuario);
            db.SaveChanges();

            MessageBox.Show("Cadastrado com Sucesso!");
            MostrarLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
