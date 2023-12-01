using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using System;

namespace A4S.Application.Handlers.Clientes.Response
{
    public class CriarClienteResponse
    {
        public Guid Guid { get; set; }
        public DateTime DataCadastro { get; set; }

        public string RazaoSocial { get; set; }

        public CondicoesPagamento CondicoesPagamento { get; set; }
        public Endereco Endereco { get; set; }
        public Endereco EnderecoCobranca { get; set; }
        public Endereco EnderecoEntrega { get; set; }

        public CriarClienteResponse(Cliente cliente) => cliente.MappingProperties(this);
    }
}
