using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;

namespace Coladel.Application.Handlers.Clientes.Response
{
    public class BuscarClientesFiltroResponse
    {
        public string NomeCliente { get; set; }
        public Guid Guid { get; set; }
        public BuscarClientesFiltroResponse(Cliente cliente)
        {
            cliente.MappingProperties(this);
        }
    }
}
