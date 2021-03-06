﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EjemploRazorPages.Models;

namespace EjemploRazorPages.Pages.CatalogoServicios
{
    public class IndexModel : PageModel
    {
        private readonly EjemploRazorPages.Models.ApplicationDbContext _context;

        public IndexModel(EjemploRazorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CatServicios> CatServicios { get;set; }

        public async Task OnGetAsync()
        {
            CatServicios = await _context.CatServicios.ToListAsync();
        }
    }
}
