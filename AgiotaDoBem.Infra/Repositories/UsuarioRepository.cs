using AgiotaDoBem.Domain.Entities;
using AgiotaDoBem.Infra.Context;
using AgiotaDoBem.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgiotaDoBem.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AgiotaDoBemContext _context;

        public UsuarioRepository(AgiotaDoBemContext context)
        {
            _context = context;
        }

        public List<UsuarioModel> RetornarTodos()
        {
            return _context.UsuarioModel.ToList();
        }
    }
}
