
using HelpdeskManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace HelpdeskManager.Infrastructure
{
    public class HelpdeskDbContext : DbContext
    {
        public HelpdeskDbContext(DbContextOptions<HelpdeskDbContext> options) : base(options) { }

        public DbSet<Chamado> Chamados { get; set; }
    }
}
