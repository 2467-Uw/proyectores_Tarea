using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresControllers : Controller
    {
        public IActionResult Index()
        {
            return Content(
                "<h1>Proyectores</h1>" +
                "<p>Aqu&iacute se mostrar&aacute; la lista de proyectores registrados</p>",
                "text/html"
                );
        }

        public IActionResult Details(int id)
        {
            string html = "<h1>Nuevo proyector</h1>";
            html += $"<p>Aqu&iacute se mostrar&aacute la informaci&oacuten del proyector {id}</p>";
            return Content(html, "text/html");
        }

        public IActionResult Delete(int id)
        {
            string html = "<h1>Dar de baja</h1>";
            html += $"<p>Aqu&iacute se dar&aacute de baja el proyector {id}</p>";
            return Content(html, "text/html");
        }

        public IActionResult Edit(int id)
        {
            string html = "<h1>Editar proyector</h1>";
            html += $"<p>Aqu&iacute se modificar&aacute la informaci&oacuten del proyector {id}</p>";
            return Content(html, "text/html");
        }
    }
}
