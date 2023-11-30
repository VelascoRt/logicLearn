using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Planes
{
    public class CreateModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public CreateModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Plan Plan { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Planes.Add(Plan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
