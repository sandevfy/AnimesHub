using AnimesHub.Data;
using AnimesHub.Models;
using System.Data;

namespace AnimesHub.Forms.UserControls
{
    public partial class Acompanhando : UserControl
    {
        private Usuario _usuarioLongado;
        public Acompanhando(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLongado = usuario;
        }

        private void Acompanhando_Load(object sender, EventArgs e)
        {
            LoardCards();
        }

        private void LoardCards()
        {
            using (var db = new AppDbContext())
            {
                var animes = db.UsuariosAnimes.Where(x => x.UsuarioId == _usuarioLongado.Id && x.StatusAnime == Enums.StatusAnime.Acompanhando)
                    .Select(x => x.Anime).ToList();

                foreach (var anime in animes)
                {
                    AnimeCardControl animeCard = new AnimeCardControl(anime, _usuarioLongado);

                    animeCard.SetAnime();

                    flpAcompanhando.Controls.Add(animeCard);
                }
            }
        }

        private void flpAcompanhando_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
