using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Projetos.Entities;

[Table("usuario")]
public class Usuario
{
    [Column("id")]
    public int Id {get; set;}
    [Column("primeironome")]
    public string PrimeiroNome {get;set;}
    [Column("ultimonome")]
    public string UltimoNome {get;set;}
    [Column("foto")]
    public string Foto {get;set;}
    [Column("datanascimento")]
    public DateTime DataNascimento {get; set;}

}