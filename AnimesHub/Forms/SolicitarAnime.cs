using AnimesHub.Data;
using AnimesHub.Enums;
using AnimesHub.Forms.UserControls.Cards;
using AnimesHub.Models;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace AnimesHub.Forms
{
    public partial class SolicitarAnime : UserControl
    {
        private Usuario _usuarioLogado;
        public SolicitarAnime(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }
        private void PermissaoChecked()
        {
            bool isAdmin = _usuarioLogado.Role == Enums.UserRole.Admin;

            pnlControleAprovacao.Visible = isAdmin;
        }
        private void SolicitarAnime_Load(object sender, EventArgs e)
        {
            ClearFields();
            PermissaoChecked();

            MessageBox.Show("Antes de solicitar um anime faça uma busca. \nEvite solicitar animes repetidos.",
                "Solicitação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadCards();

        }
        private void btnBuscarSlc_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            if (!int.TryParse(txtIdBuscarSlc.Text, out int id))
            {
                MessageBox.Show("Digite um ID valido!");
                return;
            }

            var solic = db.SolicitacaoAnimes.Include(x => x.Usuario).FirstOrDefault(x => x.Id == id);

            if (solic != null)
            {
                btnEnviar.Enabled = false;

                txtNameAnimeSlc.Text = solic.NomeAnime;
                txtObsAnimeSlc.Text = solic.Observacao;
                lblNameUserSlc.Text = "Nome Usuario: " + solic.Usuario.Name;
                lblDtsUserSlc.Text = "Data Solicitação: " + solic.DataSolicitacao.ToString("dd/MM/yyyy");
                lblStatusUserSlc.Text = "Status: " + solic.StatusSolicitacao.ToString();
            }
            else
            {
                MessageBox.Show("Solicitação não encontrada");
                ClearFields();
            }
        }
        private void btnLimparBuscaSlc_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            var nameAnimSlc = txtNameAnimeSlc.Text.Trim();

            if (string.IsNullOrWhiteSpace(nameAnimSlc))
            {
                MessageBox.Show("Digite um nome");
                return;
            }

            if (db.SolicitacaoAnimes.Any(x => x.NomeAnime == nameAnimSlc))
            {
                MessageBox.Show("Já existe uma solicitação para este anime.");
                return;
            }

            var solicAnime = new SolicitacaoAnime
            {
                NomeAnime = txtNameAnimeSlc.Text.Trim(),
                Observacao = txtObsAnimeSlc.Text.Trim(),
                DataSolicitacao = DateTime.Now,
                StatusSolicitacao = Enums.StatusSolicitacao.Pendente,
                UsuarioId = _usuarioLogado.Id
            };

            db.SolicitacaoAnimes.Add(solicAnime);

            db.SaveChanges();

            MessageBox.Show("Solicitacão enviada com sucesso!");

            ClearFields();
            LoadCards();
        }

        private void btnAprovadoSlc_Click(object sender, EventArgs e)
        {
            AtualizarStatusSolicitacao(Enums.StatusSolicitacao.Aprovado);
        }

        private void btnRecusadoSlc_Click(object sender, EventArgs e)
        {
            AtualizarStatusSolicitacao(Enums.StatusSolicitacao.Recusado);
        }
        private void btnPendenteSlc_Click(object sender, EventArgs e)
        {
            AtualizarStatusSolicitacao(Enums.StatusSolicitacao.Pendente);
        }
        private void AtualizarStatusSolicitacao(StatusSolicitacao status)
        {

            using var db = new AppDbContext();
            if (!int.TryParse(txtIdBuscarSlc.Text, out int id))
            {
                MessageBox.Show("Digite um ID valido!");
                return;
            }
            var solic = db.SolicitacaoAnimes.Find(id);

            if (solic == null)
            {
                MessageBox.Show("Solicitação não encontrada");
                return;
            }

            solic.StatusSolicitacao = status;

            db.SaveChanges();

            MessageBox.Show($"Solicitação {status}!");

            ClearFields();
            LoadCards();
        }
        private void btnBuscarNameAnimeSlc_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            var txtBuscar = txtBuscarNameAnimeSlc.Text.ToLower().Trim();
            var animes = db.SolicitacaoAnimes.Where(x => x.NomeAnime.ToLower().Contains(txtBuscar)).OrderByDescending(x => x.DataSolicitacao).ToList();

            CarregarCards(animes);
        }
        private void btnBuscarAprovados_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            var animes = db.SolicitacaoAnimes.Where(x => x.StatusSolicitacao == Enums.StatusSolicitacao.Aprovado)
                .OrderByDescending(x => x.DataSolicitacao).ToList();

            CarregarCards(animes);
            ClearFields();
        }
        private void btnBuscarRecusados_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            var animes = db.SolicitacaoAnimes.Where(x => x.StatusSolicitacao == Enums.StatusSolicitacao.Recusado)
                .OrderByDescending(x => x.DataSolicitacao).ToList();

            CarregarCards(animes);
            ClearFields();
        }
        private void btnBuscarPendentes_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var animes = db.SolicitacaoAnimes.Where(x => x.StatusSolicitacao == Enums.StatusSolicitacao.Pendente)
                .OrderByDescending(x => x.DataSolicitacao).ToList();

            CarregarCards(animes);
            ClearFields();
        }
        private void LoadCards()
        {
            using var db = new AppDbContext();

            var animes = db.SolicitacaoAnimes.OrderByDescending(x => x.DataSolicitacao).ToList();

            CarregarCards(animes);
        }
        private void CarregarCards(List<SolicitacaoAnime> animes)
        {
            flpAnimesSolicitados.Controls.Clear();

            foreach (var anime in animes)
            {
                AnimeSolicitacaoCard animCard = new AnimeSolicitacaoCard(_usuarioLogado, anime);
                animCard.SetAnime();

                flpAnimesSolicitados.Controls.Add(animCard);
            }
        }
        private void ClearFields()
        {
            txtNameAnimeSlc.Clear();
            txtNameAnimeSlc.Clear();
            txtObsAnimeSlc.Clear();
            txtIdBuscarSlc.Clear();
            lblNameUserSlc.Text = string.Empty;
            lblDtsUserSlc.Text = string.Empty;
            lblStatusUserSlc.Text = string.Empty;
            btnEnviar.Enabled = true;
            txtBuscarNameAnimeSlc.Text = string.Empty;
        }
    }
}
