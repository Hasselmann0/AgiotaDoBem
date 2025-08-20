using AgiotaDoBem.Application.DTOs;
using AgiotaDoBem.Application.Interfaces;
using AgiotaDoBem.Domain.Entities;
using AgiotaDoBem.Infra.Interfaces;

namespace AgiotaDoBem.Application.Applications
{
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioApplication(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        List<UsuarioDTO> IUsuarioApplication.RetornarTodos()
        {
            List<UsuarioModel> usuarios = _usuarioRepository.RetornarTodos();

            return usuarios.Select(x => new UsuarioDTO 
            {
                NomeDoDevedor = x.NomeDoDevedor,
                NomeDoEstabelecimento = x.DividasParaPagar.NomeDoEstabelecimento,
                ValorTotalDaCompra = x.DividasParaPagar.ValorTotalDaCompra,
                DiaDaCompra = x.DividasParaPagar.DiaDaCompra,
                Status = x.DividasParaPagar.Status

            }).ToList();
        }
    }
}
