using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Body;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Cliente : Entity
    {
        public string NomeCliente { get; set; }

        public Cliente() { }
        public Cliente(CriarClienteRequestBody requestBody) => requestBody.MappingProperties(this);
    }
}
