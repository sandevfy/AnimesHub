namespace AnimesHub.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Studio { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public DateTime DateLancamento { get; set; }
        public int Temporadas { get; set; }
        public int Episodios { get; set; }
        public string Sinopse { get; set; } = string.Empty;
        public List<UsuarioAnime> UsuarioAnimes { get; set; }
    }
}
