using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Proyector
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Marca")] // esta marca no acepta valores nulos
        [StringLength(24)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Numero de serie")]
        public string NumeroDeSerie { get; set; }

        public SituacionProyector Situacion { get; set; }
          = SituacionProyector.Bueno;
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; } = null;
    }
    public enum SituacionProyector
    {
        Bueno = 1,
        Regular = 2,
        Malo = 3
    }
}