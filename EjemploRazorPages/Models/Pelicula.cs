using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploRazorPages.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nomrbe { get; set; }
        public DateTime Estreno { get; set; }
        public bool EnCartelera { get; set; }
    }
}
