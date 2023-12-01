using A4S.Core.Extensions;
using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Enum;
using System.Collections.Generic;

namespace A4S.ERP.Domain.Entidades
{
    public class Cliente : Entity
    {
        public short? EnderecoId { get; set; }
        public short? EnderecoCobrancaId { get; set; }
        public short? EnderecoEntregaId { get; set; }
        public short? RamoAtividadeId { get; set; }
        public short? CondicoesPagamentoId { get; set; }
        public short? TipoClienteId { get; set; }

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

        public virtual Endereco Endereco { get; set; }
        public virtual Endereco EnderecoCobranca { get; set; }
        public virtual Endereco EnderecoEntrega { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }
        public virtual RamoAtividade RamoAtividade { get; set; }
        public virtual CondicoesPagamento CondicoesPagamento { get; set; }

        public virtual List<ContasReceber> ContasReceber{ get; set; }
        public virtual List<ContatoCliente> ContatosCliente { get; set; }
        public virtual List<NotaFiscal> NotasFiscais { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }

        public Cliente() { }
        public Cliente(CriarClienteRequestBody requestBody) => requestBody.MappingProperties(this);
    }
}
