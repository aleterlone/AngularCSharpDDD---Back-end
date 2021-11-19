using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Domain.Interfaces.Repositorys.Generics
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<bool> Update(TEntity entity);
    }
}
