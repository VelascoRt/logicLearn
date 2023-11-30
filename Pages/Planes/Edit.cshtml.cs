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

namespace logicLearn.Pages.Planes
{
    public class EditModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public EditModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Plan Plan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan =  await _context.Planes.FirstOrDefaultAsync(m => m.PagoID == id);
            if (plan == null)
            {
                return NotFound();
            }
            Plan = plan;
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

            _context.Attach(Plan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(Plan.PagoID))
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

        private bool PlanExists(int id)
        {
            return _context.Planes.Any(e => e.PagoID == id);
        }
    }
}
