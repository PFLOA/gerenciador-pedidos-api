using Coladel.Core.Extensions;
using Coladel.GerenciadorAulas.Domain.Entidades.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Coladel.Application.Handlers.Pedidos.Response
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
