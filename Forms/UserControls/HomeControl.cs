using AnimesHub.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimesHub.Forms
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void LoadCards()
        {
            for (int i = 0; i < 5; i++)
            {
                AnimeCardControl anim = new AnimeCardControl();

                anim.SetAnime();
                flpLancamentos.Controls.Add(anim);
            }
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            LoadCards();
        }
    }
}
