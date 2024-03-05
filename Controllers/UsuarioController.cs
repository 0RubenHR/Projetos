using Microsoft.AspNetCore.Mvc;
using Projetos.DAL.IRepository;
using Projetos.DTO;
using Projetos.Entities;

namespace Projetos.Controller;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuario _usuario;
    public UsuarioController(IUsuario usuario)
    {
        _usuario = usuario;
    }
    [HttpPost("cadastrarusuario")]
    public DTO_Reposta CadastrarUsuario(Usuario usuario)
    {
        var resposta = _usuario.CadastrarUsuario(usuario);
        return resposta;
    }
}