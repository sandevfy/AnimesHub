using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimesHub.Forms.UserControls
{
    public partial class AnimeCardControl : UserControl
    {
        public AnimeCardControl()
        {
            InitializeComponent();
        }
        public void SetAnime() // recebe Anime anime
        {
            lblNomeAnimeCard.Text = "Naruto";
            lblDescAnimeCard.Text = "Um Anime muito bom cara, um mlk que quer ser Hokage mais que tudo.";
            lblAnoAnimeCard.Text = "2000";
        }
        private void AnimeCardControl_Load(object sender, EventArgs e)
        {

        }
    }
}
