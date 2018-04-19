using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EjemploRazorPages.Models;

namespace EjemploRazorPages.Pages.TiposEventos
{
    public class DeleteModel : PageModel
    {
        private readonly EjemploRazorPages.Models.ApplicationDbContext _context;

        public DeleteModel(EjemploRazorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TipoEvento TipoEvento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoEvento = await _context.TiposEventos.SingleOrDefaultAsync(m => m.Id == id);

            if (TipoEvento == null)
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

            TipoEvento = await _context.TiposEventos.FindAsync(id);

            if (TipoEvento != null)
            {
                _context.TiposEventos.Remove(TipoEvento);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
