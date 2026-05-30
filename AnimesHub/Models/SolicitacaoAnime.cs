using AnimesHub.Enums;

namespace AnimesHub.Models
{
    public class SolicitacaoAnime
    {
        public int Id { get; set; }
        public string NomeAnime { get; set; } = string.Empty;
        public string? Observacao { get; set; }
        public DateTime DataSolicitacao { get; set; }

        public StatusSolicitacao StatusSolicitacao { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
