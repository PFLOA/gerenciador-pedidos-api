using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System.Collections.Generic;

namespace A4S.ERP.Application.Handlers.Clientes.Response
{
    public class BuscarClientePorGuidResponse
    {
        public string DocumentoPrincipal { get; set; }
        public string DocumentoSecundario { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnae { get; set; }
        public string Site { get; set; }
        public string Observacoes { get; set; }
        public string InscricaoSuframa { get; set; }
        public string NomeFantasia { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        public Endereco Endereco { get; set; }
        public Endereco EnderecoCobranca { get; set; }
        public Endereco EnderecoEntrega { get; set; }
        public RamoAtividade RamoAtividade { get; set; }
        public CondicoesPagamento CondicoesPagamento { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public List<ContatoCliente> Contatos { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public List<ContasReceber> ContasReceber { get; set; }
        public List<NotaFiscal> NotasFiscais { get; set; }

        public BuscarClientePorGuidResponse(Cliente cliente) => cliente.MappingProperties(this);
    }
}
