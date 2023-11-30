using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public DetailsModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
        .Include(s => s.Inscripciones)
        .ThenInclude(e => e.Cursos)
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.ClienteID == id);

            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                Cliente = cliente;
            }
            return Page();
        }
    }
}
