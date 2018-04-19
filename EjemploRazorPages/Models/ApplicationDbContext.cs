using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjemploRazorPages.Models;

namespace EjemploRazorPages.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<TipoEvento> TiposEventos { get; set; }
        public DbSet<EjemploRazorPages.Models.CatServicios> CatServicios { get; set; }
        public DbSet<EjemploRazorPages.Models.CatZona> CatZona { get; set; }
    }
}
