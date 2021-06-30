
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Contratos;
using DomainLayer.Models;
using System;

namespace WebApiOnionArchitectureTemplate.Controllers.v1.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuariosService _usuarioService;


        public UsuarioController(IUsuariosService usuariosService)
        {
            _usuarioService = usuariosService;
        }

        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public IActionResult GetUsuarios()
        {
            var res = _usuarioService.GetAllUsuarios();
            if(res is not null)
            {
                return Ok(res);
            } else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Obtiene un unico usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetUsuario(String id)
        {
            var res = _usuarioService.GetUsuario(id);
            if(res is not null)
            {
                return Ok(res);
            } else
            {
                return NotFound();
            }
        }

        [HttpPost("")]
        public IActionResult InsertaUsuario([FromBody] DomainLayer.Models.UsuarioEntity usuario)
        {
            _usuarioService.InsertaUsuario(usuario);
            return Ok();
        }


        [HttpPut("")]
        public IActionResult ActualizaUsuario([FromBody] DomainLayer.Models.UsuarioEntity usuario)
        {
            _usuarioService.ActualizaUsuario(usuario);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult BorraUsuario(string id)
        {
            _usuarioService.BorraUsuario(id);
            return Ok();
        }
    }
}
