using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
    public class CriarPedidoBody
    {
        public StatusPedido StatusPedido { get; set; }
        public List<Produto> ProdutosList { get; set; }
        public Cliente Cliente { get; set; }
        public string NF { get; set; }
        public string Observacoes { get; set; }
        public decimal Total { get; set; }
        public virtual Pedido ToModel() => new Pedido(this);
    }
}
