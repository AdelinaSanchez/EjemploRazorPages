using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EjemploRazorPages.Models;

namespace EjemploRazorPages.Pages.CatalogoServicios
{
    public class CreateModel : PageModel
    {
        private readonly EjemploRazorPages.Models.ApplicationDbContext _context;

        public CreateModel(EjemploRazorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CatServicios CatServicios { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CatServicios.Add(CatServicios);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}