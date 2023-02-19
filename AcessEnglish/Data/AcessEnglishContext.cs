using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcessEnglish.Models;

namespace AcessEnglish.Data
{
    public class AcessEnglishContext : DbContext
    {
        public AcessEnglishContext (DbContextOptions<AcessEnglishContext> options)
            : base(options)
        {
        }

        public DbSet<AcessEnglish.Models.Department> Department { get; set; } = default!;
    }
}
