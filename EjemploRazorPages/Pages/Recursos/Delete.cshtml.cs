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
    public class DeleteModel : PageModel
    {
        private readonly EjemploRazorPages.Models.ApplicationDbContext _context;

        public DeleteModel(EjemploRazorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recurso = await _context.Recursos.FindAsync(id);

            if (Recurso != null)
            {
                _context.Recursos.Remove(Recurso);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
