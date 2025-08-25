using AgiotaDoBem.Application.DTOs;

namespace AgiotaDoBem.Application.Interfaces
{
    public interface IUsuarioApplication
    {
        void AdicionarUsuario(UsuarioDTO usuarioDTO);
        void AtualizarUsuario(UsuarioDTO usuarioDTO);
        void DeletarUsuario(int id);
        List<UsuarioDTO> RetornarTodos();
    }
}
