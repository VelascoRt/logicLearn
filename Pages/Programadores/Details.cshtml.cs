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
    public class DetailsModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public DetailsModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

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
    }
}
