using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthRazor.Models;

    public class RazorHealth : DbContext
    {
        public RazorHealth (DbContextOptions<RazorHealth> options)
            : base(options)
        {
        }

        public DbSet<HealthRazor.Models.Health> Health { get; set; }
    }
