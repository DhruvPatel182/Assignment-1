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
    public class DeleteModel : PageModel
    {
        private readonly RazorHealth _context;

        public DeleteModel(RazorHealth context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Health = await _context.Health.FindAsync(id);

            if (Health != null)
            {
                _context.Health.Remove(Health);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
