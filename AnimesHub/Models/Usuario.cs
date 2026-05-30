using AnimesHub.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimesHub.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string UserLogin { get; set; } = string.Empty;
        public int? Age { get; set; } 
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public List<UsuarioAnime> UsuarioAnime { get; set; }
    }
}
