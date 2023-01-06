using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
    public class CriarClienteRequestBody
    {
        public string Ie { get; set; }
        public string Cnpj { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFantasia { get; set; }
        public Endereco Endereco { get; set; }
        public List<string> EmailRequest { get; set; }
        public List<Telefone> Telefones { get; set; } = new List<Telefone>();

        public virtual Cliente ToModel() => new Cliente(this);
    }
}
