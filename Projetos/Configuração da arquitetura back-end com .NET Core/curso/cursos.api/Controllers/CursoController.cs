using cursos.api.Models.Cursos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace cursos.api.Controllers
{
    [Route("api/v1/cursos")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar curso")]
        [SwaggerResponse(statusCode: 401, description: "Nao autorizado")]
        [HttpPost]
        [Route("")]
               
        public async Task<IActionResult> Post(CursoViewModelInput cursoViewModelInput)
        {
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            return Created("", cursoViewModelInput);
        }

        [HttpGet]
        [Route("")]

        public async Task<IActionResult> Get()
        {
            var cursos = new List<CursoViewModelOutput>();
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);

            //fake
            cursos.Add(new CursoViewModelOutput()
            {
                Login = codigoUsuario.ToString(),
                Descricao = "teste1",
                Nome = "Marcelo"
            });


            return Ok(cursos);
        }


    }
}
