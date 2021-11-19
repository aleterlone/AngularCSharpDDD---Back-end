using AngularCSharpDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AngularCSharpDDD.Infrastructure.Data.Contexts
{
    public class AngularCSharpDDDContext : DbContext
    {
        public AngularCSharpDDDContext(DbContextOptions<AngularCSharpDDDContext> options) : base(options)
        {

        }

        public DbSet<Escolaridade> Escolaridade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
