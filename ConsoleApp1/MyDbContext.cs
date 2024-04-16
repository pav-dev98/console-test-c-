// namespace ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
public class MyDbContext : DbContext
{
    // Define propiedades DbSet para las entidades (tablas) de tu base de datos
    public DbSet<Persona> Personas { get; set; } // Ejemplo: Conjunto de entidades para la tabla 'Personas'

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Host=localhost;Database=prueba;Username=postgres";
        optionsBuilder.UseNpgsql(connectionString); // Configura la cadena de conexión
    }
}