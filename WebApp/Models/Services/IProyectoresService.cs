namespace WebApp.Models.Services
{
    public interface IProyectoresService
    {
        IEnumerable<Proyector> GetAll();
        void AddProyector(Proyector proyector);
        //void EditProyector(int Id, Proyector proyector);
        //void DeleteProyector(int Id);
    }
}
