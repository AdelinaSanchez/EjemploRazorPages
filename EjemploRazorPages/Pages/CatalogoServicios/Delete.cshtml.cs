using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EjemploRazorPages.Models;

namespace EjemploRazorPages.Pages.CatalogoServicios
{
    public class DeleteModel : PageModel
    {
        private readonly EjemploRazorPages.Models.ApplicationDbContext _context;

        public DeleteModel(EjemploRazorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CatServicios CatServicios { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CatServicios = await _context.CatServicios.SingleOrDefaultAsync(m => m.Id == id);

            if (CatServicios == null)
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

            CatServicios = await _context.CatServicios.FindAsync(id);

            if (CatServicios != null)
            {
                _context.CatServicios.Remove(CatServicios);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
