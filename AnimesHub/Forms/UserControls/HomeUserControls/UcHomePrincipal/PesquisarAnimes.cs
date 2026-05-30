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

namespace AnimesHub.Forms.UserControls.HomeUserControls.UcHomePrincipal
{
    public partial class PesquisarAnimes : UserControl
    {
        private Usuario _usuarioLogado;
        public PesquisarAnimes(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }
        private void PesquisarAnimes_Load(object sender, EventArgs e)
        {
            CarregarAnimesIniciais();
        }
        private void CarregarAnimesIniciais()
        {
            using var db = new AppDbContext();
            var nameBuscar = txtNameAnimeBuscar.Text.ToLower().Trim();

            var animes = db.Animes.OrderByDescending(x => x.DateLancamento).ToList();

            LoadCards(animes);
        }
        private void btnBuscarAnime_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var nameBuscar = txtNameAnimeBuscar.Text.ToLower().Trim();

            var animes = db.Animes.Where(x => x.Name.ToLower().Contains(nameBuscar)).ToList();

            LoadCards(animes);
        }

        private void LoadCards(List<Anime> animes)
        {
            flpBuscarAnimes.Controls.Clear();

            foreach (var anime in animes)
            {
                AnimeCardControl animCard = new AnimeCardControl(anime, _usuarioLogado);
                animCard.SetAnime();

                flpBuscarAnimes.Controls.Add(animCard);
            }
        }
    }
}
