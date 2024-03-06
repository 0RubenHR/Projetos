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

    public DTO_Reposta CadastrarUsuario(DTO_Usuario usuario)
    {
        DTO_Reposta resposta = new DTO_Reposta();
        try
        {
            if (usuario != null)
            {
                var NovoUser = new Usuario
                {
                    PrimeiroNome = usuario.PrimeiroNome,
                    UltimoNome = usuario.UltimoNome,
                    Foto = ConverterImagemToBase64(usuario.Foto),
                    DataNascimento = usuario.DataNascimento
                };
                _db.TbUsuarios.Add(NovoUser);
                _db.SaveChanges();
                resposta.mensagem = "Sucesso";
                return resposta;
            }
            resposta.mensagem = "Dados inválidos";
        }
        catch (Exception ex)
        {
            resposta.mensagem = ex.ToString();
        }
        return resposta;
    }
    private string ConverterImagemToBase64(IFormFile file)
    {
        string resposta = string.Empty;
        if (file == null)
        {
            return resposta;
        }
        var memoryStream = new MemoryStream();
        file.CopyTo(memoryStream);
        Byte[] ImageBytes = memoryStream.ToArray();
        resposta = Convert.ToBase64String(ImageBytes);
        return resposta;
    }
}