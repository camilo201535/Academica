
using System.ComponentModel.DataAnnotations;

namespace Programacion_V.Models;

public class Estudiante
{

    public int Id { get; set;}
    public string Documento  { get; set;} = string.Empty;

    public string Nombre { get; set;} = string.Empty;

    public string Correo { get; set; } = string.Empty;

   
   
    public int ProgramaAcademicoId { get; set; }

    [RegularExpression(@"^\d{10}$", ErrorMessage = "El celular debe tener 10 dígitos numéricos.")]
    public string? Celular { get; set; }

    public string? Direccion { get;}
    public ProgramaAcademico? ProgramaAcademico { get; set;} //relacion con el programa academico 

}