using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Body;
using System.Collections.Generic;
using Coladel.Core.Extensions;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Cliente : Entity
    {
        public short IdEndereco { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFantasia { get; set; }
        public Endereco Endereco { get; set; }
        public List<Email> Emails { get; set; } = new List<Email>();
        public List<Telefone> Telefones { get; set; } = new  List<Telefone>();

        public Cliente() { }
        public Cliente(CriarClienteRequestBody requestBody) => requestBody.MappingProperties(this);
    }
}
