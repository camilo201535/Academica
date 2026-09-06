using Microsoft.EntityFrameworkCore;
using Programacion_V.Models;

namespace Programacion_V.Data;

public class AppDbContexto : DbContext
{
    public AppDbContexto(DbContextOptions<AppDbContexto> options) : base(options)
    {
    }

    public DbSet<Estudiante> Estudiantes { get; set; } = null!;
    public DbSet<ProgramaAcademico> ProgramasAcademicos { get; set; } = null!;

    // Este es el método obligatorio para poder sembrar datos semilla en Entity Framework
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // -------------------------------------------------------------
        // DATOS SEMILLA - PROGRAMAS ACADÉMICOS
        // (Obligatorio colocarlos primero por la relación de llave foránea)
        // -------------------------------------------------------------
        modelBuilder.Entity<ProgramaAcademico>().HasData(
            new ProgramaAcademico
            {
                Id = 1,
                Codigo = "SIS",
                Nombre = "Ingeniería de Sistemas"
            },
            new ProgramaAcademico
            {
                Id = 2,
                Codigo = "TEL",
                Nombre = "Ingeniería de Telecomunicaciones"
            }
        );

        // -------------------------------------------------------------
        // DATOS SEMILLA - ESTUDIANTES
        // -------------------------------------------------------------
        modelBuilder.Entity<Estudiante>().HasData(
            new Estudiante
            {
                Id = 1,
                Documento = "1001001001",
                Nombre = "Ana Torres",
                Correo = "ana.torres@universidad.edu.co",
                ProgramaAcademicoId = 1
            },
            new Estudiante
            {
                Id = 2,
                Documento = "1001001002",
                Nombre = "Carlos Gómez",
                Correo = "carlos.gomez@universidad.edu.co",
                ProgramaAcademicoId = 1
            },
            new Estudiante
            {
                Id = 4,
                Documento = "1001001004",
                Nombre = "Miguel Ramírez",
                Correo = "miguel.ramirez@universidad.edu.co",
                ProgramaAcademicoId = 2
            },
            new Estudiante
            {
                Id = 5,
                Documento = "1001001005",
                Nombre = "Sofía Martínez",
                Correo = "sofia.martinez@universidad.edu.co",
                ProgramaAcademicoId = 2
            }
        );
    }
}


