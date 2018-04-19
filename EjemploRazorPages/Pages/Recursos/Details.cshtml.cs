using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EjemploRazorPages.Models;

namespace EjemploRazorPages.Pages.Recursos
{
    public class DetailsModel : PageModel
    {
        private readonly EjemploRazorPages.Models.ApplicationDbContext _context;

        public DetailsModel(EjemploRazorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Recurso Recurso { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recurso = await _context.Recursos.SingleOrDefaultAsync(m => m.Id == id);

            if (Recurso == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
