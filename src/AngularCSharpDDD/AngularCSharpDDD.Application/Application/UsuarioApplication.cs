using AngularCSharpDDD.Application.Interfaces;
using AngularCSharpDDD.Domain.Entities;
using AngularCSharpDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Application.Application
{
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioApplication
        (
            IUsuarioService usuarioService
        )
        {
            _usuarioService = usuarioService;
        }

        public async Task<Usuario> Add(Usuario entity)
        {
            return await _usuarioService.Add(entity);
        }

        public async Task<bool> Delete(Usuario entity)
        {
            return await _usuarioService.Delete(entity);
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _usuarioService.GetAll();
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _usuarioService.GetById(id);
        }

        public async Task<bool> Update(Usuario entity)
        {
            return await _usuarioService.Update(entity);
        }
    }
}
