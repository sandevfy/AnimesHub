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

namespace AnimesHub.Forms.UserControls
{
    public partial class Assistir : UserControl
    {
        private Usuario _usuarioLogado;
        public Assistir(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }

        private void Assistir_Load(object sender, EventArgs e)
        {
            LoardCards();
        }
        private void LoardCards()
        {
            using (var db = new AppDbContext())
            {
                var animes = db.UsuariosAnimes.Where(x => x.UsuarioId == _usuarioLogado.Id && x.StatusAnime == Enums.StatusAnime.ParaAssistir)
                    .Select(x => x.Anime).ToList();

                foreach (var anime in animes)
                {
                    AnimeCardControl animeCard = new AnimeCardControl(anime, _usuarioLogado);
                    animeCard.SetAnime();

                    flpParaAssistir.Controls.Add(animeCard);
                }
            }
        }

    }
}
