namespace AnimesHub.Models
{
    internal class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ano { get; set; }
        public int Temporadas { get; set; }
        public int Episodios { get; set; }
        public string Descrition { get; set; }
        public List<UsuarioAnime> UsuarioAnimes { get; set; }
    }
}
