using AnimesHub.Enums;

namespace AnimesHub.Models
{
    internal class UsuarioAnime
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int AnimeId { get; set; }
        public Anime Anime { get; set; }

        public ModeNivel ModeNivel { get; set; }
    }
}
