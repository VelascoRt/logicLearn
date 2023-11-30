using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using logicLearn.Data;
using logicLearn.Models;

namespace logicLearn.Pages.Cursos
{
    public class DetailsModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public DetailsModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        public Curso Curso { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos.FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }
            else
            {
                Curso = curso;
            }
            return Page();
        }
    }
}
