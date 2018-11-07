using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITS.Models;

namespace ITS.Models
{
    public class ITSContext : DbContext
    {
        public ITSContext (DbContextOptions<ITSContext> options)
            : base(options)
        {
        }

        public DbSet<ITS.Models.Cursos> Cursos { get; set; }

        public DbSet<ITS.Models.Curso> Curso { get; set; }
    }
}
