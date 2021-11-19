using AngularCSharpDDD.Application.Interfaces;
using AngularCSharpDDD.Domain.Entities;
using AngularCSharpDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Application.Application
{
    public class EscolaridadeApplication : IEscolaridadeApplication
    {
        private readonly IEscolaridadeService _escolaridadeService;

        public EscolaridadeApplication
        (
            IEscolaridadeService escolaridadeService
        )
        {
            _escolaridadeService = escolaridadeService;
        }

        public async Task<Escolaridade> Add(Escolaridade entity)
        {
            return await _escolaridadeService.Add(entity);
        }

        public async Task<bool> Delete(Escolaridade entity)
        {
            return await _escolaridadeService.Delete(entity);
        }

        public async Task<List<Escolaridade>> GetAll()
        {
            return await _escolaridadeService.GetAll();
        }

        public async Task<Escolaridade> GetById(int id)
        {
            return await _escolaridadeService.GetById(id);
        }

        public async Task<bool> Update(Escolaridade entity)
        {
            return await _escolaridadeService.Update(entity);
        }
    }
}
