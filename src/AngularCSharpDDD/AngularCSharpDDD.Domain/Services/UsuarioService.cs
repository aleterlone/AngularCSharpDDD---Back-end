using AngularCSharpDDD.Domain.Entities;
using AngularCSharpDDD.Domain.Interfaces.Repositorys;
using AngularCSharpDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService
        (
            IUsuarioRepository usuarioRepository
        )
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> Add(Usuario entity)
        {
            return await _usuarioRepository.Add(entity);
        }

        public async Task<bool> Delete(Usuario entity)
        {
            return await _usuarioRepository.Delete(entity);
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _usuarioRepository.GetAll();
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _usuarioRepository.GetById(id);
        }

        public async Task<bool> Update(Usuario entity)
        {
            return await _usuarioRepository.Update(entity);
        }
    }
}
