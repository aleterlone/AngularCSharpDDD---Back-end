using AngularCSharpDDD.Application.Interfaces;
using AngularCSharpDDD.Domain.Entities;
using AngularCSharpDDD.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IEscolaridadeApplication _escolaridadeApplication;
        private readonly IUsuarioApplication _usuarioApplication;

        public UsuarioController
        (
            IEscolaridadeApplication escolaridadeApplication,
            IUsuarioApplication usuarioApplication
        )
        {
            _escolaridadeApplication = escolaridadeApplication;
            _usuarioApplication = usuarioApplication;
        }

        [Produces("application/json")]
        [HttpPost("Add")]
        public async Task<Usuario> Add(UsuarioModel model)
        {
            Usuario novoUsuario = new Usuario();

            novoUsuario.Nome = model.Nome;
            novoUsuario.Sobrenome = model.Sobrenome;
            novoUsuario.Email = model.Email;
            novoUsuario.DataNascimento = model.DataNascimento;
            novoUsuario.Escolaridade = await _escolaridadeApplication.GetById(model.EscolaridadeId);

            return await _usuarioApplication.Add(novoUsuario);
        }

        [Produces("application/json")]
        [HttpDelete("Delete")]
        public async Task<bool> Delete(int id)
        {
            Usuario usuario = await _usuarioApplication.GetById(id);

            if (usuario != null)
            {
                return await _usuarioApplication.Delete(usuario);
            }
            else
            {
                return false;
            }
        }

        [Produces("application/json")]
        [HttpGet("GetAll")]
        public async Task<List<Usuario>> GetAll()
        {
            return await _usuarioApplication.GetAll();
        }

        [Produces("application/json")]
        [HttpGet("GetById")]
        public async Task<Usuario> GetById(int id)
        {
            return await _usuarioApplication.GetById(id);
        }

        [Produces("application/json")]
        [HttpPut("Update")]
        public async Task<bool> Update(UsuarioModel model)
        {
            Usuario usuario = await _usuarioApplication.GetById(model.Id);

            if (usuario != null)
            {
                usuario.Nome = model.Nome;
                usuario.Sobrenome = model.Sobrenome;
                usuario.Email = model.Email;
                usuario.DataNascimento = model.DataNascimento;
                usuario.Escolaridade = await _escolaridadeApplication.GetById(model.EscolaridadeId);

                return await _usuarioApplication.Update(usuario);
            }
            else
            {
                return false;
            }
        }
    }
}
