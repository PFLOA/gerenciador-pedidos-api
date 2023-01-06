using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Collections.Generic;
using Coladel.Core.Extensions;
using System;

namespace Coladel.Application.Handlers.Clientes.Response
{
    public class CriarClienteResponse
    {
        public Guid Guid { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NomeCliente { get; set; }
        public List<EmailResponse> EmailsRes { get; set; } = new List<EmailResponse>();

        public CriarClienteResponse(Cliente cliente)
        {
            cliente.MappingProperties(this);
            cliente.Emails.ForEach(e => EmailsRes.Add(new EmailResponse
            {
                Email = e.Descricao,
                Id = e.Id
            }));
        }
    }
}
