using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgiotaDoBem.Domain.Entities
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string NomeDoDevedor { get; set; } = string.Empty;
        public DividasModel DividasParaPagar { get; set; }
        
    }
}
