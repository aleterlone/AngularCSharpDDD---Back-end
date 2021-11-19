using AngularCSharpDDD.Domain.Entities;
using AngularCSharpDDD.Domain.Interfaces.Repositorys;
using AngularCSharpDDD.Infrastructure.Data.Contexts;
using AngularCSharpDDD.Infrastructure.Data.Repositorys.Generics;

namespace AngularCSharpDDD.Infrastructure.Data.Repositorys
{
    public class EscolaridadeRepository : Repository<Escolaridade>, IEscolaridadeRepository
    {
        public EscolaridadeRepository(AngularCSharpDDDContext dbContext) : base(dbContext)
        {

        }
    }
}
