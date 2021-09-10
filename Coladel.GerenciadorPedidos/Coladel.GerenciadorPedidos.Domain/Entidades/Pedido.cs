using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Pedido : Entity
    {
        public StatusPedido StatusPedido { get; set; }
        public short IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensPedido> ItensPedido { get; set; }
        public string NF { get; set; }
        public string Observacoes { get; set; }
        public decimal Total { get; set; }
        public Pedido() { }
        public Pedido(CriarPedidoBody criarPedidoBody) => criarPedidoBody.MappingProperties(this);
    }
}
