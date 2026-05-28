using AnimesHub.Data;
using AnimesHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimesHub.Forms.UserControls.HomeUserControls
{
    public partial class FavoritosHome : UserControl
    {
        private Usuario _usuarioLogado;
        public FavoritosHome(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }

        private void FavoritosHome_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void LoadCards()
        {
            using(var db = new AppDbContext())
            {
                var animes = db.UsuariosAnimes.Where(x => x.UsuarioId == _usuarioLogado.Id && x.IsFavorite == true).Select(x => x.Anime).ToList();

                foreach(var anime in animes)
                {
                    AnimeCardControl animeCard = new AnimeCardControl(anime, _usuarioLogado);
                    animeCard.SetAnime();

                    flpFavoritosHome.Controls.Add(animeCard);
                }
            }
        }
    }
}
