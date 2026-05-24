using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimesHub.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            HomeControl home = new HomeControl();
            home.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(home);
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

            PerfilControl perfil = new PerfilControl();
            perfil.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(perfil);
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
