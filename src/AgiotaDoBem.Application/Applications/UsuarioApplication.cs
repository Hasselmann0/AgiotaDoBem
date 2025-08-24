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
                Id = x.Id,
                NomeDoDevedor = x.NomeDoDevedor,
                NomeDoEstabelecimento = x.DividasParaPagar?.NomeDoEstabelecimento ?? string.Empty,
                ValorTotalDaCompra = x.DividasParaPagar?.ValorTotalDaCompra ?? 0,
                DiaDaCompra = x.DividasParaPagar?.DiaDaCompra ?? DateTime.MinValue,
                Status = x.DividasParaPagar?.Status ?? 0
            }).ToList();
           
        }

        public void AdicionarUsuario(UsuarioDTO usuarioDTO)
        {
            var divida = new DividasModel
            {
                NomeDoEstabelecimento = usuarioDTO.NomeDoEstabelecimento,
                ValorTotalDaCompra = usuarioDTO.ValorTotalDaCompra,
                DiaDaCompra = usuarioDTO.DiaDaCompra,
                Status = usuarioDTO.Status
            };

            var usuario = new UsuarioModel
            {
                NomeDoDevedor =  usuarioDTO.NomeDoDevedor,
                DividasParaPagar = divida

            };
            _usuarioRepository.AdicionarUsuario(usuario);
        }

        public void AtualizarUsuario(UsuarioDTO usuarioDTO)
        {

            var usuario = _usuarioRepository.ObterPorId(usuarioDTO.Id);

            usuario.NomeDoDevedor = usuarioDTO.NomeDoDevedor;
            usuario.DividasParaPagar.NomeDoEstabelecimento = usuarioDTO.NomeDoEstabelecimento;
            usuario.DividasParaPagar.ValorTotalDaCompra = usuarioDTO.ValorTotalDaCompra;
            usuario.DividasParaPagar.DiaDaCompra = usuarioDTO.DiaDaCompra;
            usuario.DividasParaPagar.Status = usuarioDTO.Status;

            _usuarioRepository.AtualizarUsuario(usuario);
            
            
        }

        public void DeletarUsuario(int id)
        {
            UsuarioModel usuario = _usuarioRepository.ObterPorId(id);
            _usuarioRepository.DeletarUsuario(usuario);
        }
    }
}
