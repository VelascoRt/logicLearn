using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Profesores
{
    public class DeleteModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public DeleteModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Profesor Profesor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesores.FirstOrDefaultAsync(m => m.ProfesorID == id);

            if (profesor == null)
            {
                return NotFound();
            }
            else
            {
                Profesor = profesor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor != null)
            {
                Profesor = profesor;
                _context.Profesores.Remove(Profesor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
