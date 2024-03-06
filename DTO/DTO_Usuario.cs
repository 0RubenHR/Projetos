namespace Projetos.DTO;

public class DTO_Usuario
{
    public string PrimeiroNome { get; set; }
    public string UltimoNome { get; set; }
    public IFormFile? Foto { get; set; }
    public DateTime DataNascimento { get; set; }
}