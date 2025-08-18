using AgiotaDoBem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgiotaDoBem.Infra.Context
{
    public class AgiotaDoBemContext : DbContext
    {
        public AgiotaDoBemContext(DbContextOptions<AgiotaDoBemContext> options ) : base( options )
        {
            
        }

        public DbSet<UsuarioModel> UsuarioModel { get; set; }
        public DbSet<DividasModel> DividasModel { get; set; }
    }

}
