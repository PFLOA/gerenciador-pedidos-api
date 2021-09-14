using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
    public class CriarPedidoBody
    {
        public StatusPedido StatusPedido { get; set; }
        public string NF { get; set; }
        public string Observacoes { get; set; }
        public decimal Total { get; set; }
        public Guid ClienteGuid { get; set; }
        public List<ItensPedido> ItenPedido { get; set; }
        public virtual Pedido ToModel() => new Pedido(this);
    }
}
