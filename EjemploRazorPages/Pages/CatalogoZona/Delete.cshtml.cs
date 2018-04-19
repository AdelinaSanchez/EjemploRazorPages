using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EjemploRazorPages.Models;

namespace EjemploRazorPages.Pages.CatalogoZona
{
    public class DeleteModel : PageModel
    {
        private readonly EjemploRazorPages.Models.ApplicationDbContext _context;

        public DeleteModel(EjemploRazorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CatZona CatZona { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CatZona = await _context.CatZona.SingleOrDefaultAsync(m => m.Id == id);

            if (CatZona == null)
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

            CatZona = await _context.CatZona.FindAsync(id);

            if (CatZona != null)
            {
                _context.CatZona.Remove(CatZona);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
