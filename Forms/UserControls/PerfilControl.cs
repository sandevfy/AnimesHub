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

        private void PerfilControl_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                txtUserLogin.Enabled = true;
                pnlAdmEditarId.Visible = true;
            }
            else
            {
                txtUserLogin.Enabled = false;
                pnlAdmEditarId.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isAdmin = !isAdmin;

            if (isAdmin)
            {
                txtUserLogin.Enabled = true;
                pnlAdmEditarId.Visible = true;
            }
            else
            {
                txtUserLogin.Enabled = false;
                pnlAdmEditarId.Visible = false;
            }
        }
    }
}
