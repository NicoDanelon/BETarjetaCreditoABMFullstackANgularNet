using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBComentario
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Models.TarjetaCredito>TarjetaCredito { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }
    }
}
