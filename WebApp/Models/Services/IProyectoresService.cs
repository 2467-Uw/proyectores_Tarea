namespace WebApp.Models.Services
{
    public interface IProyectoresService
    {
        IEnumerable<Proyector> GetAll();
        void AddProyector(Proyector proyector);
        //void EditProyector(int Id, Proyector proyector);
        //void DeleteProyector(int Id);
        Proyector? GetProyectorById(int id);
        void Update(Proyector proyector);
        Proyector? Delete(Proyector proyector);
    }
}
