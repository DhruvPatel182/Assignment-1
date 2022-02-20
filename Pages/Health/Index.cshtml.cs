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
    public class IndexModel : PageModel
    {
        private readonly RazorHealth _context;

        public IndexModel(RazorHealth context)
        {
            _context = context;
        }

        public IList<Health> Health { get;set; }

        public async Task OnGetAsync()
        {
            Health = await _context.Health.ToListAsync();
        }
    }
}
