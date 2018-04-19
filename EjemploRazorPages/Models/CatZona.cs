using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploRazorPages.Models
{
    public class CatZona
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Filas { get; set; }
        public int Asientos_por_fila { get; set; }
    }
}
