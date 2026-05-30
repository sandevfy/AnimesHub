using AnimesHub.Models;

namespace AnimesHub.Forms.UserControls.Cards
{
    public partial class AnimeSolicitacaoCard : UserControl
    {
        private Usuario _usuarioLogado;
        private SolicitacaoAnime _solic;
        public AnimeSolicitacaoCard(Usuario usuario, SolicitacaoAnime solic)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
            _solic = solic;
        }
        public void SetAnime()
        {
            lblNomeAnimeSlc.Text = _solic.NomeAnime;
            lblObsAnimeSlc.Text = _solic.Observacao ?? "Sem observações";
            txtStatusSlc.Text = _solic.StatusSolicitacao.ToString();
        }
    }
}
