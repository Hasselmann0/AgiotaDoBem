using Microsoft.AspNetCore.Mvc;
using AgiotaDoBem.Application.Applications;
using AgiotaDoBem.Application.Interfaces;
using AgiotaDoBem.Application;

namespace AgiotaDoBem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;
        public UsuarioController(IUsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }


        [HttpGet]
        public IActionResult Usuario()
        {
            return Ok(_usuarioApplication.RetornarTodos());
        }



    }
}
