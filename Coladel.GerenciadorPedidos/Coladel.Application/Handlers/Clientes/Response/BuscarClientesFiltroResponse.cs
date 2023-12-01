using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System;

namespace A4S.Application.Handlers.Clientes.Response
{
    public class BuscarClientesFiltroResponse
    {
        public short Id { get; set; }
        public string RazaoSocial { get; set; }
        public string DocumentoPrincipal { get; set; }
        public string DocumentoSecundario { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Cnae { get; set; }
        public string Site { get; set; }
        public string Observacoes { get; set; }
        public string InscricaoSuframa { get; set; }
        public string NomeFantasia { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        public DateTime DataCadastro { get; set; }
        public Guid Guid { get; set; }

        public BuscarClientesFiltroResponse(Cliente cliente)
        {
            cliente.MappingProperties(this);
        }
    }
}
