using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewsModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Marca")]
        [StringLength(24)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Numero de Serie")]
        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; }
            = SituacionProyector.Bueno;
        public DateTime FechDeAlta { get; set; } = DateTime.Now;
        public DateTime? FechDeBaja { get; set; }

    }
}
