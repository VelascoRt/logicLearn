using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Programadores
{
    public class EditModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public EditModel(logicLearn.Data.SchoolContext context)
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

            var programador =  await _context.Programadores.FirstOrDefaultAsync(m => m.ProgramadoresID == id);
            if (programador == null)
            {
                return NotFound();
            }
            Programador = programador;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Programador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramadorExists(Programador.ProgramadoresID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProgramadorExists(int id)
        {
            return _context.Programadores.Any(e => e.ProgramadoresID == id);
        }
    }
}
