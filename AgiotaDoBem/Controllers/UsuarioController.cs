using Microsoft.AspNetCore.Mvc;
using AgiotaDoBem.Application.Applications;
using AgiotaDoBem.Application.Interfaces;

namespace AgiotaDoBem.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;
        public UsuarioController(IUsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }


        [HttpGet]
        public IActionResult Usuario ()
        {

        }



    }
}
