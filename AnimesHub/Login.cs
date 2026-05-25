using AnimesHub.Forms;
using System.Drawing.Drawing2D;

namespace AnimesHub
{
    public partial class Login : Form
    {
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
            if (txtUserLogin.Text == "adm" && txtUserSenha.Text == "adm")
            {
                var formPrincipal = new FormPrincipal();

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
            else
            {
                MessageBox.Show("Conta Não Autorizada!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastramento em desenvolvimento");
        }
    }
}
