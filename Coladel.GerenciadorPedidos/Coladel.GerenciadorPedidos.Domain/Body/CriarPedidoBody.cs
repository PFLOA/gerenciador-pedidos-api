using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System;
using System.Collections.Generic;

namespace A4S.ERP.Domain.Body
{
    public class CriarPedidoBody
    {
        public StatusPedido StatusPedido { get; set; } = StatusPedido.EM_ANDAMENTO;
        public string NF { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public string Observacoes { get; set; }
        public decimal Total { get; set; }
        public Guid ClienteGuid { get; set; }
        public decimal PorcentagemComissao { get; set; }
        public short CondicoesPagamentoId { get; set; }
        public List<ItensPedido> ItensPedido { get; set; }

        public virtual Pedido ToModel() => new Pedido(this);
    }
}
