using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Application.Interfaces.Generics
{
    public interface IApplication<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<bool> Update(TEntity entity);
    }
}
