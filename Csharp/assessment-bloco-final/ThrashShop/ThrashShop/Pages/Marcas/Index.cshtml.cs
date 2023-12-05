using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThrashShop.Data;
using ThrashShop.Models;

namespace ThrashShop.Pages.Marcas
{
    public class IndexModel : PageModel
    {
        private readonly ThrashShop.Data.AppDbContext _context;

        public IndexModel(ThrashShop.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Marca> Marca { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marcas != null)
            {
                Marca = await _context.Marcas.ToListAsync();
            }
        }
    }
}
