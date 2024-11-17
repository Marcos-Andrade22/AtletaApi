using System;

namespace AtletaApi.Models;

public class UsuarioDTO
{
    public long Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string HashSenha { get; set; } = string.Empty;
}
