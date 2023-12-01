using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System;
using System.Collections.Generic;

namespace A4S.Application.Handlers.Pedidos.Response
{
    public class BuscarPedidoPorGuidResponse
    {
        public short Id { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public string NF { get; set; }
        public string Observacoes { get; set; }
        public decimal Total { get; set; }
        public DateTime DataCadastro { get; set; }
        public ClienteResponse ClienteResponse { get; set; } = new ClienteResponse();
        public decimal TotalComissao { get; set; }
        public List<ItensPedidoResponse> ItensPedidoResponse { get; set; } = new List<ItensPedidoResponse>();

        public BuscarPedidoPorGuidResponse(Pedido mapping)
        {
            mapping.MappingProperties(this);

            mapping.Cliente?.MappingProperties(ClienteResponse);

            mapping.ItensPedido.ForEach(item =>
            {
                ItensPedidoResponse.Add(new ItensPedidoResponse(item));
            });
        }
    }
}
