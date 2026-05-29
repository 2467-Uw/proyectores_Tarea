using WebApp.Data;
using WebApp.Data.Migrations;
using WebApp.Models;

namespace WebApp.Models.Services
{
    public class ProyectoresService : IProyectoresService
    {
        private readonly AppDBContext _context;

        public ProyectoresService(AppDBContext context)
        {
            this._context = context;
        }
        public void AddProyector(Proyector proyector)
        {
            if (proyector != null) // Verificar que el proyector no sea nulo
            {
                _context.Proyectores.Add(proyector); // Agregar el nuevo proyector al contexto
                _context.SaveChanges(); // Guardar los cambios en la base de datos
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _context.Proyectores.ToList<Proyector>(); // Devolver todos los proyectores
        }
    }
}
