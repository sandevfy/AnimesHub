using AnimesHub.Data;
using AnimesHub.Models;
using System.Data;

namespace AnimesHub.Forms.UserControls
{
    public partial class Assistindo : UserControl
    {
        private Usuario _usuarioLogado;
        public Assistindo(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }
        private void Assistindo_Load(object sender, EventArgs e)
        {
            LoadCards();
        }
        private void LoadCards()
        {
            using (var db = new AppDbContext())
            {
                var animes = db.UsuariosAnimes.Where(x => x.UsuarioId == _usuarioLogado.Id && x.StatusAnime == Enums.StatusAnime.Assistindo)
                    .Select(x => x.Anime).ToList();

                foreach (var anime in animes)
                {
                    AnimeCardControl animeCard = new AnimeCardControl(anime, _usuarioLogado);
                    animeCard.SetAnime();

                    flpAssistindo.Controls.Add(animeCard);
                }
            }
        }
    }
}
