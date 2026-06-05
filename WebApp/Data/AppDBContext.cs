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

            modelBuilder.Entity<Proyector>().ToTable("Proyectores")
                .HasOne(e => e.Departamento)
                .WithMany(e => e.Proyectores)
                .HasForeignKey(e => e.DepartamentoId)
                .IsRequired();
            modelBuilder.Entity<Departamento>().ToTable("Departamentos")
                //.HasMany(e => e.Proyectores)
                //.WithOne(e => e.Departamento)
                //.HasForeignKey(e => e.DepartamentoId)
                //.IsRequired()
                .HasData(
                new Departamento
                { 
                    Id = 1, Titulo = "Departamento de Sistemas y Computación" 
                },
                new Departamento
                {
                    Id = 2,
                    Titulo = "Departamento de Ingeniería Industrial" 
                },
                new Departamento
                {
                    Id = 3,
                    Titulo = "Departamento de Ingeniería Civil"
                },
                new Departamento
                {
                    Id = 4,
                    Titulo = "Departamento de Ciencias de la Tierra"
                },
                new Departamento
                {
                    Id = 5,
                    Titulo = "Departamento de Ciencias Economico-Administrativas"
                },
                new Departamento
                {
                    Id = 6,
                    Titulo = "Departamento de Ingeniería Mecánica"
                },
                new Departamento
                {
                    Id = 7,
                    Titulo = "Departamento de Ingeniería Química"
                },
                new Departamento
                {
                    Id = 8,
                    Titulo = "Departamento de Ciencias Basicas"
                }
            );
        }

    }
}
