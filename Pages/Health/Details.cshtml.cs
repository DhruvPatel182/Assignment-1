using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthRazor.Models;

namespace HealthRazor.Pages_Health
{
    public class DetailsModel : PageModel
    {
        private readonly RazorHealth _context;

        public DetailsModel(RazorHealth context)
        {
            _context = context;
        }

        public Health Health { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Health = await _context.Health.FirstOrDefaultAsync(m => m.ID == id);

            if (Health == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
