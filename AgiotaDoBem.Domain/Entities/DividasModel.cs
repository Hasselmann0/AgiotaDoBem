using AgiotaDoBem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgiotaDoBem.Domain.Entities
{
    public class DividasModel
    {
        public int Id { get; set; }
        public string NomeDoEstabelecimento { get; set; } = string.Empty;
        public double ValorTotalDaCompra { get; set; }
        public DateTime DiaDaCompra { get; set; } = DateTime.Now;
        public StatusDoPagamento Status { get; set; }
    }
}
