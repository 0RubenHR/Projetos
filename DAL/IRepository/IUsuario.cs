using Projetos.DTO;
using Projetos.Entities;

namespace Projetos.DAL.IRepository;

public interface IUsuario
{
    DTO_Reposta CadastrarUsuario(DTO_Usuario usuario);
}