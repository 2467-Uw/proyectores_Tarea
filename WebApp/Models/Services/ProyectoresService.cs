using WebApp.Data;
using WebApp.Data.Migrations;
using WebApp.Models;

namespace WebApp.Models.Services
{
    public class ProyectoresService : IProyectoresService
    {
        private readonly AppDBContext _contexto;

        public ProyectoresService(AppDBContext context)
        {
            this._contexto = context;
        }
        public void AddProyector(Proyector proyector)
        {
            if (proyector != null) // Verificar que el proyector no sea nulo
            {
                _contexto.Proyectores.Add(proyector); // Agregar el nuevo proyector al contexto
                _contexto.SaveChanges(); // Guardar los cambios en la base de datos
            }
        }

        public Proyector? Delete(Proyector proyector)
        {
           
            if (proyector != null)
            {
                _contexto.Remove(proyector);
                _contexto.SaveChanges();
                return proyector;
            }
            return null;
        }

        public Proyector? GetProyectorById(int id)
        {

            return _contexto.Proyectores.FirstOrDefault<Proyector>(p => p.Id == id); // Buscar el proyector por su ID y devolverlo

        }

        public IEnumerable<Proyector> GetAll()
        {

            return _contexto.Proyectores.ToList<Proyector>(); // Devolver todos los proyectores
        }

        public void Update(Proyector proyector)
        {
            if (proyector != null) // Verificar que el proyector no sea nulo
            {
                _contexto.Proyectores.Update(proyector); // Actualizar el proyector en el contexto
                _contexto.SaveChanges(); // Guardar los cambios en la base de datos
            }

        }
    }
}
