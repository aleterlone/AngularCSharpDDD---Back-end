using AngularCSharpDDD.Domain.Entities;
using AngularCSharpDDD.Domain.Interfaces.Repositorys;
using AngularCSharpDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Domain.Services
{
    public class EscolaridadeService : IEscolaridadeService
    {
        private readonly IEscolaridadeRepository _escolaridadeRepository;

        public EscolaridadeService
        (
            IEscolaridadeRepository escolaridadeRepository
        )
        {
            _escolaridadeRepository = escolaridadeRepository;
        }

        public async Task<Escolaridade> Add(Escolaridade entity)
        {
            return await _escolaridadeRepository.Add(entity);
        }

        public async Task<bool> Delete(Escolaridade entity)
        {
            return await _escolaridadeRepository.Delete(entity);
        }

        public async Task<List<Escolaridade>> GetAll()
        {
            return await _escolaridadeRepository.GetAll();
        }

        public async Task<Escolaridade> GetById(int id)
        {
            return await _escolaridadeRepository.GetById(id);
        }

        public async Task<bool> Update(Escolaridade entity)
        {
            return await _escolaridadeRepository.Update(entity);
        }
    }
}
