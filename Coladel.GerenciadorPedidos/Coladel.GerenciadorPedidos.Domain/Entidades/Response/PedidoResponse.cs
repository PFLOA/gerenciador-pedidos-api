using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Entidades.Response
{
    public class PedidoResponse
    {
        public Guid Guid { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensPedido> ItensPedido { get; set; }
        public string NF { get; set; }
        public string Observacoes { get; set; }
        public decimal Total { get; set; }
        public DateTime DataCadastro { get; set; }
        public PedidoResponse(Pedido pedido) => pedido.MappingProperties(this); 
    }
}
