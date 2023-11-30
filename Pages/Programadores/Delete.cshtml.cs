using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Programadores
{
    public class DeleteModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public DeleteModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Programador Programador { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Programadores.FirstOrDefaultAsync(m => m.ProgramadoresID == id);

            if (programador == null)
            {
                return NotFound();
            }
            else
            {
                Programador = programador;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programador = await _context.Programadores.FindAsync(id);
            if (programador != null)
            {
                Programador = programador;
                _context.Programadores.Remove(Programador);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
