using AnimesHub.Data;
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
        private void Login_Load(object sender, EventArgs e)
        {
            txtUserLogin.Text = "admin"; // temporario
            txtUserSenha.Text = "2412"; // temporario
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picLoginPerfil.Width, picLoginPerfil.Height);
            picLoginPerfil.Region = new Region(path);

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

            if (!ValidarCadastro()) return;

            var usuario = new Usuario
            {

                UserLogin = txtUserCadastro.Text,
                Age = 1,
                Email = txtEmailCadastro.Text,
                Password = txtSenhaCadastro.Text,
                Role = Enums.UserRole.User
            };
            if (!db.Usuarios.Any(x => x.Role == Enums.UserRole.Admin))
            {
                usuario.Role = Enums.UserRole.Admin;
            }

            db.Usuarios.Add(usuario);
            db.SaveChanges();

            MessageBox.Show("Cadastrado com Sucesso!");
            MostrarLogin();
        }

        private bool ValidarCadastro()
        {
            List<string> erros = new();

            using var db = new AppDbContext();

            var user = txtUserCadastro.Text.Trim();
            var email = txtEmailCadastro.Text.Trim();
            var senha = txtSenhaCadastro.Text.Trim();

            if (string.IsNullOrWhiteSpace(user))
                erros.Add("Digite um nome de usuario.");

            if (string.IsNullOrWhiteSpace(email))
                erros.Add("Digite um email.");

            else if (!email.Contains("@") || !email.Contains("."))
                erros.Add("Digite um email valido!.");

            if (string.IsNullOrWhiteSpace(senha) || senha.Length < 4)
                erros.Add("A senha precisa ter no mínimo 4 caracteres.");

            var userExists = db.Usuarios.Any(x => x.UserLogin == user);
            var emailExists = db.Usuarios.Any(x => x.Email == email);

            if (!string.IsNullOrWhiteSpace(user) && userExists)
                erros.Add("Nome de usuário já existe.");
 
            if (!string.IsNullOrWhiteSpace(email) && emailExists)
                erros.Add("Email ja cadastrado");

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros));
                return false;
            }

            return true;
        }
    }
}
