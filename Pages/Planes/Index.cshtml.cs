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
    public class IndexModel : PageModel
    {
        private readonly logicLearn.Data.SchoolContext _context;

        public IndexModel(logicLearn.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Plan> Plan { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Plan = await _context.Planes.ToListAsync();
        }
    }
}
