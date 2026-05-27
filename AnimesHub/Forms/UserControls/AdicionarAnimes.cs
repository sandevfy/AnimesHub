using AnimesHub.Data;
using AnimesHub.Models;
using System.Data;

namespace AnimesHub.Forms.UserControls
{
    public partial class AdicionarAnimes : UserControl
    {
        public AdicionarAnimes()
        {
            InitializeComponent();
        }

        private void AdicionarAnimes_Load(object sender, EventArgs e)
        {

        }

        private void btnCarregarCapaAnime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muito em breve estará disponivel.");
        }

        private void btnCriarAnime_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            if (!ValidarCadastro()) return;

            if (!int.TryParse(txtCriarAnimesTemporadas.Text, out int temps))
            {
                MessageBox.Show("Digite um numero de temporadas valido");
                return;
            }
            if (!int.TryParse(txtCriarAnimesEpisodios.Text, out int eps))
            {
                MessageBox.Show("Digite um numero de episódios valido");
                return;
            }


            var anime = new Anime
            {
                Name = txtCriarAnimesNome.Text,
                Studio = txtCriarAnimesStudio.Text,
                Genero = txtCriarAnimesGenero.Text,
                Temporadas = temps,
                Episodios = eps,
                DateLancamento = dtCriarAnimesDateLancamento.Value,
                Sinopse = txtCriarAnimesSinopse.Text
            };


            DialogResult result = MessageBox.Show("Deseja Salvar Este Anime?",
                "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.Animes.Add(anime);
                db.SaveChanges();

                MessageBox.Show("Anime Salvo com Sucesso!");
                LimparCampos();
            }
        }
        private bool ValidarCadastro()
        {
            List<string> erros = new();

            var nameAnime = txtCriarAnimesNome.Text;
            var studio = txtCriarAnimesStudio.Text;
            var genero = txtCriarAnimesGenero.Text;
            var sinopse = txtCriarAnimesSinopse.Text;
            var temps = txtCriarAnimesTemporadas.Text;
            var eps = txtCriarAnimesEpisodios.Text;

            if (string.IsNullOrWhiteSpace(nameAnime))
            {
                erros.Add("Digite um nome.");
            }
            if (string.IsNullOrWhiteSpace(studio))
            {
                erros.Add("Digite um studio.");
            }
            if (string.IsNullOrWhiteSpace(genero))
            {
                erros.Add("Digite um genero.");
            }
            if (string.IsNullOrWhiteSpace(sinopse))
            {
                erros.Add("Digite uma sinopse.");
            }
            if (string.IsNullOrWhiteSpace(temps))
            {
                erros.Add("Entre com o total de temporadas.");
            }
            if (string.IsNullOrWhiteSpace(eps))
            {
                erros.Add("Entre com o total de episodios.");
            }

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros));
                return false;
            }

            return true;
        }
        private void btnLimparCamposCriarAnime_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCriarAnimesNome.Clear();
            txtCriarAnimesStudio.Clear();
            txtCriarAnimesGenero.Clear();
            txtCriarAnimesTemporadas.Clear();
            txtCriarAnimesEpisodios.Clear();
            dtCriarAnimesDateLancamento.Value = DateTime.Now;
            txtCriarAnimesSinopse.Clear();
        }

        private void btnListarAnimes_Click(object sender, EventArgs e)
        {
            LoadDgvAnimes();
        }

        private void LoadDgvAnimes()
        {
            LimparLoadDgvAnimes();

            using var db = new AppDbContext();

            dgvListarAnimes.DataSource = db.Animes.Select(x => new
            {
                ID = x.Id,
                Nome = x.Name,
                Studio = x.Studio,
                Genero = x.Genero,
                Temporadas = x.Temporadas,
                Episodios = x.Episodios,
                Lançamento = x.DateLancamento,
                Sinopse = x.Sinopse
            }).ToList();
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            LimparLoadDgvAnimes();
        }

        private void LimparLoadDgvAnimes()
        {
            dgvListarAnimes.DataSource = null;
            dgvListarAnimes.Columns.Clear();
        }

        private void btnExcluirAnimeAdd_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            if (!int.TryParse(txtIdBuscarAnimeAdd.Text, out var id))
            {
                MessageBox.Show("Anime não encontrado!");
                return;
            }

            var anime = db.Animes.Find(id);

            if (anime == null)
            {
                MessageBox.Show("Anime não encontrado!");
                return;
            }

            DialogResult result = MessageBox.Show($"Deseja excluir o _anime: {anime.Name}",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.Animes.Remove(anime);
                db.SaveChanges();

                MessageBox.Show("Anime excluido com sucesso!");
            }
        }
    }
}
