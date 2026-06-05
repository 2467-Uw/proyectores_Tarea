using Microsoft.EntityFrameworkCore;
using WebApp.Models;
  

namespace WebApp.Data.Migrations
{
    public class AppDBContext : DbContext
    {
        public DbSet<Proyector> Proyectores { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }


        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Proyector>().ToTable("Proyectores");
            modelBuilder.Entity<Departamento>().ToTable("Departamentos");
        }

    }
}
