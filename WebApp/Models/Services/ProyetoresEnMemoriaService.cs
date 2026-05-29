namespace WebApp.Models.Services
{
    public class ProyetoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores = LoadData();
        public void AddProyector(Proyector proyector)
        {
            if (proyector != null)
            {
                _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _proyectores;
        }
        private static List<Proyector> LoadData()
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

        public Proyector? GetProyectorById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Proyector proyector)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
