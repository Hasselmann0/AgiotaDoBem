
using AgiotaDoBem.Domain.Entities;

namespace AgiotaDoBem.Infra.Interfaces
{
    public interface IUsuarioRepository
    {
        List<UsuarioModel> RetornarTodos();
    }
}
