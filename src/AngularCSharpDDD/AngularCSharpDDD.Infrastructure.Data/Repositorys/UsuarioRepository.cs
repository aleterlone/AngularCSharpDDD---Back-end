using AngularCSharpDDD.Domain.Entities;
using AngularCSharpDDD.Domain.Interfaces.Repositorys;
using AngularCSharpDDD.Infrastructure.Data.Contexts;
using AngularCSharpDDD.Infrastructure.Data.Repositorys.Generics;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Infrastructure.Data.Repositorys
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AngularCSharpDDDContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Usuario> GetById(int id)
        {
            return await _dbContext.Usuario.Where(usuario => usuario.Id == id).Include(usuario => usuario.Escolaridade).FirstOrDefaultAsync();
        }

        public override async Task<List<Usuario>> GetAll()
        {
            return await _dbContext.Usuario.Include(usuario => usuario.Escolaridade).ToListAsync();
        }
    }
}
