using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmesCRUDRazor.models;

namespace FilmesCRUDRazor.pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly FilmesCRUDRazor.models.FilmeContext _context;

        public IndexModel(FilmesCRUDRazor.models.FilmeContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; }

        public async Task OnGetAsync()
        {
            Filme = await _context.Filme.ToListAsync();
        }
    }
}
