using AnimesHub.Data;
using AnimesHub.Models;
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
            using var db = new AppDbContext();

            flpLancamentosHome.Controls.Clear();
            flpAcompanhandoHome.Controls.Clear();

            var now = DateTime.Now;

            var animesLanc = db.Animes.Where(x => x.DateLancamento > now)
                .OrderBy(x => x.DateLancamento)
                .Take(5).ToList();

            foreach (var anime in animesLanc)
            {
                AnimeCardControl animCard = new AnimeCardControl(anime, _usuarioLogado);
                animCard.SetAnime();

                flpLancamentosHome.Controls.Add(animCard);
            }

            var animeAcomp = db.UsuariosAnimes.Where(x => x.UsuarioId == _usuarioLogado.Id && x.StatusAnime == Enums.StatusAnime.Acompanhando)
                .Select(x => x.Anime).OrderBy(x => x.Id)
                .Take(5).ToList();

            foreach (var animeAc in animeAcomp)
            {
                AnimeCardControl animeCardAc = new AnimeCardControl(animeAc, _usuarioLogado);
                animeCardAc.SetAnime();

                flpAcompanhandoHome.Controls.Add(animeCardAc);

            }
        }
    }
}
