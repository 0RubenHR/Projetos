using Projetos.DAL.Database;
using Projetos.DAL.IRepository;
using Projetos.DTO;
using Projetos.Entities;

namespace Projetos.DAL.CRepository;

public class CUsuario : IUsuario
{
    private readonly ProjetosDbContext _db;
    public CUsuario(ProjetosDbContext db)
    {
        _db = db;
    }

    public DTO_Reposta CadastrarUsuario(Usuario usuario)
    {
        DTO_Reposta resposta = new DTO_Reposta();
        try
        {
            if(usuario!=null)
            {
                _db.Usuarios.Add(usuario);
                _db.SaveChanges();
                resposta.mensagem = "Sucesso";
                return resposta;
            }
            resposta.mensagem = "Dados inválidos";
        }catch(Exception ex)
        {
            resposta.mensagem = ex.ToString();
        }
        return resposta;
    }
}