using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using logicLearn.Models;

namespace logicLearn.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Tema> Temas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Programador> Programadores { get; set; }
        public DbSet<Material> Materiales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Inscripcion>().ToTable("Inscripcion");
            modelBuilder.Entity<Tema>().ToTable("Tema");
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Plan>().ToTable("Plan");
            modelBuilder.Entity<Profesor>().ToTable("Profesor");
            modelBuilder.Entity<Programador>().ToTable("Programador");
            modelBuilder.Entity<Material>().ToTable("Material");
        }
    }
}
