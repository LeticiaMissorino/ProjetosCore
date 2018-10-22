using Microsoft.EntityFrameworkCore;

namespace Proj1.Models
{
    public class MvcPessoaContext : DbContext
    {
        public MvcPessoaContext (DbContextOptions<MvcPessoaContext> options)
            : base(options)
        {
        }

        public DbSet<Proj1.Models.Pessoa> Pessoa { get; set; }
    }
}