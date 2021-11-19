using AngularCSharpDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AngularCSharpDDD.Infrastructure.Data.Contexts
{
    public class AngularCSharpDDDContext : DbContext
    {
        public AngularCSharpDDDContext(DbContextOptions<AngularCSharpDDDContext> options) : base(options)
        {

        }

        DbSet<Escolaridade> Escolaridade { get; set; }
        DbSet<Usuario> Usuario { get; set; }
    }
}
