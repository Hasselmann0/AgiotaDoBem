using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgiotaDoBem.Domain
{
    public class UsuarioModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Estabelecimento { get; set; } = string.Empty;
        public double Valor { get; set; }
        public string Parcelas { get; set; } = string.Empty;
        public DateTime DiaDaCompra { get; set; } = DateTime.Now;
        public StatusDoPagamento Status { get; set; }
    }
}
