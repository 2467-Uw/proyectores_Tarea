using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Models.Services;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProyectoresService _service;
        public HomeController()
        {
            _service = new ProyetoresEnMemoriaService();
        }
        public IActionResult Index()
        {
            var modelo = _service.GetAll();
            //var modelo = new List<Proyector>();
            return View(modelo);
        }

        private IEnumerable<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                Id = 1,
                Marca = "LG",
                Modelo = "XLight",
                NumeroDeSerie = "346765",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 2,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "23534",
                Situacion = SituacionProyector.Regular,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "PanaSonic",
                Modelo = "XLight",
                NumeroDeSerie = "23534",
                Situacion = SituacionProyector.Regular,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "BenQ",
                Modelo = "XLight",
                NumeroDeSerie = "748921",
                Situacion = SituacionProyector.Malo,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Dell",
                Modelo = "XLight",
                NumeroDeSerie = "368434",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 6,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "673292",
                Situacion = SituacionProyector.Malo,
                FechaDeAlta = DateTime.Now
            });

            return proyectores;
        }

        public IActionResult Create()
        {
            Proyector proyector = new Proyector();
            proyector.FechaDeAlta = DateTime.Now;
            return View(proyector);
        }

        [HttpPost]
        public IActionResult Create(Proyector proyector)
        {
            if (!ModelState.IsValid)
            {
                return View(proyector);
            }
            else
            {
                _service.AddProyector(proyector);
                return RedirectToAction(nameof(Index));
            }
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
