using AnimesHub.Data;
using AnimesHub.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace AnimesHub.Forms.UserControls.HomeUserControls
{
    public partial class HomePrincipal : UserControl
    {
        private Usuario _usuarioLogado;
        public HomePrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }
        private void HomePrincipal_Load(object sender, EventArgs e)
        {
            LoardCards();
        }
        private void LoardCards()
        {
            using (var db = new AppDbContext())
            {
                var animes = db.Animes.Where(x => x.DateLancamento > DateTime.Now).OrderBy(x => x.DateLancamento).ToList();

                foreach (var anime in animes)
                {
                    AnimeCardControl animCard = new AnimeCardControl(anime, _usuarioLogado);
                    animCard.SetAnime();

                    flpLancamentosHome.Controls.Add(animCard);
                }
            }
        }
    }
}
