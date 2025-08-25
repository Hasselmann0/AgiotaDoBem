
using AgiotaDoBem.Domain.Entities;

namespace AgiotaDoBem.Infra.Interfaces
{
    public interface IUsuarioRepository
    {
        List<UsuarioModel> RetornarTodos();
        void AdicionarUsuario(UsuarioModel usuarioDTO);
        void AtualizarUsuario(UsuarioModel usuarioDTO);
        void DeletarUsuario(UsuarioModel id);
        UsuarioModel ObterPorId (int id);
    }
}
