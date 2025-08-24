using AgiotaDoBem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgiotaDoBem.Application.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string NomeDoDevedor { get; set; } = string.Empty;
        public string NomeDoEstabelecimento { get; set; } = string.Empty;
        public double ValorTotalDaCompra { get; set; }
        public DateTime DiaDaCompra { get; set; } = DateTime.Now;
        public StatusDoPagamento Status { get; set; }
    }
}
