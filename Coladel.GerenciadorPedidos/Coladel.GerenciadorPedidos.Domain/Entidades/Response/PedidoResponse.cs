using A4S.Core.Extensions;
using A4S.ERP.Domain.Enum;
using System;
using System.Collections.Generic;

namespace A4S.ERP.Domain.Entidades.Response
{
    public class PedidoResponse
    {
        public Guid Guid { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }

        public string NF { get; set; }
        public string Observacoes { get; set; }
        public decimal Total { get; set; }
        public DateTime DataCadastro { get; set; }

        public PedidoResponse(Pedido pedido) => pedido.MappingProperties(this); 
    }
}
