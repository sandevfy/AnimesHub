using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimesHub.Forms
{
    public partial class PerfilControl : UserControl
    {
        private bool isAdmin = false;
        public PerfilControl()
        {
            InitializeComponent();
        }
        private void PermissaoChecked()
        {
            if (isAdmin)
            {
                txtBoxUser.Enabled = true;
                pnlUserEditAdm.Visible = true;
            }
            else
            {
                txtBoxUser.Enabled = false;
                pnlUserEditAdm.Visible = false;
            }
        }

        private void PerfilControl_Load(object sender, EventArgs e)
        {
            PermissaoChecked();
        }


        private void btnSolicitarEditUser_Click(object sender, EventArgs e)
        {
            isAdmin = !isAdmin;

            PermissaoChecked();
        }

        private void btnSalvarPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario Atualizado.");
        }
    }
}
