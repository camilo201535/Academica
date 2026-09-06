using Programacion_V.Data;
using Programacion_V.Models;

using Microsoft.EntityFrameworkCore;

namespace Programacion_V.Repositories;

public class EstudiantesRepository
{
    private readonly AppDbContexto _context;

    public EstudiantesRepository(AppDbContexto context)
    {
        _context = context;
    }

    public async Task<List<Estudiante>> GetAllEstudiantesAsync()
    {
        return await _context.Estudiantes.ToListAsync();
    }

    public async Task<Estudiante?> GetEstudianteByIdAsync(int id)
    {
        return await _context.Estudiantes.FindAsync(id);
    }

    public async Task AddEstudianteAsync(Estudiante  estudiante )
    {
        _context.Estudiantes.Add(estudiante);
        await _context.SaveChangesAsync();
    }


       public async Task UpdateEstudianteAsync(Estudiante estudiante)
    {
        _context.Estudiantes.Update(estudiante);
        await _context.SaveChangesAsync();
    }



         public async Task DeleteEstudianteAsync(int id )
    {
        var estudiante= await _context.Estudiantes.FindAsync(id);

        if  (estudiante != null)
        {
             _context.Estudiantes.Remove(estudiante);
             await _context.SaveChangesAsync();
        }
    }

  
}
