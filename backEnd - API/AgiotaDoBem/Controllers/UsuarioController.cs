using Microsoft.AspNetCore.Mvc;
using AgiotaDoBem.Application.Applications;
using AgiotaDoBem.Application.Interfaces;
using AgiotaDoBem.Application;
using AgiotaDoBem.Application.DTOs;

namespace AgiotaDoBem.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;
        public UsuarioController(IUsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }


        [HttpGet]
        [Route("usuarios")]
        public IActionResult Usuarios()
        {
            return Ok(_usuarioApplication.RetornarTodos());
        }

        [HttpPost]
        [Route("adicionar-usuario")]
        public IActionResult AdicionarUsuario(UsuarioDTO usuarioDTO)
        {
            _usuarioApplication.AdicionarUsuario(usuarioDTO);
            return Ok();
        }

        [HttpPut]
        [Route("atualizar-usuario/{id}")]
        public IActionResult AtualizarUsuario(UsuarioDTO usuarioDTO)
        {
            _usuarioApplication.AtualizarUsuario(usuarioDTO);
            return Ok();
        }

        [HttpDelete]
        [Route("deletar-usuario/{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            _usuarioApplication.DeletarUsuario(id);
            return Ok();
        }



    }
}
