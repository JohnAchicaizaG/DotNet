using Microsoft.EntityFrameworkCore;
using ApiEcommerce.Models;

namespace ApiEcommerce.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSets - Cada uno representa una tabla en la base de datos
    public DbSet<Category> Categories { get; set; }

    // Configuración avanzada (opcional)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Aquí puedes configurar:
        // - Relaciones entre tablas
        // - Índices únicos
        // - Valores por defecto
        // - Nombres personalizados de tablas/columnas
        // - Seed data (datos iniciales)
    }
}