using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HealthRazor.Models;

namespace HealthRazor.Pages_Health
{
    public class CreateModel : PageModel
    {
        private readonly RazorHealth _context;

        public CreateModel(RazorHealth context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Health Health { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Health.Add(Health);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
