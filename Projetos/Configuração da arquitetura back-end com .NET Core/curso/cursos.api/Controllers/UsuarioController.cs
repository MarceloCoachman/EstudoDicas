using cursos.api.Filters;
using cursos.api.Models;
using cursos.api.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace cursos.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    
    {
        private object usuarioViewModelOutput;

        ///<summary>
        ///Permite autenticar usuario cadastrado e ativo
        ///</summary>
        ///<param name="loginViewModelInput">View model do login</param>
        ///<returns>Status usuario e token OK</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatorios", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(ErroGenericoViewModel))]

        [HttpPost]
        [Route("logar")]

        [ValidacaoModelStateCustomizado]

        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            //}

            //login fake
            var usuarioViewModelOutput = new UsuarioViewModelOutput()
            {
                Codigo=1 ,
                Login = "Marcelo",
                Email = "marcelo@marcelo.br"
            };


            var secret = Encoding.ASCII.GetBytes("123456789qwertyuiopasdfghjklçzxzcvbnm,.;/@#$%¨&*");
            var symmetricSecurityKey = new SymmetricSecurityKey(secret);
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, usuarioViewModelOutput.Codigo.ToString()),
                    new Claim(ClaimTypes.Name, usuarioViewModelOutput.Login.ToString()),
                    new Claim(ClaimTypes.Email, usuarioViewModelOutput.Email.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
                
                };
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenGenerated = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(tokenGenerated);

            return Ok (new 
            {
                Token = token,
                Usuario = usuarioViewModelOutput
            } );
        }

        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateCustomizado]

        public IActionResult Registrar(LoginViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }


    }
}
