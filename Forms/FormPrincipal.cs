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

        private void button1_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            HomeControl home = new HomeControl();
            home.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(home);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            ConfigControl config = new ConfigControl();
            config.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(config);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            PerfilControl perfil = new PerfilControl();
            perfil.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(perfil);
        }
    }
}
