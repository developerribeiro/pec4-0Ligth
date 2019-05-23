using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pec4_0Ligth.Models
{
    public class Pec4_0LigthContext : DbContext
    {
        public Pec4_0LigthContext (DbContextOptions<Pec4_0LigthContext> options)
            : base(options)
        {
        }

        public DbSet<Pec4_0Ligth.Models.Simulacao> Simulacao { get; set; }
    }
}
