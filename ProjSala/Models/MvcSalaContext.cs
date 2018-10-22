using Microsoft.EntityFrameworkCore;

namespace ProjSala.Models
{
    public class MvcSalaContext : DbContext
    {
        public MvcSalaContext (DbContextOptions<MvcSalaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjSala.Models.Sala> Sala { get; set; }
    }
}