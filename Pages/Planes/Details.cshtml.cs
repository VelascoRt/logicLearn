using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Planes
{
    public class DetailsModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public DetailsModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        public Plan Plan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Planes.FirstOrDefaultAsync(m => m.PagoID == id);
            if (plan == null)
            {
                return NotFound();
            }
            else
            {
                Plan = plan;
            }
            return Page();
        }
    }
}
