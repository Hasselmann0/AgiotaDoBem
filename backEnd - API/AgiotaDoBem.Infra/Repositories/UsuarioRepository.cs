using AgiotaDoBem.Domain.Entities;
using AgiotaDoBem.Infra.Context;
using AgiotaDoBem.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
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
            return _context.UsuariosDb
                .Include(u => u.DividasParaPagar)
                .ToList();
        }


        public UsuarioModel ObterPorId(int id)
        {
            return _context.UsuariosDb
                .Include(u => u.DividasParaPagar)
                .FirstOrDefault(u => u.Id == id);
        }

        public void AdicionarUsuario(UsuarioModel usuarioDTO)
        {
            _context.UsuariosDb.Add(usuarioDTO);
            _context.SaveChanges();
        }

        public void AtualizarUsuario(UsuarioModel usuarioDTO)
        {
            _context.UsuariosDb.Update(usuarioDTO);
            _context.SaveChanges();
        }

        public void DeletarUsuario(UsuarioModel id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
    }
}
