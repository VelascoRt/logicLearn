using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Materiales
{
    public class DeleteModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public DeleteModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Material Material { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _context.Materiales.FirstOrDefaultAsync(m => m.MaterialID == id);

            if (material == null)
            {
                return NotFound();
            }
            else
            {
                Material = material;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _context.Materiales.FindAsync(id);
            if (material != null)
            {
                Material = material;
                _context.Materiales.Remove(Material);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
