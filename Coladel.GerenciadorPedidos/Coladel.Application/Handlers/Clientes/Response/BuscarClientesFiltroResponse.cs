using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Coladel.Application.Handlers.Clientes.Response
{
    public class BuscarClientesFiltroResponse
    {
        public string NomeCliente { get; set; }
        public List<string> Email { get; set; } = new List<string>();
        public Guid Guid { get; set; }

        public BuscarClientesFiltroResponse(Cliente cliente)
        {
            cliente.MappingProperties(this);

            if(cliente.Emails.Count > 0)
            {
                cliente.Emails.ForEach(email => Email.Add(email.Descricao));
            }
        }
    }
}
