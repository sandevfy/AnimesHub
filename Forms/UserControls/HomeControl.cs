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

                AnimeCardControl anim2 = new AnimeCardControl();

                anim2.SetAnime();
                flpAcompanhando.Controls.Add(anim2);

                AnimeCardControl anim3 = new AnimeCardControl();

                anim3.SetAnime();
                flpAssistindo.Controls.Add(anim3);

                AnimeCardControl anim4 = new AnimeCardControl();

                anim4.SetAnime();
                flpParaAssistir.Controls.Add(anim4);

                AnimeCardControl anim5 = new AnimeCardControl();

                anim5.SetAnime();
                flpAssistido.Controls.Add(anim5);

            }
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void pnlLançamentos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
