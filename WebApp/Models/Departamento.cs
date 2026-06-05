using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El título es obligatorio del departamento")]
        public string Titulo { get; set; } = string.Empty;

        // Propiedad de navegación para la relación con Proyector
        public IEnumerable<Proyector> Proyectores { get; set; } = new List<Proyector>();
    }
}
