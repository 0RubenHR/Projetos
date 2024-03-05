using Microsoft.EntityFrameworkCore;
using Projetos.Entities;

namespace Projetos.DAL.Database;

public class ProjetosDbContext : DbContext
{
    private static string StringLocal = "Host = localhost; port= 3306; username = root; Database = dt_teste;";
    private static string StringPublica = "";
    public DbSet<Usuario> Usuarios {get;set;}
    public DbSet<Tarefa> Tarefas {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        optionsBuilder.UseMySql(StringLocal, serverVersion);
    }

}