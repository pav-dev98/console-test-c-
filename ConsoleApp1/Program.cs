// See https://aka.ms/new-console-template for more information
// namespace ConsoleApp1;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore; 
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Npgsql;



var connectionString = "Host=localhost;Database=MiBaseDeDatos;Username=postgres;Password=miPassword";

// try
// {
//     using (var connection = new NpgsqlConnection(connectionString))
//     {
//         connection.Open();
//         Console.WriteLine("Conexión exitosa. La cadena de conexión es válida.");
//     }
// }
// catch (NpgsqlException ex)
// {
//     Console.WriteLine($"Error al intentar conectar a la base de datos: {ex.Message}");
// }
using (var context = new MyDbContext())
{
    // context.Database.EnsureCreated();
    var nuevaPersona = new Persona { Nombre = "Juan" };
    context.Personas.Add(nuevaPersona);
    context.SaveChanges();
    Console.WriteLine("Base de datos y tablas creadas correctamente.");
}