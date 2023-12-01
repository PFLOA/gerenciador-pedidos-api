using A4S.Core.Extensions;
using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Enum;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Pedido : Entity
    {
        public short ClienteId { get; set; }
        public short? CondicoesPagamentoId { get; set; }

        public decimal Total { get; set; }
        public decimal TotalComissao { get; set; }
<<<<<<< HEAD

        public string NF { get; set; }
        public string Observacoes { get; set; }

        public StatusPedido StatusPedido { get; set; }

        public virtual CondicoesPagamento CondicoesPagamento { get; set; }
        public virtual List<ItensPedido> ItensPedido { get; set; }

        [IgnoreDataMember]
        public virtual Cliente Cliente { get; set; }
=======
        public short IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual List<ItensPedido> ItensPedido { get; set; }
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6

        public Pedido() { }
        public Pedido(CriarPedidoBody criarPedidoBody) => criarPedidoBody.MappingProperties(this);

        public void CalculoComissao(decimal porcentagem)
        {
            TotalComissao = Total * (porcentagem / 100);
        }

        public void EntregarPedido()
        {
            StatusPedido = StatusPedido.ENTREGUE;
        }

        public void EmAtraso()
        {
            StatusPedido = StatusPedido.ATRASO;
        }

        public void PedidoProgramado()
        {
            StatusPedido = StatusPedido.PROGRAMADO;
        }

        public void Cancelar()
        {
            StatusPedido = StatusPedido.CANCELAR;
        }
    }
}
