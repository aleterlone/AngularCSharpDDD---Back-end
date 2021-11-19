using AngularCSharpDDD.Application.Interfaces;
using AngularCSharpDDD.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharpDDD.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaridadeController : ControllerBase
    {
        private readonly IEscolaridadeApplication _escolaridadeApplication;

        public EscolaridadeController
        (
            IEscolaridadeApplication escolaridadeApplication
        )
        {
            _escolaridadeApplication = escolaridadeApplication;
        }

        [Produces("application/json")]
        [HttpGet("GetAll")]
        public async Task<List<Escolaridade>> GetAll()
        {
            return await _escolaridadeApplication.GetAll();
        }
    }
}
