using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_ef.Models;
using Microsoft.EntityFrameworkCore;


namespace exercicio_ef
{
    public class AppContext : DbContext
    {

        public DbSet<Registro>? registros{get; set;}

        public DbSet<Caderno>? cadernos{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
            UseSqlServer("Data Source =LAPTOP-8GNEVC2L; Initial Catalog=Exercicio01BD; Integrated Security=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caderno>().
            HasMany(e => e.registros)
            .WithOne(e => e.caderno)
            .HasForeignKey(e => e.cadernoId)
            .HasPrincipalKey(e => e.id);
        }
    }
}