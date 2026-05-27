using AnimesHub.Models;

namespace AnimesHub.Forms.UserControls
{
    public partial class AnimeCardControl : UserControl
    {
        private Anime _anime;
        private Usuario _usuarioLongado;
        public AnimeCardControl(Anime anime, Usuario usuario)
        {
            InitializeComponent();
            _anime = anime;
            _usuarioLongado = usuario;
        }
        public void SetAnime()
        {
            lblNomeAnimeCard.Text = _anime.Name;
            lblDescAnimeCard.Text = _anime.Sinopse;
            lblAnoAnimeCard.Text = _anime.DateLancamento.ToString("dd/MM/yyyy");
        }

        private void AnimeCardControl_Load(object sender, EventArgs e)
        {

        }
    }
}
