using Coladel.GerenciadorPedidos.Domain.Enum;
using Coladel.Core.Models;
using System;

namespace Coladel.GerenciadorPedidos.Domain.Filters
{
    public class BuscarPedidosFiltroFilter : BaseFilter
    {
        public StatusPedido? StatusPedido { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string NF { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}
