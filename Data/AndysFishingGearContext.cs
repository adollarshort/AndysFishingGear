using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndysFishingGear.Models;

namespace AndysFishingGear.Data
{
    public class AndysFishingGearContext : DbContext
    {
        public AndysFishingGearContext (DbContextOptions<AndysFishingGearContext> options)
            : base(options)
        {
        }

        public DbSet<AndysFishingGear.Models.Gear> Gear { get; set; }
    }
}
