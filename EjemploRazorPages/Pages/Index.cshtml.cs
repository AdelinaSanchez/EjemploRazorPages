using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjemploRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Persona Persona { get; set; }

        [BindProperty]
        public Ciudad Ciudad { get; set; }

        [TempData]
        public string Nombre { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost(String param1)
        {
            Nombre = param1;
            return RedirectToPage("Contact");

        }

        public void OnPostPersona()
        {

        }
        public void OnPostPersonaCiudad()
        {

        }
    }

    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
    }
}
