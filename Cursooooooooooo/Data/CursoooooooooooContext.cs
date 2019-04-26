using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cursooooooooooo.Models
{
    public class CursoooooooooooContext : DbContext
    {
        public CursoooooooooooContext (DbContextOptions<CursoooooooooooContext> options)
            : base(options)
        {
        }

        public DbSet<Cursooooooooooo.Models.Department> Department { get; set; }
    }
}
