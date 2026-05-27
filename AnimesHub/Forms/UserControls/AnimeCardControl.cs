using AnimesHub.Data;
using AnimesHub.Enums;
using AnimesHub.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimesHub.Forms.UserControls
{
    public partial class AnimeCardControl : UserControl
    {
        private Anime _anime;
        private Usuario _usuarioLogado;
        public AnimeCardControl(Anime anime, Usuario usuario)
        {
            InitializeComponent();
            _anime = anime;
            _usuarioLogado = usuario;
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

        private void btnMenuStrip_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMenuStrip, 0, btnMenuStrip.Height);
        }

        private void tsmiAssistido_Click(object sender, EventArgs e)
        {
            AtualizarStatus(StatusAnime.Assistido);
        }

        private void tsmiAcompanhando_Click(object sender, EventArgs e)
        {
            AtualizarStatus(StatusAnime.Acompanhando);
        }

        private void tsmiParaAssisitr_Click(object sender, EventArgs e)
        {
            AtualizarStatus(StatusAnime.ParaAssistir);
        }

        private void tsmiAssistindo_Click(object sender, EventArgs e)
        {
            AtualizarStatus(StatusAnime.Assistindo);
        }

        private void AtualizarStatus(StatusAnime status)
        {
            using var db = new AppDbContext();

            var usuariosAnime = db.UsuariosAnimes.FirstOrDefault(x => x.UsuarioId == _usuarioLogado.Id && x.AnimeId == _anime.Id);
            if (usuariosAnime == null)
            {
                usuariosAnime = new UsuarioAnime
                {
                    UsuarioId = _usuarioLogado.Id,
                    AnimeId = _anime.Id
                };
                db.UsuariosAnimes.Add(usuariosAnime);
            }
            usuariosAnime.StatusAnime = status;

            db.SaveChanges();
        }
    }
}
