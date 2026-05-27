namespace AnimesHub.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Studio { get; set; }
        public string Genero { get; set; }
        public DateTime DateLancamento { get; set; }
        public int Temporadas { get; set; }
        public int Episodios { get; set; }
        public string Sinopse { get; set; }
        public List<UsuarioAnime> UsuarioAnimes { get; set; }
    }
}
