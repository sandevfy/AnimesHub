using AnimesHub.Forms.UserControls;
using AnimesHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace AnimesHub.Forms
{
    public partial class FormPrincipal : Form
    {
        private Usuario _usuarioLongado;
        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLongado = usuario;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0, picUserImage.Width, picUserImage.Height);

            picUserImage.Region = new Region(path);
            PermissaoChecked();

            LoadUserPerfil();
            pnlConteudo.Controls.Clear();

            HomeControl home = new HomeControl();
            home.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(home);
        }
        private void PermissaoChecked()
        {
            bool isAdmin = _usuarioLongado.Role == Enums.UserRole.Admin;

            btnAdicionarAnimes.Visible = isAdmin;
        }
        private void LoadUserPerfil()
        {
            lblNomeUsuarioLongado.Text = _usuarioLongado.Name;
        }
        private void btnUcHome_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            HomeControl home = new HomeControl();
            home.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(home);
        }

        private void btnUcPerfil_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            PerfilControl perfil = new PerfilControl(_usuarioLongado);
            perfil.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(perfil);
        }

        private void btnAdicionarAnimes_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            AdicionarAnimes addAnimes = new AdicionarAnimes();
            addAnimes.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(addAnimes);
        }
        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tem certeza que deseja sair da conta?",
                "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

    }
}
