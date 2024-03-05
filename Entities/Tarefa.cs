using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Projetos.Entities;

[Table("tarefa")]
public class Tarefa
{
    [Column("id")]
    public int Id { get; set; }
    [Column("nome")]
    public string Nome { get; set; }
    [Column("criacao")]
    public DateTime Criacao { get; set; }
    [Column("concluida")]
    public bool Concluida { get; set; }
    [Column("finalizacao")]
    public DateTime Finalizacao { get; set; }
    [Column("usuarioid")]
    public int UsuarioId {get;set;}

}