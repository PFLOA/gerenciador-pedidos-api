using Coladel.GerenciadorPedidos.Domain.Enum;
using System;

namespace Coladel.GerenciadorPedidos.Domain.Filters
{
    public class BuscarPedidosFiltroFilter
    {
        public StatusPedido StatusPedido { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string NF { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
